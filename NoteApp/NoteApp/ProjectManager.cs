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
		private static string _folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
								+@"\AlexeyCompany\NoteApp";

		/// <summary>
		/// Хранит в себе путь к файлу.
		/// </summary>
		public static string _filePath = _folder + @"\NoteApp.json";

		/// <summary>
		/// Проверяет создана ли папка. Сохраняет файл.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="project"></param>
		public static void Save(string path, Project project)
		{
			string directory = Path.GetDirectoryName(path);
			if (!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(_filePath))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, project);
			}

		}

		/// <summary>
		/// Заносим данные с файла.
		/// </summary>
		/// <param name="path"></param>
		/// <returns>
		///Возвращаем все данные файла.
		/// </returns>
        public static Project Load(string path)
        {
            Project project = new Project();
            if (!File.Exists(path))
            {
                return project;
            }

            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(_filePath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = (Project) serializer.Deserialize<Project>(reader);
                    if (project == null)
                    {
                        return new Project();
                    }
                }
            }
            catch
            {
                return new Project();
            }

            return project;
        }

    }
}
