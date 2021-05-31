using System.Collections.Generic;


namespace NoteApp
{
    /// <summary>
    /// Класс для создания списка заметок.
    /// </summary>
   public class Project
    {
        /// <summary>
        /// Создает c заметок.
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
