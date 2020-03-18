namespace Twofish_krypto
{
    partial class Decryption
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
            this.Decypher = new System.Windows.Forms.Button();
            this.ChooseWhere = new System.Windows.Forms.Button();
            this.WayTo = new System.Windows.Forms.TextBox();
            this.WayFrom = new System.Windows.Forms.TextBox();
            this.ChooseFrom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyWay = new System.Windows.Forms.TextBox();
            this.ChooseKey = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Decypher
            // 
            this.Decypher.BackColor = System.Drawing.Color.Plum;
            this.Decypher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decypher.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decypher.Location = new System.Drawing.Point(138, 207);
            this.Decypher.Name = "Decypher";
            this.Decypher.Size = new System.Drawing.Size(170, 94);
            this.Decypher.TabIndex = 11;
            this.Decypher.Text = "Run";
            this.Decypher.UseVisualStyleBackColor = false;
            this.Decypher.Click += new System.EventHandler(this.Decypher_Click);
            // 
            // ChooseWhere
            // 
            this.ChooseWhere.BackColor = System.Drawing.Color.Plum;
            this.ChooseWhere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseWhere.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.ChooseWhere.Location = new System.Drawing.Point(339, 110);
            this.ChooseWhere.Name = "ChooseWhere";
            this.ChooseWhere.Size = new System.Drawing.Size(109, 30);
            this.ChooseWhere.TabIndex = 10;
            this.ChooseWhere.Text = "Choose where";
            this.ChooseWhere.UseVisualStyleBackColor = false;
            this.ChooseWhere.Click += new System.EventHandler(this.ChooseWhere_Click);
            // 
            // WayTo
            // 
            this.WayTo.Location = new System.Drawing.Point(12, 110);
            this.WayTo.Multiline = true;
            this.WayTo.Name = "WayTo";
            this.WayTo.Size = new System.Drawing.Size(312, 30);
            this.WayTo.TabIndex = 9;
            // 
            // WayFrom
            // 
            this.WayFrom.Location = new System.Drawing.Point(12, 62);
            this.WayFrom.Multiline = true;
            this.WayFrom.Name = "WayFrom";
            this.WayFrom.Size = new System.Drawing.Size(312, 30);
            this.WayFrom.TabIndex = 8;
            // 
            // ChooseFrom
            // 
            this.ChooseFrom.BackColor = System.Drawing.Color.Plum;
            this.ChooseFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseFrom.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.ChooseFrom.Location = new System.Drawing.Point(339, 62);
            this.ChooseFrom.Name = "ChooseFrom";
            this.ChooseFrom.Size = new System.Drawing.Size(109, 30);
            this.ChooseFrom.TabIndex = 7;
            this.ChooseFrom.Text = "Choose from";
            this.ChooseFrom.UseVisualStyleBackColor = false;
            this.ChooseFrom.Click += new System.EventHandler(this.ChooseFrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Decryption";
            // 
            // KeyWay
            // 
            this.KeyWay.Location = new System.Drawing.Point(12, 157);
            this.KeyWay.Multiline = true;
            this.KeyWay.Name = "KeyWay";
            this.KeyWay.Size = new System.Drawing.Size(312, 30);
            this.KeyWay.TabIndex = 12;
            // 
            // ChooseKey
            // 
            this.ChooseKey.BackColor = System.Drawing.Color.Plum;
            this.ChooseKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseKey.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.ChooseKey.Location = new System.Drawing.Point(339, 157);
            this.ChooseKey.Name = "ChooseKey";
            this.ChooseKey.Size = new System.Drawing.Size(109, 30);
            this.ChooseKey.TabIndex = 13;
            this.ChooseKey.Text = "Choose key";
            this.ChooseKey.UseVisualStyleBackColor = false;
            this.ChooseKey.Click += new System.EventHandler(this.ChooseKey_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(460, 313);
            this.Controls.Add(this.ChooseKey);
            this.Controls.Add(this.KeyWay);
            this.Controls.Add(this.Decypher);
            this.Controls.Add(this.ChooseWhere);
            this.Controls.Add(this.WayTo);
            this.Controls.Add(this.WayFrom);
            this.Controls.Add(this.ChooseFrom);
            this.Controls.Add(this.label1);
            this.Name = "Decryption";
            this.Text = "Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Decypher;
        private System.Windows.Forms.Button ChooseWhere;
        private System.Windows.Forms.TextBox WayTo;
        private System.Windows.Forms.TextBox WayFrom;
        private System.Windows.Forms.Button ChooseFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyWay;
        private System.Windows.Forms.Button ChooseKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}