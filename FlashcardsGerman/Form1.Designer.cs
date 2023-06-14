namespace FlashcardsGerman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxTranslate = new System.Windows.Forms.PictureBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxUkrTranslate = new System.Windows.Forms.GroupBox();
            this.groupBoxEmgTranslate = new System.Windows.Forms.GroupBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.labelUkrTranslate = new System.Windows.Forms.Label();
            this.labelEngTranslate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTranslate)).BeginInit();
            this.groupBoxUkrTranslate.SuspendLayout();
            this.groupBoxEmgTranslate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.buttonTranslate);
            this.groupBox1.Controls.Add(this.groupBoxEmgTranslate);
            this.groupBox1.Controls.Add(this.groupBoxUkrTranslate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxWord);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBoxTranslate);
            this.groupBox2.Controls.Add(this.pictureBoxImage);
            this.groupBox2.Location = new System.Drawing.Point(291, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 514);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(166, 19);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // pictureBoxTranslate
            // 
            this.pictureBoxTranslate.Location = new System.Drawing.Point(166, 308);
            this.pictureBoxTranslate.Name = "pictureBoxTranslate";
            this.pictureBoxTranslate.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxTranslate.TabIndex = 0;
            this.pictureBoxTranslate.TabStop = false;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(6, 40);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(261, 20);
            this.textBoxWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input word in german";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Translation into ukrainian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Translation into english";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "IMAGE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "TRANSLATION";
            // 
            // groupBoxUkrTranslate
            // 
            this.groupBoxUkrTranslate.Controls.Add(this.labelUkrTranslate);
            this.groupBoxUkrTranslate.Location = new System.Drawing.Point(6, 135);
            this.groupBoxUkrTranslate.Name = "groupBoxUkrTranslate";
            this.groupBoxUkrTranslate.Size = new System.Drawing.Size(262, 46);
            this.groupBoxUkrTranslate.TabIndex = 5;
            this.groupBoxUkrTranslate.TabStop = false;
            // 
            // groupBoxEmgTranslate
            // 
            this.groupBoxEmgTranslate.Controls.Add(this.labelEngTranslate);
            this.groupBoxEmgTranslate.Location = new System.Drawing.Point(6, 200);
            this.groupBoxEmgTranslate.Name = "groupBoxEmgTranslate";
            this.groupBoxEmgTranslate.Size = new System.Drawing.Size(262, 51);
            this.groupBoxEmgTranslate.TabIndex = 6;
            this.groupBoxEmgTranslate.TabStop = false;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(92, 66);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslate.TabIndex = 7;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            // 
            // labelUkrTranslate
            // 
            this.labelUkrTranslate.AutoSize = true;
            this.labelUkrTranslate.Location = new System.Drawing.Point(6, 16);
            this.labelUkrTranslate.Name = "labelUkrTranslate";
            this.labelUkrTranslate.Size = new System.Drawing.Size(0, 13);
            this.labelUkrTranslate.TabIndex = 0;
            // 
            // labelEngTranslate
            // 
            this.labelEngTranslate.AutoSize = true;
            this.labelEngTranslate.Location = new System.Drawing.Point(7, 20);
            this.labelEngTranslate.Name = "labelEngTranslate";
            this.labelEngTranslate.Size = new System.Drawing.Size(0, 13);
            this.labelEngTranslate.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flashcards";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTranslate)).EndInit();
            this.groupBoxUkrTranslate.ResumeLayout(false);
            this.groupBoxUkrTranslate.PerformLayout();
            this.groupBoxEmgTranslate.ResumeLayout(false);
            this.groupBoxEmgTranslate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxTranslate;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxEmgTranslate;
        private System.Windows.Forms.GroupBox groupBoxUkrTranslate;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Label labelUkrTranslate;
        private System.Windows.Forms.Label labelEngTranslate;
    }
}

