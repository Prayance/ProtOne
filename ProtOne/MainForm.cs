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
    public partial class MainForm : Form
    {
        public MainForm() 
        {
            InitializeComponent();
        }

        Timer mySlowTimer; // This timer keeps track of the today's date.

        /// <summary>
        /// Every time the user closes the form, it asks for verification. 
        /// If the user wants to exit the program then click ok and exits.
        /// If not it does nothing, just closes the messagebox - for now. It should reload all the transcoders. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to close the Transcoder Program?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                Application.Exit();
            //else most probably clear the form but to be added :)
        }
        /// <summary>
        /// When the form loads:
        /// Autosize mode is on
        /// The timer is initialised
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Resizing
            // no smaller than design time size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            //Autosize is on
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //Timer
            //initialise the time
            mySlowTimer = new Timer();
            //setup the timer interval
            mySlowTimer.Interval = 60000; //it has 1 minute interval 
            //start the timer
            mySlowTimer.Start();
            mySlowTimer.Tick += MySlowTimer_Tick;
        }

        /// <summary>
        /// it checks if the day changed, every minute, according to timer interval.
        /// If the day changed then the label changes too.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MySlowTimer_Tick(object sender, EventArgs e)
        {
            // when this page loads, the bottom date label needs to be populated.
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
