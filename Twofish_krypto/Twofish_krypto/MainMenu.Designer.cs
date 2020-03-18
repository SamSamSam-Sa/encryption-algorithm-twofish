namespace Twofish_krypto
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Steps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twofish\r\nalgorythm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.Plum;
            this.Encrypt.FlatAppearance.BorderSize = 0;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Encrypt.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.Location = new System.Drawing.Point(50, 76);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(93, 54);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.Text = "To encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Plum;
            this.Decrypt.FlatAppearance.BorderSize = 0;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decrypt.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.Decrypt.Location = new System.Drawing.Point(183, 150);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(93, 54);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "To decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Steps
            // 
            this.Steps.BackColor = System.Drawing.Color.Plum;
            this.Steps.FlatAppearance.BorderSize = 0;
            this.Steps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Steps.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.Steps.Location = new System.Drawing.Point(316, 231);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(93, 54);
            this.Steps.TabIndex = 3;
            this.Steps.Text = "To show\r\nstep by step";
            this.Steps.UseVisualStyleBackColor = false;
            this.Steps.Click += new System.EventHandler(this.Steps_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(460, 313);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Twofish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Steps;
    }
}

