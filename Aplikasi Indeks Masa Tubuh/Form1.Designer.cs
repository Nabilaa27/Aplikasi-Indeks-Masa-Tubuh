namespace Aplikasi_Indeks_Masa_Tubuh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txNama = new System.Windows.Forms.TextBox();
            this.txTinggi = new System.Windows.Forms.TextBox();
            this.txBerat = new System.Windows.Forms.TextBox();
            this.btCek = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index Massa Tubuh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tinggi Badan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Berat Badan";
            // 
            // txNama
            // 
            this.txNama.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNama.Location = new System.Drawing.Point(215, 111);
            this.txNama.Name = "txNama";
            this.txNama.Size = new System.Drawing.Size(362, 30);
            this.txNama.TabIndex = 6;
            // 
            // txTinggi
            // 
            this.txTinggi.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTinggi.Location = new System.Drawing.Point(215, 172);
            this.txTinggi.Name = "txTinggi";
            this.txTinggi.Size = new System.Drawing.Size(362, 30);
            this.txTinggi.TabIndex = 8;
            // 
            // txBerat
            // 
            this.txBerat.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBerat.Location = new System.Drawing.Point(215, 235);
            this.txBerat.Name = "txBerat";
            this.txBerat.Size = new System.Drawing.Size(362, 30);
            this.txBerat.TabIndex = 9;
            // 
            // btCek
            // 
            this.btCek.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCek.Location = new System.Drawing.Point(224, 450);
            this.btCek.Name = "btCek";
            this.btCek.Size = new System.Drawing.Size(99, 42);
            this.btCek.TabIndex = 11;
            this.btCek.Text = "Cek IMT";
            this.btCek.UseVisualStyleBackColor = true;
            this.btCek.Click += new System.EventHandler(this.btCek_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(339, 450);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(99, 42);
            this.btReset.TabIndex = 12;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(457, 450);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(99, 42);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasil";
            // 
            // txHasil
            // 
            this.txHasil.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHasil.Location = new System.Drawing.Point(215, 290);
            this.txHasil.Multiline = true;
            this.txHasil.Name = "txHasil";
            this.txHasil.Size = new System.Drawing.Size(362, 127);
            this.txHasil.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 529);
            this.Controls.Add(this.txHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCek);
            this.Controls.Add(this.txBerat);
            this.Controls.Add(this.txTinggi);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNama;
        private System.Windows.Forms.TextBox txTinggi;
        private System.Windows.Forms.TextBox txBerat;
        private System.Windows.Forms.Button btCek;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txHasil;
    }
}

