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
            label1 = new Label();
            cmbColor = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            pictureBox1 = new PictureBox();
            btnLine = new Button();
            btnRectangle = new Button();
            btnCircle = new Button();
            trbLineWidth = new TrackBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(402, 65);
            label1.TabIndex = 0;
            label1.Text = "Simple Paint";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(58, 60);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(242, 40);
            cmbColor.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(31, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 200);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형선택";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(437, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 200);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(843, 203);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 200);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(1261, 243);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(150, 46);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(1417, 243);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(150, 46);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(51, 399);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1378, 480);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(6, 70);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(150, 46);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(162, 76);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(150, 46);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            btnCircle.Location = new Point(230, 134);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(150, 46);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(98, 100);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(208, 90);
            trbLineWidth.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 929);
            Controls.Add(pictureBox1);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbColor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private PictureBox pictureBox1;
        private TrackBar trbLineWidth;
    }
}
