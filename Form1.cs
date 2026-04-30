using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }

        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;

        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;

        private ToolType currentTool = ToolType.Line;
        private Color currentColor = Color.Black;
        private int currentLineWidth = 2;

        private float zoomFactor = 1.0f;
        private const float ZoomStep = 0.25f;
        private const float MinZoom = 0.25f;
        private const float MaxZoom = 5.0f;

        public Form1()
        {
            InitializeComponent();

            // 처음 실행 시에는 Panel의 현재 보이는 크기를 기준으로 캔버스 생성
            int canvasWidth = Math.Max(400, pnlCanvasContainer.ClientSize.Width - 5);
            int canvasHeight = Math.Max(300, pnlCanvasContainer.ClientSize.Height - 5);

            canvasBitmap = new Bitmap(canvasWidth, canvasHeight);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);

            // PictureBox 기본 위치/크기
            picCanvas.Left = 0;
            picCanvas.Top = 0;
            picCanvas.Width = canvasBitmap.Width;
            picCanvas.Height = canvasBitmap.Height;

            // 이벤트 연결
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;
            picCanvas.Paint += PicCanvas_Paint;

            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;

            btnOpenFile.Click += btnOpenFile_Click;
            btnSaveFile.Click += btnSaveFile_Click;

            btnZoomIn.Click += btnZoomIn_Click;
            btnZoomOut.Click += btnZoomOut_Click;

            cmbColor.Items.Clear();
            cmbColor.Items.Add("Black");
            cmbColor.Items.Add("Red");
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Green");
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0;

            trbLineWidth.Minimum = 1;
            trbLineWidth.Maximum = 10;
            trbLineWidth.Value = 2;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            UpdateZoomLabel();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ApplyZoom();
        }

        private void btnLine_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        private void btnRectangle_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void btnCircle_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void cmbColor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0:
                    currentColor = Color.Black;
                    break;
                case 1:
                    currentColor = Color.Red;
                    break;
                case 2:
                    currentColor = Color.Blue;
                    break;
                case 3:
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        private void trbLineWidth_ValueChanged(object? sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }

        private void btnZoomIn_Click(object? sender, EventArgs e)
        {
            zoomFactor += ZoomStep;

            if (zoomFactor > MaxZoom)
                zoomFactor = MaxZoom;

            UpdateZoomLabel();
            ApplyZoom();
        }

        private void btnZoomOut_Click(object? sender, EventArgs e)
        {
            zoomFactor -= ZoomStep;

            if (zoomFactor < MinZoom)
                zoomFactor = MinZoom;

            UpdateZoomLabel();
            ApplyZoom();
        }

        private void UpdateZoomLabel()
        {
            lblZoom.Text = $"{(int)(zoomFactor * 100)}%";
        }

        private void ApplyZoom()
        {
            if (canvasBitmap == null) return;

            picCanvas.Width = (int)(canvasBitmap.Width * zoomFactor);
            picCanvas.Height = (int)(canvasBitmap.Height * zoomFactor);
            picCanvas.Left = 0;
            picCanvas.Top = 0;
            picCanvas.Invalidate();
        }

        private Point ConvertToCanvasPoint(Point displayPoint)
        {
            return new Point(
                (int)(displayPoint.X / zoomFactor),
                (int)(displayPoint.Y / zoomFactor)
            );
        }

        private Point ScalePointForDisplay(Point originalPoint)
        {
            return new Point(
                (int)(originalPoint.X * zoomFactor),
                (int)(originalPoint.Y * zoomFactor)
            );
        }

        private void PicCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            isDrawing = true;
            startPoint = ConvertToCanvasPoint(e.Location);
            endPoint = startPoint;
        }

        private void PicCanvas_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            endPoint = ConvertToCanvasPoint(e.Location);
            picCanvas.Invalidate();
        }

        private void PicCanvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            isDrawing = false;
            endPoint = ConvertToCanvasPoint(e.Location);

            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }

            picCanvas.Invalidate();
        }

        private void PicCanvas_Paint(object? sender, PaintEventArgs e)
        {
            if (canvasBitmap == null) return;

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.DrawImage(
                canvasBitmap,
                new Rectangle(0, 0, picCanvas.Width, picCanvas.Height),
                new Rectangle(0, 0, canvasBitmap.Width, canvasBitmap.Height),
                GraphicsUnit.Pixel
            );

            if (isDrawing)
            {
                using (Pen previewPen = new Pen(currentColor, currentLineWidth))
                {
                    previewPen.DashStyle = DashStyle.Dash;
                    DrawPreviewShape(e.Graphics, previewPen, startPoint, endPoint);
                }
            }
        }

        private void DrawPreviewShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Point scaledP1 = ScalePointForDisplay(p1);
            Point scaledP2 = ScalePointForDisplay(p2);
            Rectangle rect = GetRectangle(scaledP1, scaledP2);

            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, scaledP1, scaledP2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);

            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }

        private void btnSaveFile_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "이미지 저장";
                dlg.Filter = "PNG 파일 (*.png)|*.png|JPG 파일 (*.jpg)|*.jpg|BMP 파일 (*.bmp)|*.bmp";
                dlg.DefaultExt = "png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(dlg.FileName).ToLower();

                    switch (ext)
                    {
                        case ".png":
                            canvasBitmap.Save(dlg.FileName, ImageFormat.Png);
                            break;
                        case ".jpg":
                            canvasBitmap.Save(dlg.FileName, ImageFormat.Jpeg);
                            break;
                        case ".bmp":
                            canvasBitmap.Save(dlg.FileName, ImageFormat.Bmp);
                            break;
                        default:
                            canvasBitmap.Save(dlg.FileName, ImageFormat.Png);
                            break;
                    }

                    MessageBox.Show("이미지가 저장되었습니다.");
                }
            }
        }

        private void btnOpenFile_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "이미지 열기";
                dlg.Filter = "이미지 파일 (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (Image loadedImage = Image.FromFile(dlg.FileName))
                    {
                        Bitmap newBitmap = new Bitmap(loadedImage.Width, loadedImage.Height);

                        using (Graphics g = Graphics.FromImage(newBitmap))
                        {
                            g.DrawImage(loadedImage, 0, 0, loadedImage.Width, loadedImage.Height);
                        }

                        canvasGraphics.Dispose();
                        canvasBitmap.Dispose();

                        canvasBitmap = newBitmap;
                        canvasGraphics = Graphics.FromImage(canvasBitmap);

                        zoomFactor = 1.0f;
                        UpdateZoomLabel();
                        ApplyZoom();
                    }
                }
            }
        }
    }
}