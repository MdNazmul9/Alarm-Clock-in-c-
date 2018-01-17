namespace Alarm_clock
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.T_now = new System.Windows.Forms.Label();
            this.T_set = new System.Windows.Forms.Label();
            this.mtb = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.time_now = new System.Windows.Forms.Timer(this.components);
            this.time_set = new System.Windows.Forms.Timer(this.components);
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(415, 38);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "Browse";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(58, 120);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "Start";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(390, 120);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 2;
            this.b3.Text = "Stop";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // T_now
            // 
            this.T_now.AutoSize = true;
            this.T_now.Location = new System.Drawing.Point(225, 130);
            this.T_now.Name = "T_now";
            this.T_now.Size = new System.Drawing.Size(49, 13);
            this.T_now.TabIndex = 3;
            this.T_now.Text = "00:00:00";
            // 
            // T_set
            // 
            this.T_set.AutoSize = true;
            this.T_set.Location = new System.Drawing.Point(225, 195);
            this.T_set.Name = "T_set";
            this.T_set.Size = new System.Drawing.Size(49, 13);
            this.T_set.TabIndex = 4;
            this.T_set.Text = "00:00:00";
            // 
            // mtb
            // 
            this.mtb.Location = new System.Drawing.Point(228, 231);
            this.mtb.Mask = "00:00:00";
            this.mtb.Name = "mtb";
            this.mtb.Size = new System.Drawing.Size(46, 20);
            this.mtb.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(49, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 6;
            // 
            // time_now
            // 
            this.time_now.Enabled = true;
            this.time_now.Interval = 1000;
            this.time_now.Tick += new System.EventHandler(this.time_now_Tick);
            // 
            // time_set
            // 
            this.time_set.Tick += new System.EventHandler(this.time_set_Tick);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(390, 209);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(75, 23);
            this.Media.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 281);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mtb);
            this.Controls.Add(this.T_set);
            this.Controls.Add(this.T_now);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label T_now;
        private System.Windows.Forms.Label T_set;
        private System.Windows.Forms.MaskedTextBox mtb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer time_now;
        private System.Windows.Forms.Timer time_set;
        private AxWMPLib.AxWindowsMediaPlayer Media;
    }
}

