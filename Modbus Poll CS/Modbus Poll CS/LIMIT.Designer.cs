namespace Modbus_Poll_CS
{
    partial class LIMIT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUsePos = new System.Windows.Forms.Button();
            this.btnUseNeg = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NegLamp = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.btnNegSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNegVal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PosLamp = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.btnPosSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPosVal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lB7SegmentDisplay4 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay1 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay2 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay3 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay5 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay6 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbBuild = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(640, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 61);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "BACK";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBuild);
            this.groupBox2.Controls.Add(this.btnUsePos);
            this.groupBox2.Controls.Add(this.btnUseNeg);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Location = new System.Drawing.Point(8, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 100);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btnUsePos
            // 
            this.btnUsePos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsePos.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsePos.ForeColor = System.Drawing.Color.Black;
            this.btnUsePos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsePos.Location = new System.Drawing.Point(409, 27);
            this.btnUsePos.Name = "btnUsePos";
            this.btnUsePos.Size = new System.Drawing.Size(134, 58);
            this.btnUsePos.TabIndex = 41;
            this.btnUsePos.Text = "SAVE TO POS";
            this.btnUsePos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsePos.UseVisualStyleBackColor = false;
            this.btnUsePos.Click += new System.EventHandler(this.btnUsePos_Click);
            // 
            // btnUseNeg
            // 
            this.btnUseNeg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUseNeg.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseNeg.ForeColor = System.Drawing.Color.Black;
            this.btnUseNeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUseNeg.Location = new System.Drawing.Point(131, 27);
            this.btnUseNeg.Name = "btnUseNeg";
            this.btnUseNeg.Size = new System.Drawing.Size(138, 58);
            this.btnUseNeg.TabIndex = 40;
            this.btnUseNeg.Text = "SAVE TO NEG";
            this.btnUseNeg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUseNeg.UseVisualStyleBackColor = false;
            this.btnUseNeg.Click += new System.EventHandler(this.btnUseNeg_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NegLamp);
            this.groupBox1.Controls.Add(this.btnNegSave);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 149);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "N E G   L I M I T  ";
            // 
            // NegLamp
            // 
            this.NegLamp.BackColor = System.Drawing.Color.Transparent;
            this.NegLamp.BlinkInterval = 1000;
            this.NegLamp.Label = "    HIT LAMP";
            this.NegLamp.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Right;
            this.NegLamp.LedColor = System.Drawing.Color.Red;
            this.NegLamp.LedSize = new System.Drawing.SizeF(20F, 20F);
            this.NegLamp.Location = new System.Drawing.Point(17, 25);
            this.NegLamp.Name = "NegLamp";
            this.NegLamp.Renderer = null;
            this.NegLamp.Size = new System.Drawing.Size(120, 27);
            this.NegLamp.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.NegLamp.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.NegLamp.TabIndex = 43;
            // 
            // btnNegSave
            // 
            this.btnNegSave.BackColor = System.Drawing.Color.Gray;
            this.btnNegSave.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegSave.ForeColor = System.Drawing.Color.Black;
            this.btnNegSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNegSave.Location = new System.Drawing.Point(262, 53);
            this.btnNegSave.Name = "btnNegSave";
            this.btnNegSave.Size = new System.Drawing.Size(107, 90);
            this.btnNegSave.TabIndex = 39;
            this.btnNegSave.Text = "SAVE";
            this.btnNegSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNegSave.UseVisualStyleBackColor = false;
            this.btnNegSave.Click += new System.EventHandler(this.btnNegSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.txtNegVal);
            this.panel3.Location = new System.Drawing.Point(17, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 90);
            this.panel3.TabIndex = 38;
            // 
            // txtNegVal
            // 
            this.txtNegVal.BackColor = System.Drawing.Color.Black;
            this.txtNegVal.Font = new System.Drawing.Font("Impact", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNegVal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtNegVal.Location = new System.Drawing.Point(19, 11);
            this.txtNegVal.MaxLength = 4;
            this.txtNegVal.Name = "txtNegVal";
            this.txtNegVal.Size = new System.Drawing.Size(201, 65);
            this.txtNegVal.TabIndex = 0;
            this.txtNegVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNegVal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNegVal_MouseClick);
            this.txtNegVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNegVal_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PosLamp);
            this.groupBox3.Controls.Add(this.btnPosSave);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(406, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 149);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "P O S   L I M I T ";
            // 
            // PosLamp
            // 
            this.PosLamp.BackColor = System.Drawing.Color.Transparent;
            this.PosLamp.BlinkInterval = 500;
            this.PosLamp.Label = "HIT LAMP   ";
            this.PosLamp.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Left;
            this.PosLamp.LedColor = System.Drawing.Color.Red;
            this.PosLamp.LedSize = new System.Drawing.SizeF(20F, 20F);
            this.PosLamp.Location = new System.Drawing.Point(239, 22);
            this.PosLamp.Name = "PosLamp";
            this.PosLamp.Renderer = null;
            this.PosLamp.Size = new System.Drawing.Size(120, 27);
            this.PosLamp.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.PosLamp.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.PosLamp.TabIndex = 44;
            // 
            // btnPosSave
            // 
            this.btnPosSave.BackColor = System.Drawing.Color.Gray;
            this.btnPosSave.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosSave.ForeColor = System.Drawing.Color.Black;
            this.btnPosSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosSave.Location = new System.Drawing.Point(256, 50);
            this.btnPosSave.Name = "btnPosSave";
            this.btnPosSave.Size = new System.Drawing.Size(107, 91);
            this.btnPosSave.TabIndex = 41;
            this.btnPosSave.Text = "SAVE";
            this.btnPosSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPosSave.UseVisualStyleBackColor = false;
            this.btnPosSave.Click += new System.EventHandler(this.btnPosSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtPosVal);
            this.panel1.Location = new System.Drawing.Point(11, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 90);
            this.panel1.TabIndex = 40;
            // 
            // txtPosVal
            // 
            this.txtPosVal.BackColor = System.Drawing.Color.Black;
            this.txtPosVal.Font = new System.Drawing.Font("Impact", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosVal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtPosVal.Location = new System.Drawing.Point(19, 11);
            this.txtPosVal.MaxLength = 4;
            this.txtPosVal.Name = "txtPosVal";
            this.txtPosVal.Size = new System.Drawing.Size(201, 65);
            this.txtPosVal.TabIndex = 0;
            this.txtPosVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPosVal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPosVal_MouseClick);
            this.txtPosVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosVal_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.btnSet);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.btnDown);
            this.groupBox4.Controls.Add(this.btnUp);
            this.groupBox4.Location = new System.Drawing.Point(8, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 277);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtVal);
            this.panel2.Location = new System.Drawing.Point(192, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 109);
            this.panel2.TabIndex = 35;
            // 
            // txtVal
            // 
            this.txtVal.BackColor = System.Drawing.Color.Black;
            this.txtVal.Font = new System.Drawing.Font("Impact", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtVal.Location = new System.Drawing.Point(19, 9);
            this.txtVal.MaxLength = 4;
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(356, 89);
            this.txtVal.TabIndex = 0;
            this.txtVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVal_KeyPress);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Gray;
            this.btnSet.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.Location = new System.Drawing.Point(601, 166);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(156, 83);
            this.btnSet.TabIndex = 31;
            this.btnSet.Text = "GO";
            this.btnSet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lB7SegmentDisplay4);
            this.panel4.Controls.Add(this.lB7SegmentDisplay1);
            this.panel4.Controls.Add(this.lB7SegmentDisplay2);
            this.panel4.Controls.Add(this.lB7SegmentDisplay3);
            this.panel4.Controls.Add(this.lB7SegmentDisplay5);
            this.panel4.Controls.Add(this.lB7SegmentDisplay6);
            this.panel4.Location = new System.Drawing.Point(192, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 106);
            this.panel4.TabIndex = 23;
            // 
            // lB7SegmentDisplay4
            // 
            this.lB7SegmentDisplay4.BackColor = System.Drawing.Color.Black;
            this.lB7SegmentDisplay4.ForeColor = System.Drawing.Color.GreenYellow;
            this.lB7SegmentDisplay4.Location = new System.Drawing.Point(194, 13);
            this.lB7SegmentDisplay4.Name = "lB7SegmentDisplay4";
            this.lB7SegmentDisplay4.Renderer = null;
            this.lB7SegmentDisplay4.ShowDP = true;
            this.lB7SegmentDisplay4.Size = new System.Drawing.Size(58, 84);
            this.lB7SegmentDisplay4.TabIndex = 14;
            this.lB7SegmentDisplay4.Value = 1;
            // 
            // lB7SegmentDisplay1
            // 
            this.lB7SegmentDisplay1.BackColor = System.Drawing.Color.Black;
            this.lB7SegmentDisplay1.ForeColor = System.Drawing.Color.GreenYellow;
            this.lB7SegmentDisplay1.Location = new System.Drawing.Point(17, 13);
            this.lB7SegmentDisplay1.Name = "lB7SegmentDisplay1";
            this.lB7SegmentDisplay1.Renderer = null;
            this.lB7SegmentDisplay1.ShowDP = false;
            this.lB7SegmentDisplay1.Size = new System.Drawing.Size(58, 84);
            this.lB7SegmentDisplay1.TabIndex = 12;
            this.lB7SegmentDisplay1.Value = 0;
            // 
            // lB7SegmentDisplay2
            // 
            this.lB7SegmentDisplay2.BackColor = System.Drawing.Color.Black;
            this.lB7SegmentDisplay2.ForeColor = System.Drawing.Color.GreenYellow;
            this.lB7SegmentDisplay2.Location = new System.Drawing.Point(76, 13);
            this.lB7SegmentDisplay2.Name = "lB7SegmentDisplay2";
            this.lB7SegmentDisplay2.Renderer = null;
            this.lB7SegmentDisplay2.ShowDP = false;
            this.lB7SegmentDisplay2.Size = new System.Drawing.Size(58, 84);
            this.lB7SegmentDisplay2.TabIndex = 13;
            this.lB7SegmentDisplay2.Value = 0;
            // 
            // lB7SegmentDisplay3
            // 
            this.lB7SegmentDisplay3.BackColor = System.Drawing.Color.Black;
            this.lB7SegmentDisplay3.ForeColor = System.Drawing.Color.GreenYellow;
            this.lB7SegmentDisplay3.Location = new System.Drawing.Point(135, 13);
            this.lB7SegmentDisplay3.Name = "lB7SegmentDisplay3";
            this.lB7SegmentDisplay3.Renderer = null;
            this.lB7SegmentDisplay3.ShowDP = false;
            this.lB7SegmentDisplay3.Size = new System.Drawing.Size(58, 84);
            this.lB7SegmentDisplay3.TabIndex = 15;
            this.lB7SegmentDisplay3.Value = 2;
            // 
            // lB7SegmentDisplay5
            // 
            this.lB7SegmentDisplay5.BackColor = System.Drawing.Color.Black;
            this.lB7SegmentDisplay5.ForeColor = System.Drawing.Color.GreenYellow;
            this.lB7SegmentDisplay5.Location = new System.Drawing.Point(255, 13);
            this.lB7SegmentDisplay5.Name = "lB7SegmentDisplay5";
            this.lB7SegmentDisplay5.Renderer = null;
            this.lB7SegmentDisplay5.ShowDP = false;
            this.lB7SegmentDisplay5.Size = new System.Drawing.Size(58, 84);
            this.lB7SegmentDisplay5.TabIndex = 19;
            this.lB7SegmentDisplay5.Value = 2;
            // 
            // lB7SegmentDisplay6
            // 
            this.lB7SegmentDisplay6.BackColor = System.Drawing.Color.Black;
            this.lB7SegmentDisplay6.ForeColor = System.Drawing.Color.GreenYellow;
            this.lB7SegmentDisplay6.Location = new System.Drawing.Point(315, 13);
            this.lB7SegmentDisplay6.Name = "lB7SegmentDisplay6";
            this.lB7SegmentDisplay6.Renderer = null;
            this.lB7SegmentDisplay6.ShowDP = false;
            this.lB7SegmentDisplay6.Size = new System.Drawing.Size(58, 84);
            this.lB7SegmentDisplay6.TabIndex = 18;
            this.lB7SegmentDisplay6.Value = 1;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Gray;
            this.btnDown.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(21, 42);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(156, 84);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "- JOG ";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Gray;
            this.btnUp.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(600, 42);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(156, 84);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "JOG +";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbBuild
            // 
            this.lbBuild.AutoSize = true;
            this.lbBuild.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbBuild.Location = new System.Drawing.Point(18, 75);
            this.lbBuild.Name = "lbBuild";
            this.lbBuild.Size = new System.Drawing.Size(29, 13);
            this.lbBuild.TabIndex = 36;
            this.lbBuild.Text = "build";
            // 
            // LIMIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.MinimizeBox = false;
            this.Name = "LIMIT";
            this.Text = "SET DRIVE LIMIT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LIMIT_FormClosed);
            this.Load += new System.EventHandler(this.LIMIT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNegVal;
        private System.Windows.Forms.Button btnNegSave;
        private System.Windows.Forms.Button btnPosSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPosVal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel panel4;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay4;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay1;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay2;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay3;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay5;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay6;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Timer timer1;
        private LBSoft.IndustrialCtrls.Leds.LBLed NegLamp;
        private LBSoft.IndustrialCtrls.Leds.LBLed PosLamp;
        private System.Windows.Forms.Button btnUsePos;
        private System.Windows.Forms.Button btnUseNeg;
        private System.Windows.Forms.Label lbBuild;
    }
}