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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGraviton1 = new System.Windows.Forms.TrackBar();
            this.tbGraviton2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(4, 3);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(793, 378);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(105, 399);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(185, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление\r\n\r\n";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(296, 401);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(17, 13);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "0°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(591, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Гравитация";
            // 
            // tbGraviton1
            // 
            this.tbGraviton1.Location = new System.Drawing.Point(490, 401);
            this.tbGraviton1.Maximum = 200;
            this.tbGraviton1.Name = "tbGraviton1";
            this.tbGraviton1.Size = new System.Drawing.Size(145, 45);
            this.tbGraviton1.TabIndex = 5;
            this.tbGraviton1.Value = 100;
            this.tbGraviton1.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // tbGraviton2
            // 
            this.tbGraviton2.Location = new System.Drawing.Point(641, 401);
            this.tbGraviton2.Maximum = 200;
            this.tbGraviton2.Name = "tbGraviton2";
            this.tbGraviton2.Size = new System.Drawing.Size(145, 45);
            this.tbGraviton2.TabIndex = 6;
            this.tbGraviton2.Value = 100;
            this.tbGraviton2.Scroll += new System.EventHandler(this.tbGraviton2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGraviton2);
            this.Controls.Add(this.tbGraviton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Частицы";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbGraviton1;
        private System.Windows.Forms.TrackBar tbGraviton2;
    }
}

