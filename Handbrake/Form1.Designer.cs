namespace Handbrake
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
            listViewDirectories = new ListView();
            listViewFiles = new ListView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            txtMinSize = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // listViewDirectories
            // 
            listViewDirectories.AllowDrop = true;
            listViewDirectories.Location = new Point(12, 86);
            listViewDirectories.Name = "listViewDirectories";
            listViewDirectories.Size = new Size(939, 182);
            listViewDirectories.TabIndex = 0;
            listViewDirectories.UseCompatibleStateImageBehavior = false;
            listViewDirectories.View = View.List;
            listViewDirectories.DragDrop += listViewDirectories_DragDrop;
            listViewDirectories.DragEnter += listViewDirectories_DragEnter;
            // 
            // listViewFiles
            // 
            listViewFiles.AllowDrop = true;
            listViewFiles.Location = new Point(12, 330);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(939, 183);
            listViewFiles.TabIndex = 1;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.DragDrop += listViewFiles_DragDrop;
            listViewFiles.DragEnter += listViewFiles_DragEnter;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Folders";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(12, 294);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Files";
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Location = new Point(1006, 303);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Location = new Point(1148, 303);
            button2.Name = "button2";
            button2.Size = new Size(126, 45);
            button2.TabIndex = 5;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1055, 151);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.Location = new Point(75, 44);
            button3.Name = "button3";
            button3.Size = new Size(92, 31);
            button3.TabIndex = 7;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.Location = new Point(56, 289);
            button4.Name = "button4";
            button4.Size = new Size(92, 31);
            button4.TabIndex = 8;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtMinSize
            // 
            txtMinSize.Location = new Point(1121, 195);
            txtMinSize.Name = "txtMinSize";
            txtMinSize.Size = new Size(93, 27);
            txtMinSize.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1010, 197);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 10;
            label4.Text = "Minimum Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1042, 217);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 11;
            label5.Text = "in MB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 577);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMinSize);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewFiles);
            Controls.Add(listViewDirectories);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDirectories;
        private ListView listViewFiles;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Button button4;
        private TextBox txtMinSize;
        private Label label4;
        private Label label5;
    }
}
