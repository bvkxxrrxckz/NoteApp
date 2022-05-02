using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NoteApp;



namespace NoteAppUI
{
    /// <summary>
    /// Главное окно прилжения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения экземпляра проекта
        /// </summary>
        private Project _project;

        /// <summary>
        /// Поле для хранения списка заметок, отсортированных по времени последнего изменения.
        /// </summary>
        private List<Note> _filteredNotes;

        public MainForm()
        {
            InitializeComponent();

            _project = ProjectManager.LoadFromFile(ProjectManager._filePath);
            FillCategoryComboBox();
            UpdateNotesListBox();

            // "Восстанавливаем" последнюю текущую заметку с предыдущего запуска приложения.
            if (_filteredNotes.Count != 0)
            {
                NotesListBox.SelectedIndex = _project.CurrentNoteIndex;
            }
        }

        private void FillCategoryComboBox()
        {
            // Добавляем к перечню категорий заметки дополнительную категорию "All".
            CategoryComboBox.Items.Add("All");

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }

            // Устанавливаем категорию "All" в качестве текущей.
            CategoryComboBox.SelectedIndex = 0;
        }

        private void UpdateNotesListBox()
        {
            // Если выбрана категория заметок "All", то сортируем заметки всех категорий
            // по времени последнего обновления.
            //
            if (CategoryComboBox.SelectedIndex == 0)
            {
                _project.Notes = _project.SortByModificationTime();
                _filteredNotes = _project.Notes.ToList();
            }

            // Если выбрана какая-то определенная категория заметок, то сортируем по
            // времени последнего обновления только те заметки, которые относятся к данной
            // категории.
            else
            {
                _filteredNotes =
                    _project.SortByModificationTimeAndCategory(
                    (NoteCategory)CategoryComboBox.SelectedItem);
            }

            NotesListBox.DataSource = null;
            NotesListBox.DataSource = _filteredNotes;
            NotesListBox.DisplayMember = nameof(Note.Title);
        }

        private void UpdateCurrentNoteIndex()
        {
            _project.CurrentNoteIndex = NotesListBox.Items.Count != 0 ?
                NotesListBox.SelectedIndex : 0;
        }

        private void DisplayEmptyNote()
        {
            TitleLabel.Text = @"";
            SelectedCategoryLabel.Text = @"";
            TextBox.Text = @"";
            CreationTimeDateTimePicker.Value = DateTime.Now;
            CreationTimeDateTimePicker.Value = DateTime.Now;
        }

        private void AddFileButton_Click(object sender, System.EventArgs e)
        {
            var noteForm = new NoteForm();

            noteForm.Note = new Note();
            
            if (CategoryComboBox.SelectedItem!=null&&
                CategoryComboBox.SelectedItem.ToString()!="All")
            {
                noteForm.Note = new Note((NoteCategory)CategoryComboBox.SelectedItem);
            }

            noteForm.ShowDialog();

            // Добавляем новую заметку в список всех заметок приложения только в том случае, если
            // пользователь подтверждает ее добавление.
            // 
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var addedNote = noteForm.Note;
                _project.Notes.Add(addedNote);

                UpdateNotesListBox();
                UpdateCurrentNoteIndex();
                ProjectManager.SaveToFile(_project, ProjectManager._filePath);
            }
        }

        private void EditFileButton_Click(object sender, System.EventArgs e)
        {
            var selectedIndex = NotesListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            var selectedNote = _filteredNotes[selectedIndex];
            var realProjectIndex = _project.Notes.IndexOf(selectedNote);
            var noteForm = new NoteForm();

            // При редактировании заметки работаем с ее копией.
            noteForm.Note = (Note)selectedNote.Clone();
            noteForm.ShowDialog();

            // Применяем к заметке изменения, только если пользователь подтверждает сохранение
            // изменений.
            //
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var editedNote = noteForm.Note;

                // Заменяем предыдущую версию заметки новой, отредактированной версией.
                //
                _project.Notes.RemoveAt(realProjectIndex);
                _project.Notes.Insert(realProjectIndex, editedNote);

                UpdateNotesListBox();
                UpdateCurrentNoteIndex();
                ProjectManager.SaveToFile(_project, ProjectManager._filePath);
            }
        }

        private void DeleteFileButton_Click(object sender, System.EventArgs e)
        {
            var selectedIndex = NotesListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            var selectedNote = (Note)NotesListBox.SelectedItem;
            var realProjectIndex = _project.Notes.IndexOf(selectedNote);

            // Перед удалением текущей заметки запрашиваем подтверждение у пользователя.
            DialogResult result = MessageBox.Show($"Do you really want to remove " +
                $"this note: {selectedNote.Title}?", "Removing The Note",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Удаляем заметку только в том случае, если пользователь подтвердит удаление.
            //
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(realProjectIndex);

                UpdateNotesListBox();
                UpdateCurrentNoteIndex();
                ProjectManager.SaveToFile(_project, ProjectManager._filePath);

                // Отображаем пользователю пустую заметку, если удалили последнюю заметку в списке.
                //
                if (_filteredNotes.Count == 0)
                {
                    DisplayEmptyNote();
                }
            }
        }

       

        private void NotesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedNote = (Note)NotesListBox.SelectedItem;

            // Если выбрана некая заметка, заполняем правую часть главного окна данными этой
            // заметки.
            //
            if (selectedNote != null)
            {
                TitleLabel.Text = selectedNote.Title;
                SelectedCategoryLabel.Text = selectedNote.Category.ToString();
                TextBox.Text = selectedNote.Text;
                CreationTimeDateTimePicker.Value = selectedNote.Created;
                ModificationTimeDateTimePicker.Value = selectedNote.Modified;
                return;
            }

            DisplayEmptyNote();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Перед закрытием приложения запоминаем текущую заметку, чтобы отобразить ее при
            // следующем запуске.
            UpdateCurrentNoteIndex();
            ProjectManager.SaveToFile(_project, ProjectManager._filePath);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // При каждом изменении выбранной категории обновляем список заметок, отображаемых
            // пользователю.
            UpdateNotesListBox();
        }
    }
}
