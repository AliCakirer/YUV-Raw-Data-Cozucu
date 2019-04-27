namespace yazlab3
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
            this.components = new System.ComponentModel.Container();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnCevir = new System.Windows.Forms.Button();
            this.radioButton444 = new System.Windows.Forms.RadioButton();
            this.radioButton422 = new System.Windows.Forms.RadioButton();
            this.radioButton420 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAyikla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxWidth = new System.Windows.Forms.TextBox();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboxFps = new System.Windows.Forms.ComboBox();
            this.btnKaydetAll = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOynat = new System.Windows.Forms.Button();
            this.txtBoxCurrentFrame = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(12, 23);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(130, 49);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Dosya Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(12, 410);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(130, 49);
            this.btnCevir.TabIndex = 1;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // radioButton444
            // 
            this.radioButton444.AutoSize = true;
            this.radioButton444.Location = new System.Drawing.Point(12, 113);
            this.radioButton444.Name = "radioButton444";
            this.radioButton444.Size = new System.Drawing.Size(61, 21);
            this.radioButton444.TabIndex = 2;
            this.radioButton444.TabStop = true;
            this.radioButton444.Text = "4:4:4";
            this.radioButton444.UseVisualStyleBackColor = true;
            this.radioButton444.CheckedChanged += new System.EventHandler(this.radioButton444_CheckedChanged);
            // 
            // radioButton422
            // 
            this.radioButton422.AutoSize = true;
            this.radioButton422.Location = new System.Drawing.Point(12, 149);
            this.radioButton422.Name = "radioButton422";
            this.radioButton422.Size = new System.Drawing.Size(61, 21);
            this.radioButton422.TabIndex = 3;
            this.radioButton422.TabStop = true;
            this.radioButton422.Text = "4:2:2";
            this.radioButton422.UseVisualStyleBackColor = true;
            this.radioButton422.CheckedChanged += new System.EventHandler(this.radioButton422_CheckedChanged);
            // 
            // radioButton420
            // 
            this.radioButton420.AutoSize = true;
            this.radioButton420.Location = new System.Drawing.Point(12, 186);
            this.radioButton420.Name = "radioButton420";
            this.radioButton420.Size = new System.Drawing.Size(61, 21);
            this.radioButton420.TabIndex = 4;
            this.radioButton420.TabStop = true;
            this.radioButton420.Text = "4:2:0";
            this.radioButton420.UseVisualStyleBackColor = true;
            this.radioButton420.CheckedChanged += new System.EventHandler(this.radioButton420_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAyikla
            // 
            this.btnAyikla.Location = new System.Drawing.Point(12, 344);
            this.btnAyikla.Name = "btnAyikla";
            this.btnAyikla.Size = new System.Drawing.Size(130, 49);
            this.btnAyikla.TabIndex = 5;
            this.btnAyikla.Text = "Ayıkla";
            this.btnAyikla.UseVisualStyleBackColor = true;
            this.btnAyikla.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yükseklik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genişlik";
            // 
            // txtBoxWidth
            // 
            this.txtBoxWidth.Location = new System.Drawing.Point(12, 259);
            this.txtBoxWidth.Name = "txtBoxWidth";
            this.txtBoxWidth.Size = new System.Drawing.Size(64, 22);
            this.txtBoxWidth.TabIndex = 8;
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(12, 304);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(64, 22);
            this.txtBoxHeight.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 478);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 49);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Seçili Frame Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "FPS:";
            // 
            // cmboxFps
            // 
            this.cmboxFps.FormattingEnabled = true;
            this.cmboxFps.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cmboxFps.Location = new System.Drawing.Point(310, 16);
            this.cmboxFps.Name = "cmboxFps";
            this.cmboxFps.Size = new System.Drawing.Size(52, 24);
            this.cmboxFps.TabIndex = 15;
            this.cmboxFps.SelectedIndexChanged += new System.EventHandler(this.cmboxFps_SelectedIndexChanged);
            // 
            // btnKaydetAll
            // 
            this.btnKaydetAll.Location = new System.Drawing.Point(12, 544);
            this.btnKaydetAll.Name = "btnKaydetAll";
            this.btnKaydetAll.Size = new System.Drawing.Size(130, 49);
            this.btnKaydetAll.TabIndex = 16;
            this.btnKaydetAll.Text = "Frame Dizilerini Kaydet";
            this.btnKaydetAll.UseVisualStyleBackColor = true;
            this.btnKaydetAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackgroundImage = global::yazlab3.Properties.Resources.sol;
            this.btnSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSol.Location = new System.Drawing.Point(12, 740);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(66, 49);
            this.btnSol.TabIndex = 18;
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.BackgroundImage = global::yazlab3.Properties.Resources.sag;
            this.btnSag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSag.Location = new System.Drawing.Point(76, 740);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(66, 49);
            this.btnSag.TabIndex = 17;
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackgroundImage = global::yazlab3.Properties.Resources.durdur;
            this.btnDurdur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDurdur.Location = new System.Drawing.Point(17, 599);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(56, 49);
            this.btnDurdur.TabIndex = 12;
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(269, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnOynat
            // 
            this.btnOynat.BackgroundImage = global::yazlab3.Properties.Resources.baslat_;
            this.btnOynat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOynat.Location = new System.Drawing.Point(86, 599);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(56, 49);
            this.btnOynat.TabIndex = 10;
            this.btnOynat.UseVisualStyleBackColor = true;
            this.btnOynat.Click += new System.EventHandler(this.btnOynat_Click);
            // 
            // txtBoxCurrentFrame
            // 
            this.txtBoxCurrentFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxCurrentFrame.Location = new System.Drawing.Point(17, 654);
            this.txtBoxCurrentFrame.Multiline = true;
            this.txtBoxCurrentFrame.Name = "txtBoxCurrentFrame";
            this.txtBoxCurrentFrame.Size = new System.Drawing.Size(56, 49);
            this.txtBoxCurrentFrame.TabIndex = 19;
            this.txtBoxCurrentFrame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxCurrentFrame_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1581, 1008);
            this.Controls.Add(this.txtBoxCurrentFrame);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnKaydetAll);
            this.Controls.Add(this.cmboxFps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.txtBoxWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyikla);
            this.Controls.Add(this.radioButton420);
            this.Controls.Add(this.radioButton422);
            this.Controls.Add(this.radioButton444);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.btnSec);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.RadioButton radioButton444;
        private System.Windows.Forms.RadioButton radioButton422;
        private System.Windows.Forms.RadioButton radioButton420;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAyikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxWidth;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOynat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboxFps;
        private System.Windows.Forms.Button btnKaydetAll;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.TextBox txtBoxCurrentFrame;
    }
}

