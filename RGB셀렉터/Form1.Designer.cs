namespace RGB셀렉터
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.redScrollBar = new System.Windows.Forms.HScrollBar();
            this.greenScrollBar = new System.Windows.Forms.HScrollBar();
            this.blueScrollBar = new System.Windows.Forms.HScrollBar();
            this.rgbBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redTextBox
            // 
            this.redTextBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.redTextBox.Location = new System.Drawing.Point(168, 9);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(150, 32);
            this.redTextBox.TabIndex = 1;
            this.redTextBox.Text = "0";
            this.redTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxValueChange);
            this.redTextBox.Leave += new System.EventHandler(this.TextBoxFocusOut);
            // 
            // blueTextBox
            // 
            this.blueTextBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.blueTextBox.Location = new System.Drawing.Point(168, 137);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(150, 32);
            this.blueTextBox.TabIndex = 3;
            this.blueTextBox.Text = "0";
            this.blueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxValueChange);
            this.blueTextBox.Leave += new System.EventHandler(this.TextBoxFocusOut);
            // 
            // greenTextBox
            // 
            this.greenTextBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.greenTextBox.Location = new System.Drawing.Point(168, 76);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(150, 32);
            this.greenTextBox.TabIndex = 2;
            this.greenTextBox.Text = "0";
            this.greenTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxValueChange);
            this.greenTextBox.Leave += new System.EventHandler(this.TextBoxFocusOut);
            // 
            // redScrollBar
            // 
            this.redScrollBar.Location = new System.Drawing.Point(16, 41);
            this.redScrollBar.Maximum = 255;
            this.redScrollBar.Name = "redScrollBar";
            this.redScrollBar.Size = new System.Drawing.Size(300, 32);
            this.redScrollBar.TabIndex = 6;
            this.redScrollBar.ValueChanged += new System.EventHandler(this.ScrollBarValueChanged);
            // 
            // greenScrollBar
            // 
            this.greenScrollBar.Location = new System.Drawing.Point(16, 105);
            this.greenScrollBar.Maximum = 255;
            this.greenScrollBar.Name = "greenScrollBar";
            this.greenScrollBar.Size = new System.Drawing.Size(300, 32);
            this.greenScrollBar.TabIndex = 7;
            this.greenScrollBar.ValueChanged += new System.EventHandler(this.ScrollBarValueChanged);
            // 
            // blueScrollBar
            // 
            this.blueScrollBar.Location = new System.Drawing.Point(16, 169);
            this.blueScrollBar.Maximum = 255;
            this.blueScrollBar.Name = "blueScrollBar";
            this.blueScrollBar.Size = new System.Drawing.Size(300, 32);
            this.blueScrollBar.TabIndex = 8;
            this.blueScrollBar.ValueChanged += new System.EventHandler(this.ScrollBarValueChanged);
            // 
            // rgbBox
            // 
            this.rgbBox.Location = new System.Drawing.Point(324, 9);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.Size = new System.Drawing.Size(192, 192);
            this.rgbBox.TabIndex = 9;
            this.rgbBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hexTextBox
            // 
            this.hexTextBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hexTextBox.Location = new System.Drawing.Point(166, 201);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(152, 32);
            this.hexTextBox.TabIndex = 4;
            this.hexTextBox.Text = "#000000";
            this.hexTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxValueChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::RGB셀렉터.Properties.Resources.eyedropper;
            this.pictureBox1.Location = new System.Drawing.Point(485, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rgbBox);
            this.Controls.Add(this.blueScrollBar);
            this.Controls.Add(this.greenScrollBar);
            this.Controls.Add(this.redScrollBar);
            this.Controls.Add(this.greenTextBox);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGBSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.rgbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.HScrollBar redScrollBar;
        private System.Windows.Forms.HScrollBar greenScrollBar;
        private System.Windows.Forms.HScrollBar blueScrollBar;
        private System.Windows.Forms.PictureBox rgbBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

