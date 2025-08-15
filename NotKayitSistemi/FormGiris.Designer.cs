namespace NotKayitSistemi
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
            this.mskTxtNumara = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numara:";
            // 
            // mskTxtNumara
            // 
            this.mskTxtNumara.Location = new System.Drawing.Point(275, 89);
            this.mskTxtNumara.Mask = "0000";
            this.mskTxtNumara.Name = "mskTxtNumara";
            this.mskTxtNumara.Size = new System.Drawing.Size(187, 34);
            this.mskTxtNumara.TabIndex = 1;
            this.mskTxtNumara.ValidatingType = typeof(int);
            this.mskTxtNumara.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTxtNumara_MaskInputRejected);
            this.mskTxtNumara.TextChanged += new System.EventHandler(this.mskTxtNumara_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(674, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskTxtNumara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTxtNumara;
        private System.Windows.Forms.Button button1;
    }
}

