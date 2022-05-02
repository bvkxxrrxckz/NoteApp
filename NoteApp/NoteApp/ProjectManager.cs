using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
	public static class ProjectManager
	{
        /// <summary>
        /// Хранит в себе путь к папке.
        /// </summary>
        /// 
       private const string _nameFile = @"NoteApp.json";
        public static string _filePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                                + @"\AlexeyCompany\NoteApp\"+_nameFile;

		/// <summary>
		/// Хранит в себе путь к файлу.
		/// </summary>
		//public static string _filePath = _folder + @"NoteApp.json";

		/// <summary>
		/// Проверяет создана ли папка. Сохраняет файл.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="project"></param>
		
        public static void SaveToFile(Project data, string path)
        {
            // Если какой-либо каталог (и/или подкаталоги), указанные в пути к файлу,
            // в который необходимо сохранить данные, не существует, то предварительно
            // создаем этот каталог (и/или подкаталоги).
            //
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            JsonSerializer serializer = new JsonSerializer();
            ConfigureSettings(serializer);

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }



        /// <summary>
        /// Заносим данные с файла.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>
        ///Возвращаем все данные файла.
        /// </returns>
        public static Project LoadFromFile(string path)
        {
            Project project = null;

            // Если файл, из которого необходимо загрузить данные, не существует, то
            // возвращаем объект класса Project, созданный конструктором по умолчанию.
            //
            if (!File.Exists(path))
            {
                return new Project();
            }

            JsonSerializer serializer = new JsonSerializer();
            ConfigureSettings(serializer);

            // В случае возникновения любых исключений в процессе открытия потока для
            // чтения из файла также возвращаем объект класса Project, созданный
            // конструктором по умолчанию.
            //
            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
            }
            catch (Exception)
            {
                return new Project();
            }

            // Метод в любом случае должен возвращать объект класса Project.
            return project ?? new Project();
        }
        private static void ConfigureSettings(JsonSerializer serializer)
        {
            serializer.Formatting = Formatting.Indented;
        }

    }
}
