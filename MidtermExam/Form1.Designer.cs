namespace MidtermExam
{
    partial class Form1
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
            this.question1Button = new System.Windows.Forms.Button();
            this.question2Button = new System.Windows.Forms.Button();
            this.question3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question1Button
            // 
            this.question1Button.Location = new System.Drawing.Point(33, 31);
            this.question1Button.Name = "question1Button";
            this.question1Button.Size = new System.Drawing.Size(315, 38);
            this.question1Button.TabIndex = 0;
            this.question1Button.Text = "Add Trip";
            this.question1Button.UseVisualStyleBackColor = true;
            this.question1Button.Click += new System.EventHandler(this.question1Button_Click);
            // 
            // question2Button
            // 
            this.question2Button.Location = new System.Drawing.Point(33, 89);
            this.question2Button.Name = "question2Button";
            this.question2Button.Size = new System.Drawing.Size(315, 36);
            this.question2Button.TabIndex = 0;
            this.question2Button.Text = "View And Edit Trips";
            this.question2Button.UseVisualStyleBackColor = true;
            this.question2Button.Click += new System.EventHandler(this.question2Button_Click);
            // 
            // question3Button
            // 
            this.question3Button.Location = new System.Drawing.Point(33, 148);
            this.question3Button.Name = "question3Button";
            this.question3Button.Size = new System.Drawing.Size(315, 38);
            this.question3Button.TabIndex = 0;
            this.question3Button.Text = "List Ships By Port";
            this.question3Button.UseVisualStyleBackColor = true;
            this.question3Button.Click += new System.EventHandler(this.question3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 242);
            this.Controls.Add(this.question3Button);
            this.Controls.Add(this.question2Button);
            this.Controls.Add(this.question1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button question1Button;
        private System.Windows.Forms.Button question2Button;
        private System.Windows.Forms.Button question3Button;
    }
}

