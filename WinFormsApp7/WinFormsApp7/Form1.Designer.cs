namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            list = new ListView();
            textbox = new RichTextBox();
            create = new Button();
            save = new Button();
            delete = new Button();
            Title = new TextBox();
            fontDialog = new FontDialog();
            btnSetFont = new Button();
            btnSetColor = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // list
            // 
            list.Location = new Point(129, 31);
            list.Name = "list";
            list.Size = new Size(121, 97);
            list.TabIndex = 0;
            list.UseCompatibleStateImageBehavior = false;
            // 
            // textbox
            // 
            textbox.Location = new Point(294, 60);
            textbox.Name = "textbox";
            textbox.Size = new Size(121, 49);
            textbox.TabIndex = 1;
            textbox.Text = "";
            // 
            // create
            // 
            create.Location = new Point(139, 168);
            create.Name = "create";
            create.Size = new Size(93, 23);
            create.TabIndex = 2;
            create.Text = "Create note";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // save
            // 
            save.Location = new Point(325, 168);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 3;
            save.Text = "Save note";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // delete
            // 
            delete.Location = new Point(511, 168);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 4;
            delete.Text = "Delete note";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Title
            // 
            Title.Location = new Point(294, 31);
            Title.Name = "Title";
            Title.Size = new Size(121, 23);
            Title.TabIndex = 5;
            // 
            // btnSetFont
            // 
            btnSetFont.Location = new Point(519, 112);
            btnSetFont.Name = "btnSetFont";
            btnSetFont.Size = new Size(75, 23);
            btnSetFont.TabIndex = 6;
            btnSetFont.Text = "setfont";
            btnSetFont.UseVisualStyleBackColor = true;
            btnSetFont.Click += btnSetFont_Click;
            // 
            // btnSetColor
            // 
            btnSetColor.Location = new Point(522, 80);
            btnSetColor.Name = "btnSetColor";
            btnSetColor.Size = new Size(75, 23);
            btnSetColor.TabIndex = 7;
            btnSetColor.Text = "setcolor";
            btnSetColor.UseVisualStyleBackColor = true;
            btnSetColor.Click += btnSetColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetColor);
            Controls.Add(btnSetFont);
            Controls.Add(Title);
            Controls.Add(delete);
            Controls.Add(save);
            Controls.Add(create);
            Controls.Add(textbox);
            Controls.Add(list);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView list;
        private RichTextBox textbox;
        private Button create;
        private Button save;
        private Button delete;
        private TextBox Title;
        private FontDialog fontDialog;
        private Button btnSetFont;
        private Button btnSetColor;
        private ColorDialog colorDialog1;
    }
}