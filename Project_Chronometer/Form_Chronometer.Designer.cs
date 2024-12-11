namespace Project_Chronometer
{
    partial class Form_Chronometer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Button_Reset = new Button();
            Button_Play = new Button();
            TextBox_Seconds = new TextBox();
            TextBox_Minutes = new TextBox();
            Timer_AnalyzeTimer = new System.Windows.Forms.Timer(components);
            TextBox_MiliSeconds = new TextBox();
            Button_Pause = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Reset
            // 
            Button_Reset.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Reset.Location = new Point(41, 166);
            Button_Reset.Name = "Button_Reset";
            Button_Reset.Size = new Size(127, 37);
            Button_Reset.TabIndex = 3;
            Button_Reset.Text = "Reset";
            Button_Reset.UseVisualStyleBackColor = true;
            Button_Reset.Click += Button_Reset_Click;
            // 
            // Button_Play
            // 
            Button_Play.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Play.Location = new Point(183, 166);
            Button_Play.Name = "Button_Play";
            Button_Play.Size = new Size(127, 37);
            Button_Play.TabIndex = 4;
            Button_Play.Text = "Play";
            Button_Play.UseVisualStyleBackColor = true;
            Button_Play.Click += Button_Play_Click;
            // 
            // TextBox_Seconds
            // 
            TextBox_Seconds.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox_Seconds.Location = new Point(121, 49);
            TextBox_Seconds.Multiline = true;
            TextBox_Seconds.Name = "TextBox_Seconds";
            TextBox_Seconds.Size = new Size(68, 35);
            TextBox_Seconds.TabIndex = 5;
            TextBox_Seconds.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_Minutes
            // 
            TextBox_Minutes.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox_Minutes.Location = new Point(20, 49);
            TextBox_Minutes.Multiline = true;
            TextBox_Minutes.Name = "TextBox_Minutes";
            TextBox_Minutes.Size = new Size(68, 35);
            TextBox_Minutes.TabIndex = 6;
            TextBox_Minutes.TextAlign = HorizontalAlignment.Center;
            // 
            // Timer_AnalyzeTimer
            // 
            Timer_AnalyzeTimer.Tick += Timer_AnalyzeTimer_Tick;
            // 
            // TextBox_MiliSeconds
            // 
            TextBox_MiliSeconds.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox_MiliSeconds.Location = new Point(221, 49);
            TextBox_MiliSeconds.Multiline = true;
            TextBox_MiliSeconds.Name = "TextBox_MiliSeconds";
            TextBox_MiliSeconds.Size = new Size(68, 35);
            TextBox_MiliSeconds.TabIndex = 7;
            TextBox_MiliSeconds.TextAlign = HorizontalAlignment.Center;
            // 
            // Button_Pause
            // 
            Button_Pause.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Pause.Location = new Point(107, 221);
            Button_Pause.Name = "Button_Pause";
            Button_Pause.Size = new Size(138, 37);
            Button_Pause.TabIndex = 8;
            Button_Pause.Text = "Pause";
            Button_Pause.UseVisualStyleBackColor = true;
            Button_Pause.Click += Button_Pause_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 9;
            label1.Text = "Chronometer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 29);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 10;
            label2.Text = "Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(121, 29);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 11;
            label3.Text = "Seconds";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(221, 29);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 12;
            label4.Text = "MiliSeconds";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TextBox_Minutes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TextBox_Seconds);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TextBox_MiliSeconds);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 104);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Star Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 52);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 13;
            label5.Text = ":";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(195, 52);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 14;
            label6.Text = ":";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Chronometer
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 280);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Button_Pause);
            Controls.Add(Button_Play);
            Controls.Add(Button_Reset);
            Name = "Form_Chronometer";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_Reset;
        private Button Button_Play;
        private TextBox TextBox_Seconds;
        private TextBox TextBox_Minutes;
        private System.Windows.Forms.Timer Timer_AnalyzeTimer;
        private TextBox TextBox_MiliSeconds;
        private Button Button_Pause;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
    }
}
