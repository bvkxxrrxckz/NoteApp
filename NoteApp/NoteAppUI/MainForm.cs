using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Project project = new Project();
            Note note = new Note(
                "Купить",
                NoteCategory.Home,
                "fffpfpfpffp");
                
            project.Notes.Add(note);

            note = new Note(
                "Забрать",
                NoteCategory.Work,
                "text test");

            project.Notes.Add(note);

           ProjectManager.Save(ProjectManager._filePath,project);



        }
    }
}
