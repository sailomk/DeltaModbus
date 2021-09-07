using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Modbus_Poll_CS
{
    public partial class MainEDIT : Form
    {

        string M50, M100, M120, M150, M180, M200, M250, M350, M375, M400;
        string ADDR_M50, ADDR_M100, ADDR_M120, ADDR_M150, ADDR_M180, ADDR_M200, ADDR_M250, ADDR_M350, ADDR_M375, ADDR_M400;
        public MainEDIT()
        {
            
            InitializeComponent();
            ReadConfiguration();
        }

        private void MainEDIT_FormClosed(object sender, FormClosedEventArgs e)
        {
           // this.Hide();
                
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, the parent reappears
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            //MainGUI obj = new MainGUI();
           // obj.FormClosed += new FormClosedEventHandler(child_FormClosed);
           // obj.Show(); 
      
        }

        private void MainEDIT_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }

        private void ReadConfiguration()
        {

            try
            {
                string appPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var lines = System.IO.File.ReadAllLines(appPath + @"\config.txt");
                // var lines = System.IO.File.ReadAllLines(@"c:\config.txt");
                foreach (var line in lines)
                {
                    string[] lineConfig = line.Split('=');
                    switch (lineConfig[0].ToString().ToUpper())
                    {
                        case "M50":
                            M50 = lineConfig[1];
                            break;
                        case "M100":
                            M100 = lineConfig[1];
                            break;
                        case "M120":
                            M120 = lineConfig[1];
                            break;
                        case "M150":
                            M150 = lineConfig[1];
                            break;
                        case "M180":
                            M180 = lineConfig[1];
                            break;
                        case "M200":
                            M200 = lineConfig[1];
                            break;
                        case "M250":
                            M250 = lineConfig[1];
                            break;
                        case "M350":
                            M350 = lineConfig[1];
                            break;
                        case "M375":
                            M375 = lineConfig[1];
                            break;
                        case "M400":
                            M400 = lineConfig[1];
                            break;
                        case "ADDR_M50":
                            ADDR_M50 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M100":
                            ADDR_M100 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M120":
                            ADDR_M120 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M150":
                            ADDR_M150 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M180":
                            ADDR_M180 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M200":
                            ADDR_M200 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M250":
                            ADDR_M250 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M350":
                            ADDR_M350 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M375":
                            ADDR_M375 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_M400":
                            ADDR_M400 = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break; 
                       
                    }
                }

                //   System.Collections.Generic.IEnumerable<String> lines = File.ReadLines("c:\\config.txt");

            }
            catch (Exception ex)
            {
                //MZM_Log(System.Reflection.MethodBase.GetCurrentMethod().Name, "SYS", ex.Message);
                MessageBox.Show(ex.Message);
            }



        }

        #region Button Edit
        private void btn50_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "50";
            buttonModel.TextMode = "50";
            buttonModel.TextVal = M50;
            buttonModel.TextAddr = ADDR_M50;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "100";
            buttonModel.TextMode = "100";
            buttonModel.TextVal = M100;
            buttonModel.TextAddr = ADDR_M100;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "120";
            buttonModel.TextMode = "120";
            buttonModel.TextVal = M120;
            buttonModel.TextAddr = ADDR_M120;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btm150_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "150";
            buttonModel.TextMode = "150";
            buttonModel.TextVal = M150;
            buttonModel.TextAddr = ADDR_M150;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn180_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "180";
            buttonModel.TextMode = "180";
            buttonModel.TextVal = M180;
            buttonModel.TextAddr = ADDR_M180;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "200";
            buttonModel.TextMode = "200";
            buttonModel.TextVal = M200;
            buttonModel.TextAddr = ADDR_M200;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn250_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "250";
            buttonModel.TextMode = "250";
            buttonModel.TextVal = M250;
            buttonModel.TextAddr = ADDR_M250;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn350_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "350";
            buttonModel.TextMode = "350";
            buttonModel.TextVal = M350;
            buttonModel.TextAddr = ADDR_M350;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn375_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "375";
            buttonModel.TextMode = "375";
            buttonModel.TextVal = M375;
            buttonModel.TextAddr = ADDR_M375;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }

        private void btn400_Click(object sender, EventArgs e)
        {
            //this.Close();
            buttonModel.TextData = "400";
            buttonModel.TextMode = "400";
            buttonModel.TextVal = M400;
            buttonModel.TextAddr = ADDR_M400;
            EDIT obj = new EDIT();
            this.Hide();
            obj.ShowDialog();
            obj = null;
            ReadConfiguration();
            Show();
        }
        #endregion


    }
}
