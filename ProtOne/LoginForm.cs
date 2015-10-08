using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtOne
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the LOGIN button
        /// if the login is successfull then proceed to Form2 
        /// else a messagebox will appear, to say that the login is not successful. 
        /// If login was not successful the user can retry or cancel. The cancel option will exit the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // get the username the user entered
            string username = textBox1.Text;

            //get the password the user entered
            string password = textBox2.Text;

            //at the moment the comparison is childish just to make sure the logic works. 
            if (username == "Elly" && password == "and")
            {
                //MessageBox.Show("Login is successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //navigate to mainform
                MainForm f = new MainForm(); //we can send more than 1 parameters here.
                // show Main form object, and hide the login form view
                f.Show();
                this.Hide();
            }
            else //if login was NOT successful
            {
                //messagebox appears
                DialogResult dr = MessageBox.Show("Login was not successful", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                //if user clicks cancel
                if (dr == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else //if user clicks retry
                {
                    clearFields();
                }
            }

        }

        /// <summary>
        /// This is the CLEAR button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        /// <summary>
        /// This is the NEW User Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // go to new user form
            NewUser f = new NewUser();
            f.ShowDialog(); // it will not hide this form, it will just place it on the background, unaccessible
        }

        /// <summary>
        /// It clears all the texfields of the form
        /// </summary>
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
