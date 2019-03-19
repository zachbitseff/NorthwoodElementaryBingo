using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwoodElementaryBingo
{
    public partial class AutoCallDisplay : Form
    {

        public string justCalled { get; set; }

        public AutoCallDisplay()
        {
            InitializeComponent();
        }

        // timer code taken from:
        // https://www.codeproject.com/Questions/169892/display-a-form-for-a-period-of-time 
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void AutoCallDisplay_Load(object sender, EventArgs e)
        {
            displayLabel.Text = justCalled;
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
