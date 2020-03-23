namespace RobotMoving
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_X1 = new System.Windows.Forms.ComboBox();
            this.cb_Y1 = new System.Windows.Forms.ComboBox();
            this.cb_X2 = new System.Windows.Forms.ComboBox();
            this.cb_Y2 = new System.Windows.Forms.ComboBox();
            this.cb_X3 = new System.Windows.Forms.ComboBox();
            this.cb_Y3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_D1 = new System.Windows.Forms.ComboBox();
            this.cb_D2 = new System.Windows.Forms.ComboBox();
            this.cb_D3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Moves1 = new System.Windows.Forms.TextBox();
            this.txt_Moves2 = new System.Windows.Forms.TextBox();
            this.txt_Moves3 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Robot 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Robot 3";
            // 
            // cb_X1
            // 
            this.cb_X1.FormattingEnabled = true;
            this.cb_X1.Location = new System.Drawing.Point(124, 58);
            this.cb_X1.Name = "cb_X1";
            this.cb_X1.Size = new System.Drawing.Size(121, 21);
            this.cb_X1.TabIndex = 3;
            // 
            // cb_Y1
            // 
            this.cb_Y1.FormattingEnabled = true;
            this.cb_Y1.Location = new System.Drawing.Point(124, 96);
            this.cb_Y1.Name = "cb_Y1";
            this.cb_Y1.Size = new System.Drawing.Size(121, 21);
            this.cb_Y1.TabIndex = 4;
            // 
            // cb_X2
            // 
            this.cb_X2.FormattingEnabled = true;
            this.cb_X2.Location = new System.Drawing.Point(414, 58);
            this.cb_X2.Name = "cb_X2";
            this.cb_X2.Size = new System.Drawing.Size(121, 21);
            this.cb_X2.TabIndex = 5;
            // 
            // cb_Y2
            // 
            this.cb_Y2.FormattingEnabled = true;
            this.cb_Y2.Location = new System.Drawing.Point(414, 96);
            this.cb_Y2.Name = "cb_Y2";
            this.cb_Y2.Size = new System.Drawing.Size(121, 21);
            this.cb_Y2.TabIndex = 6;
            // 
            // cb_X3
            // 
            this.cb_X3.DropDownWidth = 100;
            this.cb_X3.FormattingEnabled = true;
            this.cb_X3.Location = new System.Drawing.Point(783, 58);
            this.cb_X3.Name = "cb_X3";
            this.cb_X3.Size = new System.Drawing.Size(121, 21);
            this.cb_X3.TabIndex = 7;
            // 
            // cb_Y3
            // 
            this.cb_Y3.DropDownWidth = 100;
            this.cb_Y3.FormattingEnabled = true;
            this.cb_Y3.Location = new System.Drawing.Point(783, 96);
            this.cb_Y3.Name = "cb_Y3";
            this.cb_Y3.Size = new System.Drawing.Size(121, 21);
            this.cb_Y3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direction";
            // 
            // cb_D1
            // 
            this.cb_D1.FormattingEnabled = true;
            this.cb_D1.Location = new System.Drawing.Point(124, 131);
            this.cb_D1.Name = "cb_D1";
            this.cb_D1.Size = new System.Drawing.Size(121, 21);
            this.cb_D1.TabIndex = 12;
            // 
            // cb_D2
            // 
            this.cb_D2.FormattingEnabled = true;
            this.cb_D2.Location = new System.Drawing.Point(414, 131);
            this.cb_D2.Name = "cb_D2";
            this.cb_D2.Size = new System.Drawing.Size(121, 21);
            this.cb_D2.TabIndex = 13;
            // 
            // cb_D3
            // 
            this.cb_D3.FormattingEnabled = true;
            this.cb_D3.Location = new System.Drawing.Point(783, 131);
            this.cb_D3.Name = "cb_D3";
            this.cb_D3.Size = new System.Drawing.Size(121, 21);
            this.cb_D3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Moves";
            // 
            // txt_Moves1
            // 
            this.txt_Moves1.Location = new System.Drawing.Point(124, 168);
            this.txt_Moves1.Name = "txt_Moves1";
            this.txt_Moves1.Size = new System.Drawing.Size(121, 20);
            this.txt_Moves1.TabIndex = 16;
            // 
            // txt_Moves2
            // 
            this.txt_Moves2.Location = new System.Drawing.Point(414, 171);
            this.txt_Moves2.Name = "txt_Moves2";
            this.txt_Moves2.Size = new System.Drawing.Size(121, 20);
            this.txt_Moves2.TabIndex = 17;
            // 
            // txt_Moves3
            // 
            this.txt_Moves3.Location = new System.Drawing.Point(783, 168);
            this.txt_Moves3.Name = "txt_Moves3";
            this.txt_Moves3.Size = new System.Drawing.Size(121, 20);
            this.txt_Moves3.TabIndex = 18;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(315, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(314, 50);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "StartMove";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Robotları Yerleştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txt_Moves3);
            this.Controls.Add(this.txt_Moves2);
            this.Controls.Add(this.txt_Moves1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_D3);
            this.Controls.Add(this.cb_D2);
            this.Controls.Add(this.cb_D1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Y3);
            this.Controls.Add(this.cb_X3);
            this.Controls.Add(this.cb_Y2);
            this.Controls.Add(this.cb_X2);
            this.Controls.Add(this.cb_Y1);
            this.Controls.Add(this.cb_X1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_X1;
        private System.Windows.Forms.ComboBox cb_Y1;
        private System.Windows.Forms.ComboBox cb_X2;
        private System.Windows.Forms.ComboBox cb_Y2;
        private System.Windows.Forms.ComboBox cb_X3;
        private System.Windows.Forms.ComboBox cb_Y3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_D1;
        private System.Windows.Forms.ComboBox cb_D2;
        private System.Windows.Forms.ComboBox cb_D3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Moves1;
        private System.Windows.Forms.TextBox txt_Moves2;
        private System.Windows.Forms.TextBox txt_Moves3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

