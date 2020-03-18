namespace Twofish_krypto
{
    partial class Steps
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
            this.InputData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultFileWay = new System.Windows.Forms.TextBox();
            this.DoCalculations = new System.Windows.Forms.Button();
            this.InputKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "how does it work";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "INPUT DATA (128 bits)";
            // 
            // InputData
            // 
            this.InputData.Location = new System.Drawing.Point(12, 76);
            this.InputData.Multiline = true;
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(436, 27);
            this.InputData.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "RESULT FILE";
            // 
            // ResultFileWay
            // 
            this.ResultFileWay.Location = new System.Drawing.Point(12, 210);
            this.ResultFileWay.Multiline = true;
            this.ResultFileWay.Name = "ResultFileWay";
            this.ResultFileWay.Size = new System.Drawing.Size(436, 27);
            this.ResultFileWay.TabIndex = 4;
            // 
            // DoCalculations
            // 
            this.DoCalculations.BackColor = System.Drawing.Color.Plum;
            this.DoCalculations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoCalculations.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.DoCalculations.Location = new System.Drawing.Point(147, 243);
            this.DoCalculations.Name = "DoCalculations";
            this.DoCalculations.Size = new System.Drawing.Size(160, 58);
            this.DoCalculations.TabIndex = 5;
            this.DoCalculations.Text = "Show me";
            this.DoCalculations.UseVisualStyleBackColor = false;
            this.DoCalculations.Click += new System.EventHandler(this.DoCalculations_Click);
            // 
            // InputKey
            // 
            this.InputKey.Location = new System.Drawing.Point(12, 143);
            this.InputKey.Multiline = true;
            this.InputKey.Name = "InputKey";
            this.InputKey.Size = new System.Drawing.Size(436, 27);
            this.InputKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "key length (128/196/256 bits)";
            // 
            // Steps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(460, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputKey);
            this.Controls.Add(this.DoCalculations);
            this.Controls.Add(this.ResultFileWay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Steps";
            this.Text = "Steps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultFileWay;
        private System.Windows.Forms.Button DoCalculations;
        private System.Windows.Forms.TextBox InputKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}