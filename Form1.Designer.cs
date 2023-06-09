namespace PointYapısı
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zemin = new System.Windows.Forms.PictureBox();
            this.Borualt = new System.Windows.Forms.PictureBox();
            this.Boruust = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scortxt = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.res = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borualt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boruust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
        //    this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-7, 631);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(857, 97);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 0;
            this.zemin.TabStop = false;
            // 
            // Borualt
            // 
            this.Borualt.Image = ((System.Drawing.Image)(resources.GetObject("Borualt.Image")));
            this.Borualt.Location = new System.Drawing.Point(495, 412);
            this.Borualt.Name = "Borualt";
            this.Borualt.Size = new System.Drawing.Size(87, 223);
            this.Borualt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Borualt.TabIndex = 1;
            this.Borualt.TabStop = false;
            // 
            // Boruust
            // 
            this.Boruust.Image = ((System.Drawing.Image)(resources.GetObject("Boruust.Image")));
            this.Boruust.Location = new System.Drawing.Point(547, -1);
            this.Boruust.Name = "Boruust";
            this.Boruust.Size = new System.Drawing.Size(80, 183);
            this.Boruust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Boruust.TabIndex = 2;
            this.Boruust.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(38, 228);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(94, 105);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // scortxt
            // 
            this.scortxt.AutoSize = true;
            this.scortxt.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scortxt.Location = new System.Drawing.Point(12, 9);
            this.scortxt.Name = "scortxt";
            this.scortxt.Size = new System.Drawing.Size(129, 36);
            this.scortxt.TabIndex = 4;
            this.scortxt.Text = "Score:  0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gamerTimer);
            // 
            // res
            // 
            this.res.Image = ((System.Drawing.Image)(resources.GetObject("res.Image")));
            this.res.Location = new System.Drawing.Point(278, 207);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(263, 160);
            this.res.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.res.TabIndex = 5;
            this.res.TabStop = false;
            this.res.Visible = false;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 719);
            this.Controls.Add(this.res);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scortxt);
            this.Controls.Add(this.Boruust);
            this.Controls.Add(this.Borualt);
            this.Controls.Add(this.zemin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameskeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Borualt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boruust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox Borualt;
        private System.Windows.Forms.PictureBox Boruust;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label scortxt;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox res;
    }
}

