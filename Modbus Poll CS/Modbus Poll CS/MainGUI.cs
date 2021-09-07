using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;

namespace Modbus_Poll_CS
{
    public partial class MainGUI : Form
    {

        string SLAVE_ID, REG_ADDR, REG_QTY, COM_PORT, BUAD_RATE;
        string ADDR_M50, ADDR_M100, ADDR_M120, ADDR_M150, ADDR_M180, ADDR_M200, ADDR_M250, ADDR_M350, ADDR_M375,ADDR_M400;
        public MainGUI()
        {           
            InitializeComponent();
            ReadConfiguration();
            btn("OFF");
            btnEdit.Enabled = false;
            SendDATA.w_Flag = false;

            StartPoll(REG_QTY, REG_ADDR, SLAVE_ID);
        }


        private void ReadConfiguration()
        {

            try
            {
                string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                var lines = System.IO.File.ReadAllLines(appPath + @"\config.txt");
                // var lines = System.IO.File.ReadAllLines(@"c:\config.txt");
                foreach (var line in lines)
                {
                    string[] lineConfig = line.Split('=');
                    switch (lineConfig[0].ToString().ToUpper())
                    {
                        case "SLAVE_ID":
                            SLAVE_ID = lineConfig[1];
                            break;
                        case "REG_ADDR":
                            REG_ADDR = lineConfig[1];
                            break;
                        case "REG_QTY":
                            REG_QTY = lineConfig[1];
                            break;
                        case "COM_PORT":
                            COM_PORT = lineConfig[1];
                            break;
                        case "BUAD_RATE":
                            BUAD_RATE = lineConfig[1];
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

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, the parent reappears
            this.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainEDIT obj = new MainEDIT();
            //obj.FormClosed += new FormClosedEventHandler(child_FormClosed);
            obj.ShowDialog();
            obj = null;
            Show();
           // this.Dispose();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }


        #region Button selected
        private void btn50_Click(object sender, EventArgs e)
        {
            
            buttonModel.TextData = "S I Z E    5 0  ml     i s     S E L E C T E D";
            buttonModel.TextMode = "50";
            buttonModel.TextAddr = ADDR_M50;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            this.Visible = true;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    1 0 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "100";
            buttonModel.TextAddr = ADDR_M100;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    1 2 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "120";
            buttonModel.TextAddr = ADDR_M120;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btm150_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    1 5 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "150";
            buttonModel.TextAddr = ADDR_M150;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn180_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    1 8 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "180";
            buttonModel.TextAddr = ADDR_M180;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    2 0 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "200";
            buttonModel.TextAddr = ADDR_M200;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn250_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    2 5 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "250";
            buttonModel.TextAddr = ADDR_M250;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn350_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    3 5 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "350";
            buttonModel.TextAddr = ADDR_M350;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn375_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    3 7 5  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "375";
            buttonModel.TextAddr = ADDR_M375;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void btn400_Click(object sender, EventArgs e)
        {
            buttonModel.TextData = "S I Z E    4 0 0  ml     i s      S E L E C T E D";
            buttonModel.TextMode = "400";
            buttonModel.TextAddr = ADDR_M400;
            this.Visible = false;
            Run obj = new Run();
            obj.ShowDialog();
            obj = null;
            Show();
        }

        #endregion

        private void MainGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn(string state) {
            switch (state.ToUpper()) { 
                case "ON" :
                    btn50.Enabled = true;
                    btn100.Enabled = true;
                    btn120.Enabled = true;
                    btm150.Enabled = true;
                    btn180.Enabled = true;
                    btn200.Enabled = true;
                    btn250.Enabled = true;
                    btn350.Enabled = true;
                    btn375.Enabled = true;
                    btn400.Enabled = true;
                    btnLimit.Enabled = true;
                    break;
                case "OFF":
                    btn50.Enabled = false;
                    btn100.Enabled = false;
                    btn120.Enabled = false;
                    btm150.Enabled = false;
                    btn180.Enabled = false;
                    btn200.Enabled = false;
                    btn250.Enabled = false;
                    btn350.Enabled = false;
                    btn375.Enabled = false;
                    btn400.Enabled = false;
                    btnLimit.Enabled = false;
                    break;            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 obj = new Form1();
            //obj.FormClosed += new FormClosedEventHandler(child_FormClosed);
            obj.ShowDialog();
            obj = null;
            Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonModel.TextCount = DateTime.Now.ToString(); ;
        }

        #region modBus connection

        public delegate void GUIDelegate(string paramString);
        modbus mb = new modbus();
        SerialPort sp = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();
        string RegisterQty, RegisterAddr, slaveID,dataType;
       // string writeData;
       // bool writeFlag;


        #region Poll Function
        private void PollFunction()
        {
            //Update GUI:
            // DoGUIClear();
            // pollCount++;
            // DoGUIStatus("Poll count: " + pollCount.ToString());

            //Create array to accept read values:
            short[] values = new short[Convert.ToInt32(RegisterQty)];   //Data out array
         //   short[] valuesLimit = new short[Convert.ToInt32("20")];   //Data out array



            ushort pollStart;
            ushort pollLength;


            #region Read First Set of Register

            pollStart = Convert.ToUInt16((Int32.Parse(RegisterAddr) - 1).ToString());  //Start Address
            //pollStart = 0;
            pollLength = Convert.ToUInt16(RegisterQty);

            //Read registers and display data in desired format:
            //Console.WriteLine(pollStart);
            try
            {
                while (!mb.SendFc3(Convert.ToByte(slaveID), pollStart, pollLength, ref values)) ;
              //  while (!mb.SendFc3(Convert.ToByte(slaveID), 1293, 20, ref valuesLimit)) ;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error in modbus read: " + err.Message);
            }

            string itemString;

            #region Update Data out
            switch (dataType)
            {
                case "Decimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                       // itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" + Convert.ToString(pollStart + i) + "] = " + values[i].ToString();
                        itemString =  Convert.ToString(pollStart + i) + "=" + values[i].ToString();
                        DoGUIUpdate(itemString);
                       // DoGUIUpdate(values[i].ToString());
                    }
                    break;
                case "Hexadecimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString("X");
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Float":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i];
                        intValue <<= 16;
                        intValue += (int)values[2 * i + 1];
                        //itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
                        //    Convert.ToString(pollStart + 2 * i) + "] = " +
                        //    (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();

                        itemString = Convert.ToString(pollStart + 2 * i) + "=" + values[i].ToString();

                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Reverse":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i + 1];
                        intValue <<= 16;
                        intValue += (int)values[2 * i];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
            }
            #endregion


            #endregion

            #region Read second set of register

            #endregion


            // Write Data to modBus if set new 
            if (SendDATA.w_Flag)
            {
                short[] value = new short[1];
                value[0] = Convert.ToInt16(SendDATA.w_Data);
              //  SendDATA.w_Register = 
                ushort regAddr = Convert.ToUInt16(SendDATA.w_Register);
                
                try
                {
                    while (!mb.SendFc16(Convert.ToByte(slaveID), regAddr, (ushort)1, value)) {
                        mb.SendFc16(Convert.ToByte(slaveID), regAddr, (ushort)1, value);
                        System.Threading.Thread.Sleep(100);
                    }
                    // while (!mb.SendFc3(Convert.ToByte(slaveID), pollStart, pollLength, ref values)) ;
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error in write function: " + err.Message);
                }
                SendDATA.w_Data = "";
                SendDATA.w_Flag = false;
            }

        }
        #endregion

        #region GUI Update
        public void DoGUIUpdate(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoGUIUpdate);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else {
                string[] itemparam = paramString.Split('=');
               // Int32.Parse(itemparam[0])
                 if (ADDR_M50==itemparam[0].ToString()) {
                     buttonModel.M50 = itemparam[1];                        
                 } else if (ADDR_M100==itemparam[0].ToString()) {
                     buttonModel.M100 = itemparam[1];                        
                 } else if (ADDR_M120==itemparam[0].ToString()) {
                     buttonModel.M120 = itemparam[1];                        
                 } else if (ADDR_M150==itemparam[0].ToString()) {
                     buttonModel.M150 = itemparam[1];                        
                 } else if (ADDR_M180==itemparam[0].ToString()) {
                     buttonModel.M180 = itemparam[1];                        
                 } else if (ADDR_M200==itemparam[0].ToString()) {
                     buttonModel.M200 = itemparam[1];                        
                 } else if (ADDR_M250==itemparam[0].ToString()) {
                     buttonModel.M250 = itemparam[1];                        
                 } else if (ADDR_M350==itemparam[0].ToString()) {
                     buttonModel.M350 = itemparam[1];                        
                 } else if (ADDR_M375==itemparam[0].ToString()) {
                     buttonModel.M375 = itemparam[1];                        
                 } else if (ADDR_M400==itemparam[0].ToString()) {
                     buttonModel.M400 = itemparam[1];                        
                 } 
            }

        }
        #endregion GUI Update

        #endregion modeBus Connection

        #region Start/Stop

        private void StartPoll(string Qty, string Addr, string ID)
        {
            try
            {
                //RegisterQty,RegisterAddr,slaveID;
                if (mb.Open(COM_PORT, Convert.ToInt32(BUAD_RATE), 8, Parity.None, StopBits.Two))
                {
                    short[] valuesCheck = new short[Convert.ToInt32(99)];
                    ushort regAddr = Convert.ToUInt16("99");
                    bool z = mb.SendFc3(Convert.ToByte(ID), regAddr, (ushort)1, ref valuesCheck); //Test Write Connection
                    if (z)
                    {                       
                            dataType = "Decimal";   //{ "Decimal", "Hexadecimal", "Float", "Reverse" }
                          //  dataType = "Float";   //{ "Decimal", "Hexadecimal", "Float", "Reverse" }
                            RegisterQty = Qty;
                            RegisterAddr = Addr;
                            slaveID = ID;
                            //Start timer using provided values:
                            timer.AutoReset = true;
                            timer.Interval = 250;
                            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
                            timer.Start();
                            btn("ON");
                            btnEdit.Enabled = true;
                           
                    }
                    else {
                        MessageBox.Show("Can't send command"+ "  regAddr="+ regAddr +"   ID = "+ID + " COM_Port = "+ COM_PORT +"  BUAD ="+BUAD_RATE);
                       // modbusStatus
                        MessageBox.Show(mb.modbusStatus);
                    }
                }
            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
            }

        }

        private void StopPoll()
        {
            //Stop timer and close COM port:
            timer.Stop();
            mb.Close();


        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PollFunction();
           // Console.WriteLine(DateTime.Now);
        }

        #endregion Start/Stop

        private void btnLimit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StopPoll();
            timer.Enabled = false;
            System.Threading.Thread.Sleep(100);
            LIMIT obj = new LIMIT();
            //obj.FormClosed += new FormClosedEventHandler(child_FormClosed);
            obj.ShowDialog();
            obj = null;
            Show();
            mb.Open(COM_PORT, Convert.ToInt32(BUAD_RATE), 8, Parity.None, StopBits.Two);
            timer.Enabled = true;
            //StartPoll(REG_QTY, REG_ADDR, SLAVE_ID);
        }


    }
}
public static class SendDATA { 
     public static bool w_Flag { get; set; }
     public static string w_Data { get; set; }
     public static string w_Register { get; set; }

}