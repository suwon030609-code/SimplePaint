namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            cmbColor = new ComboBox();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            picCanvas = new PictureBox();
            pnlCanvasContainer = new Panel();
            btnZoomIn = new Button();
            btnZoomOut = new Button();
            lblZoom = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            pnlCanvasContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Verdana", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.DeepSkyBlue;
            lblAppName.Location = new Point(51, 33);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(569, 91);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black", "Red", "Blue", "Green" });
            cmbColor.Location = new Point(26, 88);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(242, 40);
            cmbColor.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(51, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 200);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형선택";
            // 
            // btnCircle
            // 
            btnCircle.FlatStyle = FlatStyle.Flat;
            btnCircle.ForeColor = SystemColors.ActiveCaptionText;
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.Location = new Point(318, 56);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(110, 110);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.BackgroundImageLayout = ImageLayout.None;
            btnRectangle.FlatStyle = FlatStyle.Flat;
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.Location = new Point(174, 56);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(110, 110);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnLine
            // 
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(34, 56);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(110, 110);
            btnLine.TabIndex = 0;
            btnLine.TabStop = false;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(527, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 200);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblZoom);
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(855, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(360, 200);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(32, 76);
            trbLineWidth.Minimum = 1;
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(306, 90);
            trbLineWidth.TabIndex = 0;
            trbLineWidth.Value = 2;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = SystemColors.Info;
            btnOpenFile.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(1237, 179);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(130, 80);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.OliveDrab;
            btnSaveFile.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(1398, 179);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(130, 80);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(0, 0);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1475, 548);
            picCanvas.TabIndex = 7;
            picCanvas.TabStop = false;
            // 
            // pnlCanvasContainer
            // 
            pnlCanvasContainer.AutoScroll = true;
            pnlCanvasContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvasContainer.Controls.Add(picCanvas);
            pnlCanvasContainer.Location = new Point(51, 367);
            pnlCanvasContainer.Name = "pnlCanvasContainer";
            pnlCanvasContainer.Size = new Size(1477, 550);
            pnlCanvasContainer.TabIndex = 8;
            // 
            // btnZoomIn
            // 
            btnZoomIn.BackColor = Color.FromArgb(128, 128, 255);
            btnZoomIn.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            btnZoomIn.Location = new Point(1237, 280);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(130, 80);
            btnZoomIn.TabIndex = 9;
            btnZoomIn.Text = "확대 +";
            btnZoomIn.UseVisualStyleBackColor = false;
            // 
            // btnZoomOut
            // 
            btnZoomOut.BackColor = Color.FromArgb(255, 128, 128);
            btnZoomOut.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            btnZoomOut.Location = new Point(1398, 280);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(130, 80);
            btnZoomOut.TabIndex = 10;
            btnZoomOut.Text = "축소 -";
            btnZoomOut.UseVisualStyleBackColor = false;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblZoom.Location = new Point(253, 133);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(101, 45);
            lblZoom.TabIndex = 11;
            lblZoom.Text = "100%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 929);
            Controls.Add(btnZoomOut);
            Controls.Add(btnZoomIn);
            Controls.Add(pnlCanvasContainer);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Paint v1.0";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            pnlCanvasContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private ComboBox cmbColor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private PictureBox picCanvas;
        private TrackBar trbLineWidth;
        private Panel pnlCanvasContainer;
        private Button btnZoomIn;
        private Button btnZoomOut;
        private Label lblZoom;
    }
}
