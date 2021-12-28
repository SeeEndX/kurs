namespace kurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPartsInTick = new System.Windows.Forms.TrackBar();
            this.lblPerTick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpr = new System.Windows.Forms.TrackBar();
            this.lblSpr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGY = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGX = new System.Windows.Forms.TrackBar();
            this.lblGY = new System.Windows.Forms.Label();
            this.lblGX = new System.Windows.Forms.Label();
            this.btnTP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartsInTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGX)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(5, 4);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(801, 537);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            this.picDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(814, 31);
            this.tbDirection.Margin = new System.Windows.Forms.Padding(4);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(216, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(1022, 35);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(22, 17);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "0°";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(815, 493);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить счетчик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(812, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Направление потока частиц";
            // 
            // tbPartsInTick
            // 
            this.tbPartsInTick.Location = new System.Drawing.Point(814, 116);
            this.tbPartsInTick.Maximum = 20;
            this.tbPartsInTick.Name = "tbPartsInTick";
            this.tbPartsInTick.Size = new System.Drawing.Size(216, 56);
            this.tbPartsInTick.TabIndex = 9;
            this.tbPartsInTick.Value = 10;
            this.tbPartsInTick.Scroll += new System.EventHandler(this.tbPartsInTick_Scroll);
            // 
            // lblPerTick
            // 
            this.lblPerTick.AutoSize = true;
            this.lblPerTick.Location = new System.Drawing.Point(1023, 120);
            this.lblPerTick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerTick.Name = "lblPerTick";
            this.lblPerTick.Size = new System.Drawing.Size(24, 17);
            this.lblPerTick.TabIndex = 10;
            this.lblPerTick.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(824, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кол-во частиц в тик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(824, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Spread";
            // 
            // tbSpr
            // 
            this.tbSpr.Location = new System.Drawing.Point(814, 192);
            this.tbSpr.Maximum = 360;
            this.tbSpr.Name = "tbSpr";
            this.tbSpr.Size = new System.Drawing.Size(216, 56);
            this.tbSpr.TabIndex = 12;
            this.tbSpr.Value = 10;
            this.tbSpr.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblSpr
            // 
            this.lblSpr.AutoSize = true;
            this.lblSpr.Location = new System.Drawing.Point(1023, 194);
            this.lblSpr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpr.Name = "lblSpr";
            this.lblSpr.Size = new System.Drawing.Size(24, 17);
            this.lblSpr.TabIndex = 14;
            this.lblSpr.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(825, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gravy Y";
            // 
            // tbGY
            // 
            this.tbGY.Location = new System.Drawing.Point(815, 276);
            this.tbGY.Maximum = 3;
            this.tbGY.Minimum = -3;
            this.tbGY.Name = "tbGY";
            this.tbGY.Size = new System.Drawing.Size(98, 56);
            this.tbGY.TabIndex = 15;
            this.tbGY.Value = 1;
            this.tbGY.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(950, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gravy X";
            // 
            // tbGX
            // 
            this.tbGX.Location = new System.Drawing.Point(940, 276);
            this.tbGX.Maximum = 3;
            this.tbGX.Minimum = -3;
            this.tbGX.Name = "tbGX";
            this.tbGX.Size = new System.Drawing.Size(105, 56);
            this.tbGX.TabIndex = 17;
            this.tbGX.Scroll += new System.EventHandler(this.trackBar1_Scroll_2);
            // 
            // lblGY
            // 
            this.lblGY.AutoSize = true;
            this.lblGY.Location = new System.Drawing.Point(906, 279);
            this.lblGY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGY.Name = "lblGY";
            this.lblGY.Size = new System.Drawing.Size(16, 17);
            this.lblGY.TabIndex = 19;
            this.lblGY.Text = "1";
            // 
            // lblGX
            // 
            this.lblGX.AutoSize = true;
            this.lblGX.Location = new System.Drawing.Point(1037, 279);
            this.lblGX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGX.Name = "lblGX";
            this.lblGX.Size = new System.Drawing.Size(16, 17);
            this.lblGX.TabIndex = 20;
            this.lblGX.Text = "0";
            // 
            // btnTP
            // 
            this.btnTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTP.Location = new System.Drawing.Point(815, 356);
            this.btnTP.Margin = new System.Windows.Forms.Padding(4);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(239, 48);
            this.btnTP.TabIndex = 21;
            this.btnTP.Text = "Добавить телепорты";
            this.btnTP.UseVisualStyleBackColor = true;
            this.btnTP.Click += new System.EventHandler(this.btnTP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnTP);
            this.Controls.Add(this.lblGX);
            this.Controls.Add(this.lblGY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGY);
            this.Controls.Add(this.lblSpr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPerTick);
            this.Controls.Add(this.tbPartsInTick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Частицы";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartsInTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbPartsInTick;
        private System.Windows.Forms.Label lblPerTick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSpr;
        private System.Windows.Forms.Label lblSpr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbGY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbGX;
        private System.Windows.Forms.Label lblGY;
        private System.Windows.Forms.Label lblGX;
        private System.Windows.Forms.Button btnTP;
    }
}

