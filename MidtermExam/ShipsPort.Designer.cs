namespace MidtermExam
{
    partial class ShipsPort
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shipsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(124, 49);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Code";
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(124, 108);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(100, 23);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "List Ships Code";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ships";
            // 
            // shipsListBox
            // 
            this.shipsListBox.FormattingEnabled = true;
            this.shipsListBox.Location = new System.Drawing.Point(42, 185);
            this.shipsListBox.Name = "shipsListBox";
            this.shipsListBox.Size = new System.Drawing.Size(426, 225);
            this.shipsListBox.TabIndex = 4;
            // 
            // ShipsPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.shipsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTextBox);
            this.Name = "ShipsPort";
            this.Text = "ShipsPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox shipsListBox;
    }
}