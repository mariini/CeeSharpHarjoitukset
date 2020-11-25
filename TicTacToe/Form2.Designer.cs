namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ekaPelaaja = new System.Windows.Forms.TextBox();
            this.tokaPelaaja = new System.Windows.Forms.TextBox();
            this.button_start_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelaaja 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelaaja 2";
            // 
            // ekaPelaaja
            // 
            this.ekaPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekaPelaaja.Location = new System.Drawing.Point(162, 31);
            this.ekaPelaaja.Name = "ekaPelaaja";
            this.ekaPelaaja.Size = new System.Drawing.Size(286, 31);
            this.ekaPelaaja.TabIndex = 2;
            // 
            // tokaPelaaja
            // 
            this.tokaPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokaPelaaja.Location = new System.Drawing.Point(162, 85);
            this.tokaPelaaja.Name = "tokaPelaaja";
            this.tokaPelaaja.Size = new System.Drawing.Size(286, 31);
            this.tokaPelaaja.TabIndex = 3;
            this.tokaPelaaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tokaPelaaja_KeyPress);
            // 
            // button_start_game
            // 
            this.button_start_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_game.Location = new System.Drawing.Point(307, 138);
            this.button_start_game.Name = "button_start_game";
            this.button_start_game.Size = new System.Drawing.Size(141, 33);
            this.button_start_game.TabIndex = 4;
            this.button_start_game.Text = "Aloita peli!";
            this.button_start_game.UseVisualStyleBackColor = true;
            this.button_start_game.Click += new System.EventHandler(this.button_start_game_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 195);
            this.Controls.Add(this.button_start_game);
            this.Controls.Add(this.tokaPelaaja);
            this.Controls.Add(this.ekaPelaaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 234);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 234);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ekaPelaaja;
        private System.Windows.Forms.TextBox tokaPelaaja;
        private System.Windows.Forms.Button button_start_game;
    }
}