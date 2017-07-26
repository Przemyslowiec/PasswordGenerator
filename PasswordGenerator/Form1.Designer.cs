namespace PasswordGenerator
{
    partial class main_window
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
            this.title_label = new System.Windows.Forms.Label();
            this.generated_password_text_box = new System.Windows.Forms.TextBox();
            this.generate_password_button = new System.Windows.Forms.Button();
            this.lenght_combo_box = new System.Windows.Forms.ComboBox();
            this.password_lenght_label = new System.Windows.Forms.Label();
            this.pasword_label = new System.Windows.Forms.Label();
            this.uppercase_leters_check_box = new System.Windows.Forms.CheckBox();
            this.lowercase_check_box = new System.Windows.Forms.CheckBox();
            this.specjal_marks_check_box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.SystemColors.Control;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title_label.Location = new System.Drawing.Point(16, 8);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(598, 69);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Password generator ";
            // 
            // generated_password_text_box
            // 
            this.generated_password_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generated_password_text_box.Location = new System.Drawing.Point(33, 512);
            this.generated_password_text_box.Multiline = true;
            this.generated_password_text_box.Name = "generated_password_text_box";
            this.generated_password_text_box.Size = new System.Drawing.Size(586, 70);
            this.generated_password_text_box.TabIndex = 1;
            // 
            // generate_password_button
            // 
            this.generate_password_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generate_password_button.Location = new System.Drawing.Point(26, 304);
            this.generate_password_button.Name = "generate_password_button";
            this.generate_password_button.Size = new System.Drawing.Size(600, 99);
            this.generate_password_button.TabIndex = 2;
            this.generate_password_button.Text = "Generate";
            this.generate_password_button.UseVisualStyleBackColor = true;
            this.generate_password_button.Click += new System.EventHandler(this.generate_password_button_Click);
            // 
            // lenght_combo_box
            // 
            this.lenght_combo_box.DropDownHeight = 150;
            this.lenght_combo_box.FormattingEnabled = true;
            this.lenght_combo_box.IntegralHeight = false;
            this.lenght_combo_box.ItemHeight = 16;
            this.lenght_combo_box.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.lenght_combo_box.Location = new System.Drawing.Point(256, 112);
            this.lenght_combo_box.Name = "lenght_combo_box";
            this.lenght_combo_box.Size = new System.Drawing.Size(356, 24);
            this.lenght_combo_box.TabIndex = 10;
            // 
            // password_lenght_label
            // 
            this.password_lenght_label.AutoSize = true;
            this.password_lenght_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_lenght_label.Location = new System.Drawing.Point(8, 104);
            this.password_lenght_label.Name = "password_lenght_label";
            this.password_lenght_label.Size = new System.Drawing.Size(225, 32);
            this.password_lenght_label.TabIndex = 11;
            this.password_lenght_label.Text = "Password lenght";
            // 
            // pasword_label
            // 
            this.pasword_label.AutoSize = true;
            this.pasword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pasword_label.Location = new System.Drawing.Point(192, 440);
            this.pasword_label.Name = "pasword_label";
            this.pasword_label.Size = new System.Drawing.Size(268, 58);
            this.pasword_label.TabIndex = 12;
            this.pasword_label.Text = "Password:";
            // 
            // uppercase_leters_check_box
            // 
            this.uppercase_leters_check_box.AutoSize = true;
            this.uppercase_leters_check_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uppercase_leters_check_box.Location = new System.Drawing.Point(16, 224);
            this.uppercase_leters_check_box.Name = "uppercase_leters_check_box";
            this.uppercase_leters_check_box.Size = new System.Drawing.Size(251, 36);
            this.uppercase_leters_check_box.TabIndex = 18;
            this.uppercase_leters_check_box.Text = "Uppercase leters";
            this.uppercase_leters_check_box.UseVisualStyleBackColor = true;
            // 
            // lowercase_check_box
            // 
            this.lowercase_check_box.AutoSize = true;
            this.lowercase_check_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lowercase_check_box.Location = new System.Drawing.Point(16, 168);
            this.lowercase_check_box.Name = "lowercase_check_box";
            this.lowercase_check_box.Size = new System.Drawing.Size(251, 36);
            this.lowercase_check_box.TabIndex = 19;
            this.lowercase_check_box.Text = "Lowercase leters";
            this.lowercase_check_box.UseVisualStyleBackColor = true;
            // 
            // specjal_marks_check_box
            // 
            this.specjal_marks_check_box.AutoSize = true;
            this.specjal_marks_check_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specjal_marks_check_box.Location = new System.Drawing.Point(400, 192);
            this.specjal_marks_check_box.Name = "specjal_marks_check_box";
            this.specjal_marks_check_box.Size = new System.Drawing.Size(215, 36);
            this.specjal_marks_check_box.TabIndex = 20;
            this.specjal_marks_check_box.Text = "Specjal marks";
            this.specjal_marks_check_box.UseVisualStyleBackColor = true;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 603);
            this.Controls.Add(this.specjal_marks_check_box);
            this.Controls.Add(this.lowercase_check_box);
            this.Controls.Add(this.uppercase_leters_check_box);
            this.Controls.Add(this.pasword_label);
            this.Controls.Add(this.lenght_combo_box);
            this.Controls.Add(this.generate_password_button);
            this.Controls.Add(this.generated_password_text_box);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.password_lenght_label);
            this.Name = "main_window";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox generated_password_text_box;
        private System.Windows.Forms.Button generate_password_button;
        private System.Windows.Forms.ComboBox lenght_combo_box;
        private System.Windows.Forms.Label password_lenght_label;
        private System.Windows.Forms.Label pasword_label;
        private System.Windows.Forms.CheckBox uppercase_leters_check_box;
        private System.Windows.Forms.CheckBox lowercase_check_box;
        private System.Windows.Forms.CheckBox specjal_marks_check_box;
    }
}

