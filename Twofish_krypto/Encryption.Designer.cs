namespace Twofish_krypto
{
    partial class Encryption
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
            this.ChooseFrom = new System.Windows.Forms.Button();
            this.WayFrom = new System.Windows.Forms.TextBox();
            this.WayTo = new System.Windows.Forms.TextBox();
            this.ChooseWhere = new System.Windows.Forms.Button();
            this.Encode = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            // 
            // ChooseFrom
            // 
            this.ChooseFrom.BackColor = System.Drawing.Color.Plum;
            this.ChooseFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseFrom.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.ChooseFrom.Location = new System.Drawing.Point(339, 80);
            this.ChooseFrom.Name = "ChooseFrom";
            this.ChooseFrom.Size = new System.Drawing.Size(109, 30);
            this.ChooseFrom.TabIndex = 1;
            this.ChooseFrom.Text = "Choose from";
            this.ChooseFrom.UseVisualStyleBackColor = false;
            this.ChooseFrom.Click += new System.EventHandler(this.ChooseFrom_Click);
            // 
            // WayFrom
            // 
            this.WayFrom.Location = new System.Drawing.Point(12, 80);
            this.WayFrom.Multiline = true;
            this.WayFrom.Name = "WayFrom";
            this.WayFrom.Size = new System.Drawing.Size(312, 30);
            this.WayFrom.TabIndex = 2;
            // 
            // WayTo
            // 
            this.WayTo.Location = new System.Drawing.Point(12, 147);
            this.WayTo.Multiline = true;
            this.WayTo.Name = "WayTo";
            this.WayTo.Size = new System.Drawing.Size(312, 30);
            this.WayTo.TabIndex = 3;
            // 
            // ChooseWhere
            // 
            this.ChooseWhere.BackColor = System.Drawing.Color.Plum;
            this.ChooseWhere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseWhere.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.ChooseWhere.Location = new System.Drawing.Point(339, 147);
            this.ChooseWhere.Name = "ChooseWhere";
            this.ChooseWhere.Size = new System.Drawing.Size(109, 30);
            this.ChooseWhere.TabIndex = 4;
            this.ChooseWhere.Text = "Choose where";
            this.ChooseWhere.UseVisualStyleBackColor = false;
            this.ChooseWhere.Click += new System.EventHandler(this.ChooseWhere_Click);
            // 
            // Encode
            // 
            this.Encode.BackColor = System.Drawing.Color.Plum;
            this.Encode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Encode.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encode.Location = new System.Drawing.Point(140, 207);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(170, 94);
            this.Encode.TabIndex = 5;
            this.Encode.Text = "Run";
            this.Encode.UseVisualStyleBackColor = false;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(460, 313);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.ChooseWhere);
            this.Controls.Add(this.WayTo);
            this.Controls.Add(this.WayFrom);
            this.Controls.Add(this.ChooseFrom);
            this.Controls.Add(this.label1);
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChooseFrom;
        private System.Windows.Forms.TextBox WayFrom;
        private System.Windows.Forms.TextBox WayTo;
        private System.Windows.Forms.Button ChooseWhere;
        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}