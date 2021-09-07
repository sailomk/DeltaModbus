namespace Modbus_Poll_CS
{
    partial class EDIT
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lB7SegmentDisplay4 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay1 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay2 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay3 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.lB7SegmentDisplay5 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lB7SegmentDisplay6 = new LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay();
            this.btnDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtTitle.Location = new System.Drawing.Point(165, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(280, 34);
            this.txtTitle.TabIndex = 33;
            this.txtTitle.Text = "Size xx  ml  is selected";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Location = new System.Drawing.Point(52, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 68);
            this.panel2.TabIndex = 34;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(9, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 110);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Gray;
            this.btnSet.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.Location = new System.Drawing.Point(601, 172);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(156, 83);
            this.btnSet.TabIndex = 31;
            this.btnSet.Text = "GO";
            this.btnSet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Location = new System.Drawing.Point(8, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 100);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lB7SegmentDisplay4);
            this.panel1.Controls.Add(this.lB7SegmentDisplay1);
            this.panel1.Controls.Add(this.lB7SegmentDisplay2);
            this.panel1.Controls.Add(this.lB7SegmentDisplay3);
            this.panel1.Controls.Add(this.lB7SegmentDisplay5);
            this.panel1.Controls.Add(this.lB7SegmentDisplay6);
            this.panel1.Location = new System.Drawing.Point(192, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 106);
            this.panel1.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.btnSet);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.btnDown);
            this.groupBox3.Controls.Add(this.btnUp);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 319);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.txtVal);
            this.panel3.Location = new System.Drawing.Point(192, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 109);
            this.panel3.TabIndex = 35;
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
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Gray;
            this.btnUp.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(601, 42);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(156, 84);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "JOG +";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EDIT";
            this.Text = "Program Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EDIT_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EDIT_FormClosed);
            this.Load += new System.EventHandler(this.EDIT_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel panel2;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay4;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay1;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay2;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay3;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private LBSoft.IndustrialCtrls.Leds.LB7SegmentDisplay lB7SegmentDisplay6;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Timer timer1;
    }
}