using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Modbus_Poll_CS
{
    public partial class EDIT : Form
    {
        String SegmentVal;
        Double JogStep = 1;
        string RegAddr;
       


        public EDIT()
        {
            
            InitializeComponent();
            this.txtTitle.Text = "S i z e   " + buttonModel.TextData +"    m l  i s  E d i t i n g";
            /*switch (buttonModel.TextMode)
            {
                case "50":
                    RegAddr = "0";
                    break;
                case "100":
                    RegAddr = "1";
                    break;
                case "120":
                    RegAddr = "2";
                    break;
                case "150":
                    RegAddr = "3";
                    break;
                case "180":
                    RegAddr = "4";
                    break;
                case "200":
                    RegAddr = "5";
                    break;
                case "250":
                    RegAddr = "6";
                    break;
                case "350":
                    RegAddr = "7";
                    break;
                case "375":
                    RegAddr = "8";
                    break;
                case "400":
                    RegAddr = "9";
                    break;
            } */
            RegAddr = buttonModel.TextAddr;
            string[] SegVal  = buttonModel.TextVal.Split('.');
            SendDATA.w_Data = SegVal[0];
            SendDATA.w_Flag = true;
            SendDATA.w_Register = RegAddr;
            timer1.Start();
           // show(SegmentVal);
            txtVal.Text = "";


            #region Hold Button UP
            Timer timer_JogUp = new Timer();
            timer_JogUp.Interval = 250;



            btnUp.MouseDown += delegate(object sender, MouseEventArgs mea)
            {
                timer_JogUp.Start();
            };

            btnUp.MouseUp += delegate(object sender, MouseEventArgs mea)
            {
                timer_JogUp.Stop();
            };

            timer_JogUp.Tick += delegate(object sender, EventArgs e)
            {
                // timer_JogUp.Stop();
                runLoop_JogUp();
                //  timer_JogUp.Start();
            };

            #endregion

            #region Hold Button Down
            Timer timer_JogDown = new Timer();
            timer_JogDown.Interval = 250;



            btnDown.MouseDown += delegate(object sender, MouseEventArgs mea)
            {
                timer_JogDown.Start();
            };

            btnDown.MouseUp += delegate(object sender, MouseEventArgs mea)
            {
                timer_JogDown.Stop();
            };

            timer_JogDown.Tick += delegate(object sender, EventArgs e)
            {
                //  timer_JogDown.Stop();
                runLoop_JogDown();
                //  timer_JogDown.Start();
            };
            #endregion
        }

        private void EDIT_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                   (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void EDIT_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            Dispose();
           
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            runLoop_JogUp();
            WriteConfiguration("M" + buttonModel.TextData, "M" + buttonModel.TextData + "=" + SegmentVal);
        }

        void runLoop_JogUp()
        {
            var currentVal = Convert.ToDouble(SegmentVal);
            if (currentVal <= 9999.99)
            {
                currentVal = currentVal + JogStep;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                //writeData= segMent[0].ToString();
                //writeFlag=true;
                SendDATA.w_Data = segMent[0].ToString();
                SendDATA.w_Flag = true;
                SendDATA.w_Register = RegAddr;
            }
            else
            {
                currentVal = 9999.99;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                //writeData= segMent[0].ToString();
                //writeFlag=true;
                SendDATA.w_Data = segMent[0].ToString();
                SendDATA.w_Flag = true;
                SendDATA.w_Register = RegAddr;
            }
        }

        void runLoop_JogDown()
        {
            var currentVal = Convert.ToDouble(SegmentVal);
            if (currentVal > 0)
            {
                currentVal = currentVal - JogStep;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                //writeData= segMent[0].ToString();
                //writeFlag=true;
                SendDATA.w_Data = segMent[0].ToString();
                SendDATA.w_Flag = true;
                SendDATA.w_Register = RegAddr;
            }
            else
            {
                currentVal = 0;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                //writeData= segMent[0].ToString();
                //writeFlag=true;
                SendDATA.w_Data = segMent[0].ToString();
                SendDATA.w_Flag = true;
                SendDATA.w_Register = RegAddr;
            }
        }

        private void show(string inVal)
        {
            string[] valSplit = inVal.Split('.');
            var val_decimal = "";
            var val_int = valSplit[0];
            if (valSplit.Length == 1)
            {
                val_decimal = "00";
            }
            else
            {
                val_decimal = valSplit[1];
            }

            var digiPad = 4 - val_int.Length;
            var newVal = "";
            switch (digiPad)
            {
                case 0:
                    newVal = val_int;
                    break;
                case 1:
                    newVal = "0" + val_int;
                    break;
                case 2:
                    newVal = "00" + val_int;
                    break;
                case 3:
                    newVal = "000" + val_int;
                    break;

            }
            char[] characters = newVal.ToCharArray();


            if (val_int.Length == 4)
            {
                lB7SegmentDisplay1.Enabled = true;
                lB7SegmentDisplay1.Value = (int)Char.GetNumericValue(characters[0]);
            }
            else
            {
                lB7SegmentDisplay1.Value = 10;
            }

            if (val_int.Length >= 3)
            {
                lB7SegmentDisplay2.Enabled = true;
                lB7SegmentDisplay2.Value = (int)Char.GetNumericValue(characters[1]);
            }
            else
            {
                lB7SegmentDisplay2.Value = 10;
            }

            if (val_int.Length >= 2)
            {
                lB7SegmentDisplay3.Enabled = true;
                lB7SegmentDisplay3.Value = (int)Char.GetNumericValue(characters[2]);
            }
            else
            {
                lB7SegmentDisplay3.Value = 10;
            }

            if (val_int.Length >= 1)
            {

                lB7SegmentDisplay4.Enabled = true;
                lB7SegmentDisplay4.Value = (int)Char.GetNumericValue(characters[3]);
            }
            else
            {
                lB7SegmentDisplay4.Value = 10;
            }

            char[] dec_characters = val_decimal.ToCharArray();
            lB7SegmentDisplay5.Value = (int)Char.GetNumericValue(dec_characters[0]);
            lB7SegmentDisplay6.Value = (int)Char.GetNumericValue(dec_characters[1]);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            runLoop_JogDown();
            WriteConfiguration("M" + buttonModel.TextData, "M" + buttonModel.TextData + "=" + SegmentVal);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
       //   MainEDIT obj = new MainEDIT();
//obj.ShowDialog();
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (txtVal.TextLength > 0) {
                string[] val = txtVal.Text.Split('.');
                if (val.Length == 2)
                {
                    if (val[1].Length == 1)
                    {
                        txtVal.Text = txtVal.Text + "0";
                    }
                }
                else
                {
                    txtVal.Text = txtVal.Text + ".00";
                }

                if (val[0].Length <= 4)
                {
                    //show(txtVal.Text);
                    SendDATA.w_Data = Convert.ToString(Convert.ToInt16(val[0])); ;
                    SendDATA.w_Flag = true;
                    SendDATA.w_Register = RegAddr;

                    WriteConfiguration("M" + buttonModel.TextData, "M" + buttonModel.TextData + "=" + txtVal.Text);
                    txtVal.Text = "";
                }
                else
                {
                    txtVal.Text = "";
                }

            
            }

            
        }

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back ))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }




        private void WriteConfiguration(string M, string Val)
        {
            var editLine = 0;

            try
            {
                string appPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var lines = System.IO.File.ReadAllLines(appPath + @"\config.txt");           


                foreach (var line in lines)
                {
                    string[] lineConfig = line.Split('=');
                   
                    if (lineConfig[0].ToString().ToUpper() != M)
                    {
                        editLine = editLine + 1;
                    }
                    else {
                        break;
                    }                 
                }

                string[] arrLine = System.IO.File.ReadAllLines(appPath + @"\config.txt"); 
                 arrLine[editLine] = Val;               
                System.IO.File.WriteAllLines(appPath + @"\config.txt", arrLine);

                //   System.Collections.Generic.IEnumerable<String> lines = File.ReadLines("c:\\config.txt");
              //  Console.WriteLine("Edit line NO == ",editLine);
            }
                
            catch (Exception ex)
            {
                //MZM_Log(System.Reflection.MethodBase.GetCurrentMethod().Name, "SYS", ex.Message);
                MessageBox.Show(ex.Message);
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RegAddr = buttonModel.TextAddr;
            switch (buttonModel.TextMode) { 
               case "50":
                   show(buttonModel.M50);
                   SegmentVal = buttonModel.M50;
                //   RegAddr = "0";
                   break;
               case "100":
                   show(buttonModel.M100);
                   SegmentVal = buttonModel.M100;
             //      RegAddr = "1";
                   break;
               case "120":
                   show(buttonModel.M120);
                   SegmentVal = buttonModel.M120;
             //      RegAddr = "2";
                   break;
               case "150":
                   show(buttonModel.M150);
                   SegmentVal = buttonModel.M150;
              //     RegAddr = "3";
                   break;
               case "180":
                   show(buttonModel.M180);
                   SegmentVal = buttonModel.M180;
               //    RegAddr = "4";
                   break;
               case "200":
                   show(buttonModel.M200);
                   SegmentVal = buttonModel.M200;
               //    RegAddr = "5";
                   break;
               case "250":
                   show(buttonModel.M250);
                   SegmentVal = buttonModel.M250;
               //    RegAddr = "6";
                   break;
               case "350":
                   show(buttonModel.M350);
                  SegmentVal = buttonModel.M350;
             //      RegAddr = "7";
                   break;
               case "375":
                   show(buttonModel.M375);
                   SegmentVal = buttonModel.M375;
                 //  RegAddr = "8";
                   break;
               case "400":
                   show(buttonModel.M400);
                   SegmentVal = buttonModel.M400;
                 //  RegAddr = "9";
                   break;
           }         
       }

        private void EDIT_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
  }   
}
   
    public static class buttonModel
    {
        public static string TextData { get; set; }
        public static string TextMode { get; set; }
        public static string TextVal { get; set; }
        public static string TextAddr { get; set; }
        public static string M50 { get; set; }
        public static string M100 { get; set; }
        public static string M120 { get; set; }
        public static string M150 { get; set; }
        public static string M180 { get; set; }
        public static string M200 { get; set; }
        public static string M250 { get; set; }
        public static string M350 { get; set; }
        public static string M375 { get; set; }
        public static string M400 { get; set; }
   
    
}
