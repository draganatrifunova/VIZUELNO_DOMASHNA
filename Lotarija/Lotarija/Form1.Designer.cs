namespace Lotarija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSoSreka = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.btnGenerateBalls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(482, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(183, 78);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Започни";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSoSreka
            // 
            this.lblSoSreka.AutoSize = true;
            this.lblSoSreka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSoSreka.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSoSreka.Location = new System.Drawing.Point(496, 184);
            this.lblSoSreka.Name = "lblSoSreka";
            this.lblSoSreka.Size = new System.Drawing.Size(150, 32);
            this.lblSoSreka.TabIndex = 2;
            this.lblSoSreka.Text = "Со среќа!";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 200;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // btnGenerateBalls
            // 
            this.btnGenerateBalls.BackColor = System.Drawing.Color.Yellow;
            this.btnGenerateBalls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateBalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateBalls.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGenerateBalls.Location = new System.Drawing.Point(470, 76);
            this.btnGenerateBalls.Name = "btnGenerateBalls";
            this.btnGenerateBalls.Size = new System.Drawing.Size(213, 60);
            this.btnGenerateBalls.TabIndex = 3;
            this.btnGenerateBalls.Text = "Извлечи 7 топки";
            this.btnGenerateBalls.UseVisualStyleBackColor = false;
            this.btnGenerateBalls.UseWaitCursor = true;
            this.btnGenerateBalls.Click += new System.EventHandler(this.btnGenerateBalls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1145, 725);
            this.Controls.Add(this.btnGenerateBalls);
            this.Controls.Add(this.lblSoSreka);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSoSreka;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button btnGenerateBalls;
    }
}

