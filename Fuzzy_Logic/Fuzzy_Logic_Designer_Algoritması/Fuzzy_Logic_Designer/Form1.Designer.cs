namespace Fuzzy_Logic_Designer
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
            this.input2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.output1 = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.RadioButton();
            this.OR = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agirlikliortalama_1 = new System.Windows.Forms.RadioButton();
            this.maksimumortalama_1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.input2.Location = new System.Drawing.Point(44, 34);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(170, 96);
            this.input2.TabIndex = 1;
            this.input2.Text = "Giriş";
            this.input2.UseVisualStyleBackColor = false;
            this.input2.Click += new System.EventHandler(this.input2_Click);
            // 
            // output1
            // 
            this.output1.BackColor = System.Drawing.Color.DarkMagenta;
            this.output1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.output1.Location = new System.Drawing.Point(280, 34);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(170, 96);
            this.output1.TabIndex = 8;
            this.output1.Text = "Çıkış";
            this.output1.UseVisualStyleBackColor = false;
            this.output1.Click += new System.EventHandler(this.output1_Click);
            // 
            // AND
            // 
            this.AND.AutoSize = true;
            this.AND.BackColor = System.Drawing.Color.Transparent;
            this.AND.ForeColor = System.Drawing.Color.Black;
            this.AND.Location = new System.Drawing.Point(6, 19);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(48, 17);
            this.AND.TabIndex = 9;
            this.AND.TabStop = true;
            this.AND.Text = "AND";
            this.AND.UseVisualStyleBackColor = false;
            // 
            // OR
            // 
            this.OR.AutoSize = true;
            this.OR.ForeColor = System.Drawing.Color.Black;
            this.OR.Location = new System.Drawing.Point(6, 42);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(41, 17);
            this.OR.TabIndex = 10;
            this.OR.TabStop = true;
            this.OR.Text = "OR";
            this.OR.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AND);
            this.groupBox1.Controls.Add(this.OR);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(172, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // agirlikliortalama_1
            // 
            this.agirlikliortalama_1.AutoSize = true;
            this.agirlikliortalama_1.Location = new System.Drawing.Point(6, 19);
            this.agirlikliortalama_1.Name = "agirlikliortalama_1";
            this.agirlikliortalama_1.Size = new System.Drawing.Size(56, 17);
            this.agirlikliortalama_1.TabIndex = 11;
            this.agirlikliortalama_1.TabStop = true;
            this.agirlikliortalama_1.Text = "ağırlıklı";
            this.agirlikliortalama_1.UseVisualStyleBackColor = true;
            // 
            // maksimumortalama_1
            // 
            this.maksimumortalama_1.AutoSize = true;
            this.maksimumortalama_1.Location = new System.Drawing.Point(6, 42);
            this.maksimumortalama_1.Name = "maksimumortalama_1";
            this.maksimumortalama_1.Size = new System.Drawing.Size(74, 17);
            this.maksimumortalama_1.TabIndex = 12;
            this.maksimumortalama_1.TabStop = true;
            this.maksimumortalama_1.Text = "maksimum";
            this.maksimumortalama_1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maksimumortalama_1);
            this.groupBox2.Controls.Add(this.agirlikliortalama_1);
            this.groupBox2.Location = new System.Drawing.Point(44, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 95);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(499, 320);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.input2);
            this.Name = "Form1";
            this.Text = "Fuzzy Logic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button input2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button output1;
        private System.Windows.Forms.RadioButton AND;
        private System.Windows.Forms.RadioButton OR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton agirlikliortalama_1;
        private System.Windows.Forms.RadioButton maksimumortalama_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

