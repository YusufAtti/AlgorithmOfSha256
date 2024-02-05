namespace AlgorithmOfSha
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusename = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnsign = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtusename
            // 
            this.txtusename.Location = new System.Drawing.Point(164, 66);
            this.txtusename.Name = "txtusename";
            this.txtusename.Size = new System.Drawing.Size(156, 27);
            this.txtusename.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(164, 137);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(156, 27);
            this.txtpass.TabIndex = 3;
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsign.Location = new System.Drawing.Point(214, 201);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(143, 50);
            this.btnsign.TabIndex = 4;
            this.btnsign.Text = "Sign Up";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.Goldenrod;
            this.btnlog.Location = new System.Drawing.Point(41, 201);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(143, 50);
            this.btnlog.TabIndex = 5;
            this.btnlog.Text = "Log In";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 303);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusename;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Button btnlog;
    }
}

