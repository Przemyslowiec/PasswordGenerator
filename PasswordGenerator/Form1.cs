using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class main_window : Form
    {
        password_generator ge;
        public main_window()
        {
            InitializeComponent();
            ge = new password_generator();
        }

        private void MessageBox_Error()
        {
            string message = "Somethig gone wrong, do you want try again";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            {
                // Closes the parent form.
                this.Close();
            }
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
            }
        }

        private void generate_password_button_Click(object sender, EventArgs e)
        {
            int _case = 0;
            if (lowercase_check_box.Checked)
            {
                _case += 3;
            }
            if (uppercase_leters_check_box.Checked)
            {
                _case += 5;
            }
            if (specjal_marks_check_box.Checked)
            {
                _case += 7;
            }

            if (!lowercase_check_box.Checked && !uppercase_leters_check_box.Checked && !specjal_marks_check_box.Checked
                || lenght_combo_box.SelectedItem == null)
            {
                MessageBox_Error();
            }
            else
            {
                generated_password_text_box.Text = ge.generate(Convert.ToInt32(lenght_combo_box.Text), _case);
            }
        }

        
    }
}
