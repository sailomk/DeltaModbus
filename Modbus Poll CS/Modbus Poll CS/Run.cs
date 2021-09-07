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
    public partial class Run : Form
    {
        String SegmentVal;
        Double JogStep = 1;

       // modbus mb = new modbus();
       // SerialPort sp = new SerialPort();
    // System.Timers.Timer timer = new System.Timers.Timer();
       // System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
    //    string dataType;
     //  bool isPolling = false;
     //   int pollCount;
    //    string RegisterQty,RegisterAddr,slaveID,RegAddr;
        string RegAddr;
   //     string writeData;
   //     bool writeFlag;


        public delegate void GUIDelegate(string paramString);



        public Run()
        {
            InitializeComponent();
            this.txtTitle.Text = buttonModel.TextData;
            SegmentVal = "0";
            show(SegmentVal);
           
           // StartPoll("1","4001","1");
            
        

            #region Hold Button UP
           System.Windows.Forms.Timer timer_JogUp = new System.Windows.Forms.Timer();
            timer_JogUp.Interval = 200;



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
            System.Windows.Forms.Timer timer_JogDown = new System.Windows.Forms.Timer();
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

        private void Run_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
          

        }

        private void Run_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            runLoop_JogUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            runLoop_JogDown();
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
                //writeData = segMent[0].ToString();
                //writeFlag = true;
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
                SendDATA.w_Data = segMent[0].ToString();
                SendDATA.w_Flag = true;
                SendDATA.w_Register = RegAddr;
            }
            else
            {
                currentVal = 0;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendDATA.w_Data = segMent[0].ToString();
                SendDATA.w_Flag = true;
                SendDATA.w_Register = RegAddr;
            }
        }

        private void show(string inVal)
        {
            //Console.WriteLine("show data = ", inVal);
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

      /// <summary>
      /// ///////////////////////////////////////////////////////////////////////////////////////////////////////
      /// </summary>


        //private void StopPoll()
        //{
        //    //Stop timer and close COM port:

        //    timer.Stop();
        //    mb.Close();


        //}

        //void timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    PollFunction();
        //}


       //private void StartPoll(string Qty,string Addr,string ID){
       //    //RegisterQty,RegisterAddr,slaveID;
       //    if (mb.Open("COM2", Convert.ToInt32("19200"), 8, Parity.None, StopBits.One))
       //    {
       //        {
       //            //Disable double starts:

       //            dataType = "Decimal";   //{ "Decimal", "Hexadecimal", "Float", "Reverse" }

       //            //Set polling flag:
                  
       //            RegisterQty = Qty;
       //            RegisterAddr = Addr;
       //            slaveID = ID;
       //            //Start timer using provided values:
       //            timer.AutoReset = true;
       //            timer.Interval = 250;
       //            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
       //            timer.Start();        
       //        }
       //    }          

       // }


       //#region Poll Function
       //private void PollFunction()
       //{
       //    //Update GUI:
       //   // DoGUIClear();
       //   // pollCount++;
       //   // DoGUIStatus("Poll count: " + pollCount.ToString());

       //    //Create array to accept read values:
       //    Console.WriteLine("Run in PoolFuction");
       //    short[] values = new short[Convert.ToInt32(RegisterQty)];   //RegisterQty
       //    ushort pollStart;
       //    ushort pollLength;

           
       //    pollStart = Convert.ToUInt16(RegisterAddr);  //Start Address
       //    pollStart = 0;
       //    pollLength = Convert.ToUInt16(RegisterQty);
          
       //    //Read registers and display data in desired format:
       //    try
       //    {
       //        while (!mb.SendFc3(Convert.ToByte(slaveID), pollStart, pollLength, ref values)) ;
       //    }
       //    catch (Exception err)
       //    {
       //        Console.WriteLine("Error in modbus read: " + err.Message);
       //    }

       //    string itemString;

       //    switch (dataType)
       //    {
       //        case "Decimal":
       //            for (int i = 0; i < pollLength; i++)
       //            {
       //                itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
       //                    Convert.ToString(pollStart ) + "] = " + values[i].ToString();
       //                //DoGUIUpdate(itemString);
       //                DoGUIUpdate(values[i].ToString());
       //            }
       //            break;
       //        case "Hexadecimal":
       //            for (int i = 0; i < pollLength; i++)
       //            {
       //                itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
       //                    Convert.ToString(pollStart + i) + "] = " + values[i].ToString("X");
       //                DoGUIUpdate(itemString);
       //            }
       //            break;
       //        case "Float":
       //            for (int i = 0; i < (pollLength / 2); i++)
       //            {
       //                int intValue = (int)values[2 * i];
       //                intValue <<= 16;
       //                intValue += (int)values[2 * i + 1];
       //                itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
       //                    Convert.ToString(pollStart + 2 * i) + "] = " +
       //                    (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
       //                DoGUIUpdate(itemString);
       //            }
       //            break;
       //        case "Reverse":
       //            for (int i = 0; i < (pollLength / 2); i++)
       //            {
       //                int intValue = (int)values[2 * i + 1];
       //                intValue <<= 16;
       //                intValue += (int)values[2 * i];
       //                itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
       //                    Convert.ToString(pollStart + 2 * i) + "] = " +
       //                    (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
       //                DoGUIUpdate(itemString);
       //            }
       //            break;
       //    }
       //    // Write Data to modBus if set new 
       //  if (writeFlag) {
       //    short[] value = new short[1];
       //    value[0] = Convert.ToInt16(writeData);

       //    try
       //    {
       //        while (!mb.SendFc16(Convert.ToByte(slaveID), pollStart, (ushort)1, value)) ;
       //        // while (!mb.SendFc3(Convert.ToByte(slaveID), pollStart, pollLength, ref values)) ;
       //    }
       //    catch (Exception err)
       //    {
       //        Console.WriteLine("Error in write function: " + err.Message);
       //    }
       //    writeData = "";
       //    writeFlag = false;
       //  }

       //}
       //#endregion

       //public void DoGUIUpdate(string paramString)
       //{
       //    if (this.InvokeRequired)
       //    {
       //        GUIDelegate delegateMethod = new GUIDelegate(this.DoGUIUpdate);
       //        this.Invoke(delegateMethod, new object[] { paramString });
       //    }
       //    else
       //        //    this.lstRegisterValues.Items.Add(paramString);
              
       //    show(paramString.Substring(0, Math.Min(4, paramString.Length)));
       //    SegmentVal = paramString.Substring(0, Math.Min(4, paramString.Length));
        
       //}


       //#region Write Function
       //private void WriteFunction(string Qty, string Addr, string ID,string Data)
       //{
       //    Console.WriteLine("Jump in Write Function");
       //    StopPoll();

       //    mb.Open("COM2", Convert.ToInt32("9600"), 8, Parity.None, StopBits.One);
       //        byte address = Convert.ToByte(ID);
       //        ushort start = Convert.ToUInt16(Addr);
       //        short[] value = new short[1];
       //        value[0] = Convert.ToInt16(Data);

       //        try
       //        {
       //            while (!mb.SendFc16(address, start, (ushort)1, value)) ;
       //        }
       //        catch (Exception err)
       //        {
       //            Console.WriteLine("Error in write function: " + err.Message);
       //        }
       //        mb.Close();
       //       // DoGUIStatus(mb.modbusStatus);
       //    }                  
    
       //#endregion

       private void timer1_Tick(object sender, EventArgs e)
       {
           //Console.WriteLine("Jump in timer1");
           RegAddr = buttonModel.TextAddr;
          // Console.WriteLine(RegAddr);
           switch (buttonModel.TextMode) { 
               case "50":
                   show(buttonModel.M50);
                   SegmentVal = buttonModel.M50;
                   //RegAddr = buttonModel.TextAddr;
                   break;
               case "100":
                   show(buttonModel.M100);
                   SegmentVal = buttonModel.M100;
                  // RegAddr = "1";
                   break;
               case "120":
                   show(buttonModel.M120);
                   SegmentVal = buttonModel.M120;
                 //  RegAddr = "2";
                   break;
               case "150":
                   show(buttonModel.M150);
                   SegmentVal = buttonModel.M150;
                  // RegAddr = "3";
                   break;
               case "180":
                   show(buttonModel.M180);
                   SegmentVal = buttonModel.M180;
                  // RegAddr = "4";
                   break;
               case "200":
                   show(buttonModel.M200);
                   SegmentVal = buttonModel.M200;
                  // RegAddr = "5";
                   break;
               case "250":
                   show(buttonModel.M250);
                   SegmentVal = buttonModel.M250;
                 //  RegAddr = "6";
                   break;
               case "350":
                   show(buttonModel.M350);
                   SegmentVal = buttonModel.M350;
                //   RegAddr = "7";
                   break;
               case "375":
                   show(buttonModel.M375);
                   SegmentVal = buttonModel.M375;
                //   RegAddr = "8";
                   break;
               case "400":
                   show(buttonModel.M400);
                   SegmentVal = buttonModel.M400;
                //   RegAddr = "9";
                   break;
           }

         
       }

    } //end Timer





    public static class buttonModel
    {
        public static string TextVal { get; set; }
        public static string TextData { get; set; }
        public static string TextMode { get; set; }
        public static string TextCount { get; set; }
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
        public static string CUR { get; set; }
        public static string MPOS { get; set; }
        public static string NPOS { get; set; }

    }
}

