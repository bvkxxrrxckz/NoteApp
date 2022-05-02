using NoteApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {

        /// <summary>
        /// Текстовая заметка пользователя, подлежащая добавлению или редактированию.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Флаг, определяющий, корректны ли введенные пользователем данные текущей заметки.
        /// </summary>
        private bool _hasErrors = false;

        /// <summary>
        /// Цвет, который принимает поле окна <see cref="NoteForm"/> содержащее 
        /// некорректные данные. 
        /// </summary>
        private Color _errorColor = Color.LightCoral;

        /// <summary>
        /// Возвращает и задает текстовую заметку пользователя, подлежащую добавлению или
        /// редактированию. 
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }

            set
            {
                _note = value ?? new Note();

                // Отображаем в окне редактирования все данные добавляемой (редактируемой) заметки.
                TitleTextBox.Text = _note.Title;
                CategoryComboBox.SelectedItem = _note.Category;
                TextBox.Text = _note.Text;
                CreationTimeDateTimePicker.Value = DateTime.Now;
                ModificationTimeDateTimePicker.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// Создает экземпляр.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }


        

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Если окно редактирования не содержит никаких ошибок пользовательского ввода,
            // сохраняем все изменения. В противном случае отображаем пользователю список ошибок,
            // которые ему нужно исправить, чтобы можно было сохранить заметку.
            //
            if (!_hasErrors)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("You need to correct the following data:\n\n" +
                    TitleToolTip.GetToolTip(TitleTextBox), "Error List",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Title = TitleTextBox.Text;
                ModificationTimeDateTimePicker.Value = Note.Modified;
                TitleTextBox.BackColor = SystemColors.Window;
                _hasErrors = false;
                TitleToolTip.SetToolTip(TitleTextBox, null);
            }

            // В случае, если название заметки содержит более 50 символов, подсвечиваем поле ввода
            // красным цветом и отображаем всплывающую подсказку с текстом ошибки. 
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _errorColor;
                _hasErrors = true;
                TitleToolTip.SetToolTip(TitleTextBox, exception.Message);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
            ModificationTimeDateTimePicker.Value = Note.Modified;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Text = TextBox.Text;
            ModificationTimeDateTimePicker.Value = Note.Modified;
        }
    }
}
