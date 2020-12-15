
namespace Log_In_1
{
    partial class Form2
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
            this.lblSulje = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKauppaan = new System.Windows.Forms.Label();
            this.lblAspa = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSulje
            // 
            this.lblSulje.AutoSize = true;
            this.lblSulje.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSulje.ForeColor = System.Drawing.Color.Navy;
            this.lblSulje.Location = new System.Drawing.Point(285, 511);
            this.lblSulje.Name = "lblSulje";
            this.lblSulje.Size = new System.Drawing.Size(108, 23);
            this.lblSulje.TabIndex = 8;
            this.lblSulje.Text = "Sulje ikkuna";
            this.lblSulje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSulje.Click += new System.EventHandler(this.lblSulje_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(172, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(343, 188);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Tervetuloa taidetarvikeliike Sivellin Oy:n verkkokauppaan";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKauppaan
            // 
            this.lblKauppaan.AutoSize = true;
            this.lblKauppaan.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKauppaan.ForeColor = System.Drawing.Color.Navy;
            this.lblKauppaan.Location = new System.Drawing.Point(259, 385);
            this.lblKauppaan.Name = "lblKauppaan";
            this.lblKauppaan.Size = new System.Drawing.Size(159, 25);
            this.lblKauppaan.TabIndex = 10;
            this.lblKauppaan.Text = "Verkkokauppaan";
            // 
            // lblAspa
            // 
            this.lblAspa.AutoSize = true;
            this.lblAspa.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAspa.ForeColor = System.Drawing.Color.Navy;
            this.lblAspa.Location = new System.Drawing.Point(259, 430);
            this.lblAspa.Name = "lblAspa";
            this.lblAspa.Size = new System.Drawing.Size(167, 25);
            this.lblAspa.TabIndex = 11;
            this.lblAspa.Text = "Asiakaspalveluun";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Log_In_1.Properties.Resources.pallura;
            this.pictureBox2.Location = new System.Drawing.Point(231, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Log_In_1.Properties.Resources.inkStain1;
            this.pictureBox1.Location = new System.Drawing.Point(289, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Log_In_1.Properties.Resources.pallura;
            this.pictureBox3.Location = new System.Drawing.Point(231, 430);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(690, 560);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAspa);
            this.Controls.Add(this.lblKauppaan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSulje);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 560);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sivellin Oy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSulje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKauppaan;
        private System.Windows.Forms.Label lblAspa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}