namespace HashProp
{
    partial class HashWindow
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
            this.CalcSha512 = new System.Windows.Forms.Button();
            this.Sha512Output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcSha256 = new System.Windows.Forms.Button();
            this.Sha256Output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcSha1 = new System.Windows.Forms.Button();
            this.Sha1Output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcMd5 = new System.Windows.Forms.Button();
            this.Md5Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcSha512
            // 
            this.CalcSha512.Location = new System.Drawing.Point(259, 256);
            this.CalcSha512.Name = "CalcSha512";
            this.CalcSha512.Size = new System.Drawing.Size(75, 26);
            this.CalcSha512.TabIndex = 19;
            this.CalcSha512.Text = "Calculate";
            this.CalcSha512.UseVisualStyleBackColor = true;
            this.CalcSha512.Click += new System.EventHandler(this.CalcSha512_Click);
            // 
            // Sha512Output
            // 
            this.Sha512Output.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Sha512Output.Location = new System.Drawing.Point(3, 256);
            this.Sha512Output.Multiline = true;
            this.Sha512Output.Name = "Sha512Output";
            this.Sha512Output.ReadOnly = true;
            this.Sha512Output.Size = new System.Drawing.Size(250, 100);
            this.Sha512Output.TabIndex = 20;
            this.Sha512Output.Enter += new System.EventHandler(this.HashOutput_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "SHA512:";
            // 
            // CalcSha256
            // 
            this.CalcSha256.Location = new System.Drawing.Point(259, 165);
            this.CalcSha256.Name = "CalcSha256";
            this.CalcSha256.Size = new System.Drawing.Size(75, 26);
            this.CalcSha256.TabIndex = 16;
            this.CalcSha256.Text = "Calculate";
            this.CalcSha256.UseVisualStyleBackColor = true;
            this.CalcSha256.Click += new System.EventHandler(this.CalcSha256_Click);
            // 
            // Sha256Output
            // 
            this.Sha256Output.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Sha256Output.Location = new System.Drawing.Point(3, 165);
            this.Sha256Output.Multiline = true;
            this.Sha256Output.Name = "Sha256Output";
            this.Sha256Output.ReadOnly = true;
            this.Sha256Output.Size = new System.Drawing.Size(250, 63);
            this.Sha256Output.TabIndex = 17;
            this.Sha256Output.Enter += new System.EventHandler(this.HashOutput_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "SHA256:";
            // 
            // CalcSha1
            // 
            this.CalcSha1.Location = new System.Drawing.Point(259, 90);
            this.CalcSha1.Name = "CalcSha1";
            this.CalcSha1.Size = new System.Drawing.Size(75, 26);
            this.CalcSha1.TabIndex = 13;
            this.CalcSha1.Text = "Calculate";
            this.CalcSha1.UseVisualStyleBackColor = true;
            this.CalcSha1.Click += new System.EventHandler(this.CalcSha1_Click);
            // 
            // Sha1Output
            // 
            this.Sha1Output.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.Sha1Output.Location = new System.Drawing.Point(3, 90);
            this.Sha1Output.Multiline = true;
            this.Sha1Output.Name = "Sha1Output";
            this.Sha1Output.ReadOnly = true;
            this.Sha1Output.Size = new System.Drawing.Size(250, 44);
            this.Sha1Output.TabIndex = 15;
            this.Sha1Output.Enter += new System.EventHandler(this.HashOutput_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "SHA1:";
            // 
            // CalcMd5
            // 
            this.CalcMd5.Location = new System.Drawing.Point(259, 17);
            this.CalcMd5.Name = "CalcMd5";
            this.CalcMd5.Size = new System.Drawing.Size(75, 26);
            this.CalcMd5.TabIndex = 11;
            this.CalcMd5.Text = "Calculate";
            this.CalcMd5.UseVisualStyleBackColor = true;
            this.CalcMd5.Click += new System.EventHandler(this.CalcMd5_Click);
            // 
            // Md5Output
            // 
            this.Md5Output.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Md5Output.Location = new System.Drawing.Point(3, 18);
            this.Md5Output.Multiline = true;
            this.Md5Output.Name = "Md5Output";
            this.Md5Output.ReadOnly = true;
            this.Md5Output.Size = new System.Drawing.Size(250, 44);
            this.Md5Output.TabIndex = 12;
            this.Md5Output.Enter += new System.EventHandler(this.HashOutput_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "MD5:";
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Location = new System.Drawing.Point(0, 365);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(70, 13);
            this.AboutLabel.TabIndex = 22;
            this.AboutLabel.Text = "HashProp vX";
            // 
            // HashWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 387);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.CalcSha512);
            this.Controls.Add(this.Sha512Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalcSha256);
            this.Controls.Add(this.Sha256Output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalcSha1);
            this.Controls.Add(this.Sha1Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcMd5);
            this.Controls.Add(this.Md5Output);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HashWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hashes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcSha512;
        private System.Windows.Forms.TextBox Sha512Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcSha256;
        private System.Windows.Forms.TextBox Sha256Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalcSha1;
        private System.Windows.Forms.TextBox Sha1Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcMd5;
        private System.Windows.Forms.TextBox Md5Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AboutLabel;

    }
}