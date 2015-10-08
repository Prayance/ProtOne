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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        //setup a timer variable
        Timer t;
        /// <summary>
        /// This is the initial method that specifies the show properties of the splash screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartScreen_Shown(object sender, EventArgs e)
        {
            //initialise the time
            t = new Timer();
            //setup the timer interval
            t.Interval = 5000;
            //start the timer
            t.Start();
            t.Tick += T_Tick;
            //start the progressbar animation with speed 50 (the higer the value the slower it goes)
            progressBar1.MarqueeAnimationSpeed = 50;
        }

        /// <summary>
        /// This method specifies what is happening after the 5 seconds have passed and the splashscreen 
        /// needs to dissappear. It also navigates to the Main page of the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Tick(object sender, EventArgs e)
        {
            //stop the timer
            t.Stop();
            //initialise a form1 object
            LoginForm f = new LoginForm();
            // show form1 object
            f.Show();
            //hide the startscreen
            this.Hide();
        }
    }
}
