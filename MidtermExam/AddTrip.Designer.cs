namespace MidtermExam
{
    partial class AddTrip
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
            this.label1 = new System.Windows.Forms.Label();
            this.shipsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tripDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Ship";
            // 
            // shipsComboBox
            // 
            this.shipsComboBox.FormattingEnabled = true;
            this.shipsComboBox.Location = new System.Drawing.Point(129, 39);
            this.shipsComboBox.Name = "shipsComboBox";
            this.shipsComboBox.Size = new System.Drawing.Size(121, 21);
            this.shipsComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Date";
            // 
            // tripDateTimePicker
            // 
            this.tripDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tripDateTimePicker.Location = new System.Drawing.Point(129, 197);
            this.tripDateTimePicker.MinDate = new System.DateTime(2013, 2, 27, 0, 0, 0, 0);
            this.tripDateTimePicker.Name = "tripDateTimePicker";
            this.tripDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tripDateTimePicker.TabIndex = 4;
            this.tripDateTimePicker.Value = new System.DateTime(2013, 11, 29, 0, 0, 0, 0);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 253);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Trip";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(159, 253);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // portListBox
            // 
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(441, 39);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(186, 225);
            this.portListBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Port";
            // 
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tripDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shipsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddTrip";
            this.Text = "AddTrip";
            this.Load += new System.EventHandler(this.AddTrip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox shipsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tripDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.Label label4;
    }
}