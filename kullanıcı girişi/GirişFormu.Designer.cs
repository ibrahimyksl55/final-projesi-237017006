namespace kullanıcı_girişi
{
    partial class GirişFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblkadi = new System.Windows.Forms.Label();
            this.lblparola = new System.Windows.Forms.Label();
            this.txtbkadı = new System.Windows.Forms.TextBox();
            this.txtbparola = new System.Windows.Forms.TextBox();
            this.btngiriş = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblkadi
            // 
            this.lblkadi.AutoSize = true;
            this.lblkadi.Location = new System.Drawing.Point(12, 24);
            this.lblkadi.Name = "lblkadi";
            this.lblkadi.Size = new System.Drawing.Size(64, 13);
            this.lblkadi.TabIndex = 0;
            this.lblkadi.Text = "Kullanıcı Adı";
            // 
            // lblparola
            // 
            this.lblparola.AutoSize = true;
            this.lblparola.Location = new System.Drawing.Point(39, 74);
            this.lblparola.Name = "lblparola";
            this.lblparola.Size = new System.Drawing.Size(37, 13);
            this.lblparola.TabIndex = 1;
            this.lblparola.Text = "Parola";
            // 
            // txtbkadı
            // 
            this.txtbkadı.Location = new System.Drawing.Point(125, 24);
            this.txtbkadı.Name = "txtbkadı";
            this.txtbkadı.Size = new System.Drawing.Size(100, 20);
            this.txtbkadı.TabIndex = 2;
            // 
            // txtbparola
            // 
            this.txtbparola.Location = new System.Drawing.Point(125, 71);
            this.txtbparola.Name = "txtbparola";
            this.txtbparola.PasswordChar = '*';
            this.txtbparola.Size = new System.Drawing.Size(100, 20);
            this.txtbparola.TabIndex = 2;
            // 
            // btngiriş
            // 
            this.btngiriş.Location = new System.Drawing.Point(15, 113);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(75, 23);
            this.btngiriş.TabIndex = 3;
            this.btngiriş.Text = "giriş";
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(150, 113);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 3;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // GirişFormu
            // 
            this.AcceptButton = this.btngiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(272, 182);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.txtbparola);
            this.Controls.Add(this.txtbkadı);
            this.Controls.Add(this.lblparola);
            this.Controls.Add(this.lblkadi);
            this.Name = "GirişFormu";
            this.Text = "YETKİLİ GİRİŞİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkadi;
        private System.Windows.Forms.Label lblparola;
        private System.Windows.Forms.TextBox txtbkadı;
        private System.Windows.Forms.TextBox txtbparola;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.Button btniptal;
    }
}

