using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Метод для сортировки списка заметок по времени последнего изменения.
        /// </summary>
        public List<Note> SortByModificationTime()
        {
            var sortedNotes =
                Notes.OrderByDescending(note => note.Modified).ToList();

            return sortedNotes;
        }


        /// <summary>
        /// Возвращает и задает индекс текущей заметки в NotesListBox.
        /// </summary>
        public int CurrentNoteIndex { get; set; }

        /// <summary>
        /// Метод для сортировки списка заметок определенной категории по времени 
        /// последнего изменения.
        /// </summary>
        public List<Note> SortByModificationTimeAndCategory(NoteCategory category)
        {
            var sortedNotesCategory =
                Notes.Where(note => note.Category == category).ToList();
            var sortedNotes =
                sortedNotesCategory.OrderByDescending(note => note.Modified).ToList();

            return sortedNotes;
        }
    }
}
