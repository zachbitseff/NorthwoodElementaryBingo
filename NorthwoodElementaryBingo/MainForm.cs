﻿using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void display1_Click(object sender, EventArgs e)
        {

            // handles manual calling update
            if ( display1.BackColor.Equals( Color.White ) )
            {
                calledNumberUpdate( Convert.ToByte(display1.Text) );  
            }
           
        }

        private void calledNumberUpdate(byte bingoNumID)
        {
            var button = Convert.ToString("display" + bingoNumID);
            Color c = Color.White;

            // increments each called number by one
            // updates backcolor of associated button
            // red is last called
            // yellow is 2nd to last called
            // green for any other called number
            for (byte i = 1; i < 76; i++)
            {
                Number num = db.Numbers.Find(i);
                if (num.IsCalled)
                {
                    num.CallSequence += 1;
                }
                if (num.CallSequence == 1)
                {
                    c = Color.Red;
                    trackingTxt1.Text = num.SortColumn + num.NumberID;
                }
                else if (num.CallSequence == 2)
                {
                    c = Color.Yellow;
                    trackingTxt2.Text = num.SortColumn + num.NumberID;
                }
                else if (num.CallSequence >= 3)
                {
                    c = Color.Green;
                    if (num.CallSequence == 3)
                    {
                        trackingTxt3.Text = num.SortColumn + num.NumberID;
                    }
                    
                    if (num.CallSequence == 4)
                    {
                        trackingTxt4.Text = num.SortColumn + num.NumberID;
                    }
                    if (num.CallSequence == 5)
                    {
                        trackingTxt5.Text = num.SortColumn + num.NumberID;
                    }
                }
                else
                {
                    
                    c = Color.White;
                }

                button = Convert.ToString("display" + i);
                this.Controls.Find(button, true)[0].BackColor = c;
            }

            }

        private void newGame()
        {
            // update isCalled to false for each;
            // update sequence to 0 for each;
            // update BackColor to White for each;
            // updates each trackingTxt box to empty. 
            for (byte i = 1; i < 76; i++)
            {
                Number num = db.Numbers.Find(i);
                num.IsCalled = false;
                num.CallSequence = 0;
                var button = Convert.ToString("display" + i);
                this.Controls.Find(button, true)[0].BackColor = Color.White;
                trackingTxt1.Text = "";
                trackingTxt2.Text = "";
                trackingTxt3.Text = "";
                trackingTxt4.Text = "";
                trackingTxt5.Text = "";

            }
        }

        private void display2_Click(object sender, EventArgs e)
        {
            if (display2.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display2.Text));
            }
        }

        private void display3_Click(object sender, EventArgs e)
        {
            if (display3.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display3.Text));
            }
        }

        private void display4_Click(object sender, EventArgs e)
        {
            if (display4.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display4.Text));
            }
        }

        private void display5_Click(object sender, EventArgs e)
        {
            if (display5.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display5.Text));
            }
        }

        private void display6_Click(object sender, EventArgs e)
        {
            if (display6.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display6.Text));
            }
        }

        private void display7_Click(object sender, EventArgs e)
        {
            if (display7.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display7.Text));
            }
        }

        private void display8_Click(object sender, EventArgs e)
        {
            if (display8.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display8.Text));
            }
        }

        private void display9_Click(object sender, EventArgs e)
        {
            if (display9.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display9.Text));
            }
        }

        private void display10_Click(object sender, EventArgs e)
        {
            if (display10.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display10.Text));
            }
        }

        private void display11_Click(object sender, EventArgs e)
        {
            if (display11.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display11.Text));
            }
        }

        private void display12_Click(object sender, EventArgs e)
        {
            if (display12.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display12.Text));
            }
        }

        private void display13_Click(object sender, EventArgs e)
        {
            if (display13.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display13.Text));
            }
        }

        private void display14_Click(object sender, EventArgs e)
        {
            if (display14.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display14.Text));
            }
        }

        private void display15_Click(object sender, EventArgs e)
        {
            if (display15.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display15.Text));
            }
        }

        private void display16_Click(object sender, EventArgs e)
        {
            if (display16.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display16.Text));
            }
        }

        private void display17_Click(object sender, EventArgs e)
        {
            if (display17.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display17.Text));
            }
        }

        private void display18_Click(object sender, EventArgs e)
        {
            if (display18.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display18.Text));
            }
        }

        private void display19_Click(object sender, EventArgs e)
        {
            if (display19.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display19.Text));
            }
        }

        private void display20_Click(object sender, EventArgs e)
        {
            if (display20.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display20.Text));
            }
        }

        private void display21_Click(object sender, EventArgs e)
        {
            if (display21.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display21.Text));
            }
        }

        private void display22_Click(object sender, EventArgs e)
        {
            if (display22.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display22.Text));
            }
        }

        private void display23_Click(object sender, EventArgs e)
        {
            if (display23.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display23.Text));
            }
        }

        private void display24_Click(object sender, EventArgs e)
        {
            if (display24.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display24.Text));
            }
        }

        private void display25_Click(object sender, EventArgs e)
        {
            if (display25.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display25.Text));
            }
        }

        private void display26_Click(object sender, EventArgs e)
        {
            if (display26.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display26.Text));
            }
        }

        private void display27_Click(object sender, EventArgs e)
        {
            if (display27.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display27.Text));
            }
        }

        private void display28_Click(object sender, EventArgs e)
        {
            if (display28.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display28.Text));
            }
        }

        private void display29_Click(object sender, EventArgs e)
        {
            if (display29.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display29.Text));
            }
        }

        private void display30_Click(object sender, EventArgs e)
        {
            if (display30.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display30.Text));
            }
        }

        private void display31_Click(object sender, EventArgs e)
        {
            if (display31.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display31.Text));
            }
        }

        private void display32_Click(object sender, EventArgs e)
        {
            if (display32.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display32.Text));
            }
        }

        private void display33_Click(object sender, EventArgs e)
        {
            if (display33.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display33.Text));
            }
        }

        private void display34_Click(object sender, EventArgs e)
        {
            if (display34.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display34.Text));
            }
        }

        private void display35_Click(object sender, EventArgs e)
        {
            if (display35.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display35.Text));
            }
        }

        private void display36_Click(object sender, EventArgs e)
        {
            if (display36.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display36.Text));
            }
        }

        private void display37_Click(object sender, EventArgs e)
        {
            if (display37.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display37.Text));
            }
        }

        private void display38_Click(object sender, EventArgs e)
        {
            if (display38.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display38.Text));
            }
        }

        private void display39_Click(object sender, EventArgs e)
        {
            if (display39.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display39.Text));
            }
        }

        private void display40_Click(object sender, EventArgs e)
        {
            if (display40.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display40.Text));
            }
        }

        private void display41_Click(object sender, EventArgs e)
        {
            if (display41.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display41.Text));
            }
        }

        private void display42_Click(object sender, EventArgs e)
        {
            if (display42.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display42.Text));
            }
        }

        private void display43_Click(object sender, EventArgs e)
        {
            if (display43.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display43.Text));
            }
        }

        private void display44_Click(object sender, EventArgs e)
        {
            if (display44.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display44.Text));
            }
        }

        private void display45_Click(object sender, EventArgs e)
        {
            if (display45.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display45.Text));
            }
        }

        private void display46_Click(object sender, EventArgs e)
        {
            if (display46.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display46.Text));
            }
        }

        private void display47_Click(object sender, EventArgs e)
        {
            if (display47.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display47.Text));
            }
        }

        private void display48_Click(object sender, EventArgs e)
        {
            if (display48.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display48.Text));
            }
        }

        private void display49_Click(object sender, EventArgs e)
        {
            if (display49.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display49.Text));
            }
        }

        private void display50_Click(object sender, EventArgs e)
        {
            if (display50.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display50.Text));
            }
        }

        private void display51_Click(object sender, EventArgs e)
        {
            if (display51.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display51.Text));
            }
        }

        private void display52_Click(object sender, EventArgs e)
        {
            if (display52.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display52.Text));
            }
        }

        private void display53_Click(object sender, EventArgs e)
        {
            if (display53.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display53.Text));
            }
        }

        private void display54_Click(object sender, EventArgs e)
        {
            if (display54.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display54.Text));
            }
        }

        private void display55_Click(object sender, EventArgs e)
        {
            if (display55.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display55.Text));
            }
        }

        private void display56_Click(object sender, EventArgs e)
        {
            if (display56.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display56.Text));
            }
        }

        private void display57_Click(object sender, EventArgs e)
        {
            if (display57.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display57.Text));
            }
        }

        private void display58_Click(object sender, EventArgs e)
        {
            if (display58.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display58.Text));
            }
        }

        private void display59_Click(object sender, EventArgs e)
        {
            if (display59.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display59.Text));
            }
        }

        private void display60_Click(object sender, EventArgs e)
        {
            if (display60.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display60.Text));
            }
        }

        private void display61_Click(object sender, EventArgs e)
        {
            if (display61.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display61.Text));
            }
        }

        private void display62_Click(object sender, EventArgs e)
        {
            if (display62.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display62.Text));
            }
        }

        private void display63_Click(object sender, EventArgs e)
        {
            if (display63.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display63.Text));
            }
        }

        private void display64_Click(object sender, EventArgs e)
        {
            if (display64.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display64.Text));
            }
        }

        private void display65_Click(object sender, EventArgs e)
        {
            if (display65.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display65.Text));
            }
        }

        private void display66_Click(object sender, EventArgs e)
        {
            if (display66.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display66.Text));
            }
        }

        private void display67_Click(object sender, EventArgs e)
        {
            if (display67.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display67.Text));
            }
        }

        private void display68_Click(object sender, EventArgs e)
        {
            if (display68.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display68.Text));
            }
        }

        private void display69_Click(object sender, EventArgs e)
        {
            if (display69.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display69.Text));
            }
        }

        private void display70_Click(object sender, EventArgs e)
        {
            if (display70.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display70.Text));
            }
        }

        private void display71_Click(object sender, EventArgs e)
        {
            if (display71.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display71.Text));
            }
        }

        private void display72_Click(object sender, EventArgs e)
        {
            if (display72.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display72.Text));
            }
        }

        private void display73_Click(object sender, EventArgs e)
        {
            if (display73.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display73.Text));
            }
        }

        private void display74_Click(object sender, EventArgs e)
        {
            if (display74.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display74.Text));
            }
        }

        private void display75_Click(object sender, EventArgs e)
        {
            if (display75.BackColor.Equals(Color.White))
            {
                calledNumberUpdate(Convert.ToByte(display75.Text));
            }
        }

        private void newGamebtn_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            callNumber();

        }

        private BingoDB db = new BingoDB();

        private void callNumber()
        {
            int id = 1;
            Random rand = new Random();
            Number num = db.Numbers.Find(id);
            Boolean notCalled = false;
            while ( !notCalled )
            {
                id = rand.Next(1, 76);
                num = db.Numbers.Find(id);
                if ( num.IsCalled != true && num.IsDisabled != true)
                {
                    num.IsCalled = true;
                    //callSequence incremented in CalledNumberUpdate;
                    notCalled = true;
                }
            }
            if (popupEnabled)
            {
                AutoCallDisplay frm = new AutoCallDisplay();
                frm.justCalled = Convert.ToString(num.SortColumn + num.NumberID);
                frm.popupDisplayDelay = Convert.ToByte(popupDisplayTimeTxt.Text);
                frm.Show();
                
            }
            calledNumberUpdate(Convert.ToByte(id));
        }

        private Boolean popupEnabled = true;

        private void popupCheck_CheckedChanged(object sender, EventArgs e)
        {
            if ( popupCheck.Checked )
            {
                popupEnabled = true;
            }
            if ( !popupCheck.Checked )
            {
                popupEnabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void gameModeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            newGame();
            for (byte i = 1; i < 76; i++)
            {
                Number num = db.Numbers.Find(i);
                num.IsDisabled = false;

            }
            //Traditional
            if ( gameModeList.GetSelected(0) )
            {
                //gameModePicBox.ImageLocation = ;
            }
            // Diagonal
            else if (gameModeList.GetSelected(1))
            {
                for (byte i = 1; i < 76; i++)
                {
                    Number num = db.Numbers.Find(i);
                    if (num.SortColumn == "N")
                    {
                        num.IsDisabled = true;
                    }
                }
                //gameModePicBox.ImageLocation = ;
            }

            // Four Corners
            else if (gameModeList.GetSelected(2))
            {
                for (byte i = 1; i < 76; i++)
                {
                    Number num = db.Numbers.Find(i);
                    if (num.SortColumn == "I" || num.SortColumn == "N" || num.SortColumn == "G")
                    {
                        num.IsDisabled = true;
                    }
                }
                //gameModePicBox.ImageLocation = ;
            }

            // X Pattern
            else if (gameModeList.GetSelected(3))
            {
                for (byte i = 1; i < 76; i++)
                {
                    Number num = db.Numbers.Find(i);
                    if (num.SortColumn == "N")
                    {
                        num.IsDisabled = true;
                    }
                }
                //gameModePicBox.ImageLocation = ;
            }
        }
    }
}
