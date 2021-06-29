
namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CreatedTimeLabel = new System.Windows.Forms.Label();
            this.SelectedCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAlrF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteDelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifiedTimeLabel = new System.Windows.Forms.Label();
            this.ModificationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteFileButton = new System.Windows.Forms.Button();
            this.EditFileButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ModificationTimeDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreationTimeDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedTimeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SelectedCategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
            this.splitContainer1.Size = new System.Drawing.Size(857, 429);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(3, 32);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(279, 355);
            this.NotesListBox.TabIndex = 2;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(85, 5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(197, 21);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 8);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(85, 13);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show Category: ";
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(3, 72);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(562, 354);
            this.TextBox.TabIndex = 3;
            // 
            // CreatedTimeLabel
            // 
            this.CreatedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTimeLabel.AutoSize = true;
            this.CreatedTimeLabel.Location = new System.Drawing.Point(4, 54);
            this.CreatedTimeLabel.Name = "CreatedTimeLabel";
            this.CreatedTimeLabel.Size = new System.Drawing.Size(50, 13);
            this.CreatedTimeLabel.TabIndex = 3;
            this.CreatedTimeLabel.Text = "Created: ";
            // 
            // SelectedCategoryLabel
            // 
            this.SelectedCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCategoryLabel.AutoSize = true;
            this.SelectedCategoryLabel.Location = new System.Drawing.Point(56, 32);
            this.SelectedCategoryLabel.Name = "SelectedCategoryLabel";
            this.SelectedCategoryLabel.Size = new System.Drawing.Size(48, 13);
            this.SelectedCategoryLabel.TabIndex = 2;
            this.SelectedCategoryLabel.Text = "category";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(4, 32);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category: ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(86, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title Note";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(857, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAlrF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitAlrF4ToolStripMenuItem
            // 
            this.exitAlrF4ToolStripMenuItem.Name = "exitAlrF4ToolStripMenuItem";
            this.exitAlrF4ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitAlrF4ToolStripMenuItem.Text = "Exit Alr+F4";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteDelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // removeNoteDelToolStripMenuItem
            // 
            this.removeNoteDelToolStripMenuItem.Name = "removeNoteDelToolStripMenuItem";
            this.removeNoteDelToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.removeNoteDelToolStripMenuItem.Text = "Remove Note Del";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutF1ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutF1ToolStripMenuItem
            // 
            this.aboutF1ToolStripMenuItem.Name = "aboutF1ToolStripMenuItem";
            this.aboutF1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutF1ToolStripMenuItem.Text = "About F1";
            // 
            // ModifiedTimeLabel
            // 
            this.ModifiedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifiedTimeLabel.AutoSize = true;
            this.ModifiedTimeLabel.Location = new System.Drawing.Point(231, 54);
            this.ModifiedTimeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.ModifiedTimeLabel.Name = "ModifiedTimeLabel";
            this.ModifiedTimeLabel.Size = new System.Drawing.Size(53, 13);
            this.ModifiedTimeLabel.TabIndex = 6;
            this.ModifiedTimeLabel.Text = "Modified: ";
            // 
            // ModificationTimeDateTimePicker
            // 
            this.ModificationTimeDateTimePicker.CustomFormat = "dd.MM.yy  HH:mm";
            this.ModificationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModificationTimeDateTimePicker.Location = new System.Drawing.Point(289, 48);
            this.ModificationTimeDateTimePicker.Name = "ModificationTimeDateTimePicker";
            this.ModificationTimeDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.ModificationTimeDateTimePicker.TabIndex = 5;
            // 
            // CreationTimeDateTimePicker
            // 
            this.CreationTimeDateTimePicker.CustomFormat = "dd.MM.yy  HH:mm";
            this.CreationTimeDateTimePicker.Enabled = false;
            this.CreationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTimeDateTimePicker.Location = new System.Drawing.Point(59, 48);
            this.CreationTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CreationTimeDateTimePicker.Name = "CreationTimeDateTimePicker";
            this.CreationTimeDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.CreationTimeDateTimePicker.TabIndex = 4;
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteFileButton.FlatAppearance.BorderSize = 0;
            this.DeleteFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFileButton.Image = global::NoteAppUI.Properties.Resources.DeleteFile;
            this.DeleteFileButton.Location = new System.Drawing.Point(90, 393);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(33, 31);
            this.DeleteFileButton.TabIndex = 5;
            this.DeleteFileButton.UseVisualStyleBackColor = true;
            // 
            // EditFileButton
            // 
            this.EditFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditFileButton.FlatAppearance.BorderSize = 0;
            this.EditFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFileButton.Image = global::NoteAppUI.Properties.Resources.EditFile;
            this.EditFileButton.Location = new System.Drawing.Point(51, 393);
            this.EditFileButton.Name = "EditFileButton";
            this.EditFileButton.Size = new System.Drawing.Size(33, 31);
            this.EditFileButton.TabIndex = 4;
            this.EditFileButton.UseVisualStyleBackColor = true;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFileButton.FlatAppearance.BorderSize = 0;
            this.AddFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFileButton.Image = global::NoteAppUI.Properties.Resources.AddFile;
            this.AddFileButton.Location = new System.Drawing.Point(12, 393);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(33, 31);
            this.AddFileButton.TabIndex = 3;
            this.AddFileButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Label CreatedTimeLabel;
        private System.Windows.Forms.Label SelectedCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAlrF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteDelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutF1ToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button DeleteFileButton;
        private System.Windows.Forms.Button EditFileButton;
        private System.Windows.Forms.Label ModifiedTimeLabel;
        private System.Windows.Forms.DateTimePicker ModificationTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreationTimeDateTimePicker;
    }
}

