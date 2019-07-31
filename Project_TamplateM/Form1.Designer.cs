namespace Project_TamplateM
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.info_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbRes = new System.Windows.Forms.Label();
            this.PictureName = new System.Windows.Forms.Label();
            this.PicTemplate = new System.Windows.Forms.PictureBox();
            this.PictureInput = new System.Windows.Forms.PictureBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnTamplate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.info_btn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbRes);
            this.groupBox1.Controls.Add(this.PictureName);
            this.groupBox1.Controls.Add(this.PicTemplate);
            this.groupBox1.Controls.Add(this.PictureInput);
            this.groupBox1.Controls.Add(this.btnMatch);
            this.groupBox1.Controls.Add(this.btnTamplate);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamplate Matching";
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(643, 10);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(50, 20);
            this.info_btn.TabIndex = 13;
            this.info_btn.Text = "Info";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(353, 31);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(80, 13);
            this.lbRes.TabIndex = 10;
            this.lbRes.Text = "Second Picture";
            // 
            // PictureName
            // 
            this.PictureName.AutoSize = true;
            this.PictureName.Location = new System.Drawing.Point(10, 31);
            this.PictureName.Name = "PictureName";
            this.PictureName.Size = new System.Drawing.Size(66, 13);
            this.PictureName.TabIndex = 9;
            this.PictureName.Text = "Main Picture";
            // 
            // PicTemplate
            // 
            this.PicTemplate.Location = new System.Drawing.Point(356, 47);
            this.PicTemplate.Name = "PicTemplate";
            this.PicTemplate.Size = new System.Drawing.Size(329, 268);
            this.PicTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTemplate.TabIndex = 8;
            this.PicTemplate.TabStop = false;
            // 
            // PictureInput
            // 
            this.PictureInput.Location = new System.Drawing.Point(13, 47);
            this.PictureInput.Name = "PictureInput";
            this.PictureInput.Size = new System.Drawing.Size(318, 268);
            this.PictureInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureInput.TabIndex = 7;
            this.PictureInput.TabStop = false;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(617, 361);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(68, 20);
            this.btnMatch.TabIndex = 6;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnTamplate
            // 
            this.btnTamplate.Location = new System.Drawing.Point(356, 319);
            this.btnTamplate.Name = "btnTamplate";
            this.btnTamplate.Size = new System.Drawing.Size(98, 20);
            this.btnTamplate.TabIndex = 5;
            this.btnTamplate.Text = "Select Tamplate";
            this.btnTamplate.UseVisualStyleBackColor = true;
            this.btnTamplate.Click += new System.EventHandler(this.btnTamplate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 319);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 20);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Select Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 416);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Tamplate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnTamplate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox PicTemplate;
        private System.Windows.Forms.PictureBox PictureInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Label PictureName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button info_btn;
    }
}

