using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Collections;

namespace Modbus_Poll_CS
{
    /* New dedicate the Serial Port Mobus from Main || Sep 1, 2021 
     *  Version 1.0 build 07092021
     *  Current position            = 0520H -0521H [DW SINGED DECIMAL]  = 1312D
     *  Positive Limit position     = 0510H -0511H [DW SINGED DECIMAL]  = 1294D
     *  Negative Limit position     = 0512H -0513H [DW SINGED DECIMAL]  = 1296D
     *  Positive HIT Lamp position  = 0412.4H [BIT]  = 1042D
     *  Negative HIT Lamp position  = 0412.5H [BIT]  = 1042D
    */
    public partial class LIMIT : Form
    {
        string SLAVE_ID, REG_ADDR, REG_QTY, COM_PORT, BUAD_RATE;
        string ADDR_CUR,ADDR_MPOS,ADDR_NPOS,ADDR_HITLAMP;
        string RegisterQty, RegisterAddr, slaveID;
        bool flagNegUpdate, flagPosUpdate;
        String SegmentVal;
        string dataType;

        public delegate void GUIDelegate(string paramString);       // Share data across thread

        // Initial Parameter 
        Double Jog_Step = 1;                                         // Step UP/Down for Jog button
        int Jog_Delay = 200;                                         // Delay time (ms) when press Jog button without unpress
        int Data_Refresh_Interval = 100;                             // Interval time for read/write Modbus --> Data Refresh Time
        string build = "07092021";
        modbus mb = new modbus();
        SerialPort sp = new SerialPort();

        System.Timers.Timer timer = new System.Timers.Timer();      // Master Loop for read/write Modbus   @TIMER#1




        public LIMIT()
        {

            InitializeComponent();
            ReadConfiguration();                                   // Read initial parameter from @config.txt file

            SendLIMIT_DATA.w_Flag = false;
            REG_QTY = "300";                                       // Qty of register to read start from ADDR_HITLAMP
            REG_ADDR = ADDR_HITLAMP;                               // Beginging address modbus to read
            flagNegUpdate = true;
            flagPosUpdate = true;

            StartPoll(REG_QTY, REG_ADDR, SLAVE_ID);                // Initial Main Lopp for read/write MODBUS --> 
            SegmentVal = "0";
            show(SegmentVal);
            lbBuild.Text = build;
            #region Hold Jog Button
            #region Hold Button UP

            System.Windows.Forms.Timer timer_JogUp = new System.Windows.Forms.Timer();                  // Timer for Jog Button support case unreleased button
            timer_JogUp.Interval = Jog_Delay;

            btnUp.MouseDown += delegate(object sender, MouseEventArgs mea) { timer_JogUp.Start(); };
            btnUp.MouseUp += delegate(object sender, MouseEventArgs mea) { timer_JogUp.Stop(); };
            timer_JogUp.Tick += delegate(object sender, EventArgs e) { runLoop_JogUp(); };

            #endregion

            #region Hold Button Down
            System.Windows.Forms.Timer timer_JogDown = new System.Windows.Forms.Timer();            // Timer for Jog Button support case unreleased button
            timer_JogDown.Interval = Jog_Delay;

            btnDown.MouseDown += delegate(object sender, MouseEventArgs mea) { timer_JogDown.Start(); };
            btnDown.MouseUp += delegate(object sender, MouseEventArgs mea) { timer_JogDown.Stop(); };
            timer_JogDown.Tick += delegate(object sender, EventArgs e) { runLoop_JogDown(); };

            #endregion
            #endregion
         
        }


        #region Default button/textbox event handeling

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void LIMIT_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopPoll();
            mb.Close();
            System.Threading.Thread.Sleep(100);
            this.Dispose();
        }

        private void btnUp_Click(object sender, EventArgs e)    { runLoop_JogUp();}

        private void LIMIT_Load(object sender, EventArgs e)     { this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,(Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);}

        private void txtVal_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))        // IF allow Floating           
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)) { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))  { e.Handled = true; }
        }

        private void txtNegVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNegVal.ForeColor = Color.Red;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back )) { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains(".")){ e.Handled = true;  }
        }

        private void txtPosVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPosVal.ForeColor = Color.Red;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))  { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains(".")) { e.Handled = true;}
        }

        private void btnNegSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtNegVal.Text) > 9999.99)
            {
                //txtNegVal.Text = "0000.00";
                Console.WriteLine("Value over 9999.99");
            }
            else {
                SendLIMIT_DATA.w_Data = Convert.ToString(Convert.ToInt16(txtNegVal.Text));
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_NPOS;               
                flagNegUpdate = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(buttonModel.CUR))
            {
                buttonModel.CUR = "0";
            }
            show(buttonModel.CUR);
            // Console.WriteLine(buttonModel.NPOS);
            SegmentVal = buttonModel.CUR;

            var limitFlag = new BitArray(BitConverter.GetBytes(Convert.ToInt16(SendLIMIT_DATA.hit_lamp)));
            if (limitFlag[5])
            {
                NegLamp.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            }
            else
            {
                NegLamp.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            }

            if (limitFlag[4])
            {
                PosLamp.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            }
            else
            {
                PosLamp.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            }


            //  textBox1.Text = limitFlag[4].ToString();  //Pos Lamp

            if (flagNegUpdate)
            {
                txtNegVal.ForeColor = Color.LawnGreen;
                txtNegVal.Text = Convert.ToString(buttonModel.NPOS);
            }
            if (flagPosUpdate)
            {
                txtPosVal.ForeColor = Color.LawnGreen;
                txtPosVal.Text = Convert.ToString(buttonModel.MPOS);
            }
        }

        private void btnDown_Click(object sender, EventArgs e) { runLoop_JogDown(); }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (txtVal.TextLength > 0)
            {
                string[] val = txtVal.Text.Split('.');
                if (val.Length == 2)
                {
                    if (val[1].Length == 1) { txtVal.Text = txtVal.Text + "0"; }
                }
                else { txtVal.Text = txtVal.Text + ".00"; }

                if (val[0].Length <= 4)
                {
                    SendLIMIT_DATA.w_Data = Convert.ToString(Convert.ToInt16(val[0]));
                    SendLIMIT_DATA.w_Flag = true;
                    SendLIMIT_DATA.w_Register = ADDR_CUR;
                    txtVal.Text = "";
                }
                else { txtVal.Text = ""; }
            }
        }

        private void txtNegVal_MouseClick(object sender, MouseEventArgs e) { flagNegUpdate = false; }

        private void txtPosVal_MouseClick(object sender, MouseEventArgs e) { flagPosUpdate = false; }

        private void btnPosSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtPosVal.Text) > 9999.99)
            {
                //txtNegVal.Text = "0000.00";
                Console.WriteLine("Value over 9999.99");
            }
            else
            {
                SendLIMIT_DATA.w_Data = Convert.ToString(Convert.ToInt16(txtPosVal.Text));
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_MPOS;
                flagPosUpdate = true;
            }
        }

        private void btnUseNeg_Click(object sender, EventArgs e)
        {
            var currentVal = Convert.ToDouble(SegmentVal);
            if (currentVal <= 9999.99)
            {
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_NPOS;
            }
            else
            {
                currentVal = 9999.99;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_NPOS;
            }
        }

        private void btnUsePos_Click(object sender, EventArgs e)
        {
            var currentVal = Convert.ToDouble(SegmentVal);
            if (currentVal <= 9999.99)
            {
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_MPOS;
            }
            else
            {
                currentVal = 9999.99;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_MPOS;
            }
        }


        #endregion _Default button/textbox event handeling


        /*   XBase define function 
         
         */

        private void show(string inVal)
        {
            string[] valSplit = inVal.Split('.');
            var val_decimal = "";
            var val_int = valSplit[0];

            if (valSplit.Length == 1) { val_decimal = "00";}
            else  { val_decimal = valSplit[1]; }

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
            else  { lB7SegmentDisplay1.Value = 10;  }

            if (val_int.Length >= 3)
            {
                lB7SegmentDisplay2.Enabled = true;
                lB7SegmentDisplay2.Value = (int)Char.GetNumericValue(characters[1]);
            }
            else  { lB7SegmentDisplay2.Value = 10; }

            if (val_int.Length >= 2)
            {
                lB7SegmentDisplay3.Enabled = true;
                lB7SegmentDisplay3.Value = (int)Char.GetNumericValue(characters[2]);
            }
            else  { lB7SegmentDisplay3.Value = 10;}

            if (val_int.Length >= 1)
            {
                lB7SegmentDisplay4.Enabled = true;
                lB7SegmentDisplay4.Value = (int)Char.GetNumericValue(characters[3]);
            }
            else  {lB7SegmentDisplay4.Value = 10;}

            char[] dec_characters = val_decimal.ToCharArray();
            lB7SegmentDisplay5.Value = (int)Char.GetNumericValue(dec_characters[0]);
            lB7SegmentDisplay6.Value = (int)Char.GetNumericValue(dec_characters[1]);
        }

        void runLoop_JogUp()
        {
            var currentVal = Convert.ToDouble(SegmentVal);
            if (currentVal <= 9999.99)
            {
                currentVal = currentVal + Jog_Step;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_CUR;
            }
            else
            {
                currentVal = 9999.99;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_CUR;
            }

        }

        void runLoop_JogDown()
        {
            var currentVal = Convert.ToDouble(SegmentVal);
            if (currentVal > 0)
            {
                currentVal = currentVal - Jog_Step;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_CUR;
               // Console.WriteLine(currentVal);
            }
            else
            {
                currentVal = 0;
                SegmentVal = currentVal.ToString("0.00");
                string[] segMent = SegmentVal.Split('.');
                SendLIMIT_DATA.w_Data = segMent[0].ToString();
                SendLIMIT_DATA.w_Flag = true;
                SendLIMIT_DATA.w_Register = ADDR_CUR;
            }

        }


        #region Poll Function                                                                                   // Step 3 Read/Write Modbus

        // Run one time but Tick from TiMer#1 Interval time
        // Data output send to delegate function via DoGUIUpdate function

        private void PollFunction()
        {

            short[] values = new short[Convert.ToInt32(RegisterQty)];                   // Data out array
            ushort pollStart;
            ushort pollLength;

            #region Read Modbus Register

            pollStart = Convert.ToUInt16((Int32.Parse(RegisterAddr) - 1).ToString());   //Start Address
            //pollStart = Convert.ToUInt16((Int32.Parse(RegisterAddr)).ToString());     //Start Address
            pollLength = Convert.ToUInt16(RegisterQty);
            string itemString;

            try
            {
                timer.Stop();
                while (!mb.SendFc3(Convert.ToByte(slaveID), pollStart, pollLength, ref values)) ;
                timer.Start();
                // if need delay  System.Threading.Thread.Sleep(50);
            }
            catch (Exception err)
            { Console.WriteLine("Error in modbus read: " + err.Message); }


            #region Update Data out
            switch (dataType)
            {
                case "Decimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        // itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" + Convert.ToString(pollStart + i) + "] = " + values[i].ToString();
                        itemString = Convert.ToString(pollStart + i) + "=" + values[i].ToString();
                        DoGUIUpdate(itemString);
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

            #region Write Modbus Register

            if (SendLIMIT_DATA.w_Flag)                                                           // Check from Notice Flag that we have data to write
            {
                short[] value = new short[1];
                value[0] = Convert.ToInt16(SendLIMIT_DATA.w_Data);
                ushort regAddr = Convert.ToUInt16(SendLIMIT_DATA.w_Register);

                try
                {
                    timer.Stop();
                    while (!mb.SendFc16(Convert.ToByte(slaveID), regAddr, (ushort)1, value)) ;
                    timer.Start();
                }
                catch (Exception err)
                { Console.WriteLine("Error in modbus read: " + err.Message); }

                SendLIMIT_DATA.w_Data = "";
                SendLIMIT_DATA.w_Flag = false;
            }
            #endregion

        }

        #region GUI Update

        public void DoGUIUpdate(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoGUIUpdate);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
            {
                string[] itemparam = paramString.Split('=');
                if (ADDR_CUR == itemparam[0].ToString())            { buttonModel.CUR = itemparam[1]; }
                else if (ADDR_MPOS == itemparam[0].ToString())      { buttonModel.MPOS = itemparam[1]; }
                else if (ADDR_NPOS == itemparam[0].ToString())      { buttonModel.NPOS = itemparam[1];}
                else if (ADDR_HITLAMP == itemparam[0].ToString())   {SendLIMIT_DATA.hit_lamp = itemparam[1]; }
            }

        }

        #endregion _GUI Update

        #endregion _Poll Function


        #region Start/Stop

        private void StartPoll(string Qty, string Addr, string ID)                                              // Step 2 from Start Program
        {
            try
            {
                if (mb.Open(COM_PORT, Convert.ToInt32(BUAD_RATE), 8, Parity.None, StopBits.Two))
                {
                    short[] valuesCheck = new short[Convert.ToInt32(99)];
                    ushort regAddr = Convert.ToUInt16("99");
                    bool z = mb.SendFc3(Convert.ToByte(ID), regAddr, (ushort)1, ref valuesCheck);               // Mobus Communication Testing
                    if (z)
                    {
                        dataType = "Decimal";   //{ "Decimal", "Hexadecimal", "Float", "Reverse" }
                        RegisterQty = Qty;
                        RegisterAddr = Addr;
                        slaveID = ID;

                        timer.AutoReset = true;
                        timer.Interval = Data_Refresh_Interval;
                        timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
                        timer.Start();
                    }
                    else { MessageBox.Show("COM Port not Ready " + "  regAddr=" + regAddr + "   ID = " + ID + " COM_Port = " + COM_PORT + "  BUAD =" + BUAD_RATE); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e) { PollFunction(); }                               // Step 2.1 Call Poll Function

        private void StopPoll()
        {
            timer.Stop();                                                                                       // Stop TiMer#1 read//write Modbus
            mb.Close();
            System.Threading.Thread.Sleep(100);
        }

        #endregion _Start/Stop

        private void ReadConfiguration()
        {
            try
            {
                string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                var lines = System.IO.File.ReadAllLines(appPath + @"\config.txt");

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
                        case "ADDR_CUR":
                            ADDR_CUR = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_MPOS":
                            ADDR_MPOS = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_NPOS":
                            ADDR_NPOS = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                        case "ADDR_HITLAMP":
                            ADDR_HITLAMP = (Int32.Parse(lineConfig[1]) - 1).ToString();
                            break;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }

}

public static class SendLIMIT_DATA
{
    public static bool w_Flag { get; set; }
    public static string w_Data { get; set; }
    public static string w_Register { get; set; }
    public static string hit_lamp { get; set; }

}