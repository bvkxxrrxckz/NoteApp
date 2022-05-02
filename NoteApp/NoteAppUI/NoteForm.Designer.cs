
namespace NoteAppUI
{
    partial class NoteForm
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
            this.components = new System.ComponentModel.Container();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ModifiedTimeLabel = new System.Windows.Forms.Label();
            this.ModificationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedTimeLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TitleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title: ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleTextBox.Location = new System.Drawing.Point(70, 21);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(517, 20);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 50);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(70, 47);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(195, 21);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ModifiedTimeLabel
            // 
            this.ModifiedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifiedTimeLabel.AutoSize = true;
            this.ModifiedTimeLabel.Location = new System.Drawing.Point(245, 79);
            this.ModifiedTimeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.ModifiedTimeLabel.Name = "ModifiedTimeLabel";
            this.ModifiedTimeLabel.Size = new System.Drawing.Size(53, 13);
            this.ModifiedTimeLabel.TabIndex = 10;
            this.ModifiedTimeLabel.Text = "Modified: ";
            // 
            // ModificationTimeDateTimePicker
            // 
            this.ModificationTimeDateTimePicker.CustomFormat = "dd.MM.yy  HH:mm";
            this.ModificationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModificationTimeDateTimePicker.Location = new System.Drawing.Point(303, 73);
            this.ModificationTimeDateTimePicker.Name = "ModificationTimeDateTimePicker";
            this.ModificationTimeDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.ModificationTimeDateTimePicker.TabIndex = 9;
            // 
            // CreationTimeDateTimePicker
            // 
            this.CreationTimeDateTimePicker.CustomFormat = "dd.MM.yy  HH:mm";
            this.CreationTimeDateTimePicker.Enabled = false;
            this.CreationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTimeDateTimePicker.Location = new System.Drawing.Point(67, 73);
            this.CreationTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CreationTimeDateTimePicker.Name = "CreationTimeDateTimePicker";
            this.CreationTimeDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.CreationTimeDateTimePicker.TabIndex = 8;
            // 
            // CreatedTimeLabel
            // 
            this.CreatedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTimeLabel.AutoSize = true;
            this.CreatedTimeLabel.Location = new System.Drawing.Point(12, 79);
            this.CreatedTimeLabel.Name = "CreatedTimeLabel";
            this.CreatedTimeLabel.Size = new System.Drawing.Size(50, 13);
            this.CreatedTimeLabel.TabIndex = 7;
            this.CreatedTimeLabel.Text = "Created: ";
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(12, 98);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(575, 350);
            this.TextBox.TabIndex = 11;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(431, 454);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(512, 454);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 501);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ModifiedTimeLabel);
            this.Controls.Add(this.ModificationTimeDateTimePicker);
            this.Controls.Add(this.CreationTimeDateTimePicker);
            this.Controls.Add(this.CreatedTimeLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ModifiedTimeLabel;
        private System.Windows.Forms.DateTimePicker ModificationTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker CreationTimeDateTimePicker;
        private System.Windows.Forms.Label CreatedTimeLabel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ToolTip TitleToolTip;
    }
}