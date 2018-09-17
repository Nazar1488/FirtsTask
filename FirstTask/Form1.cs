using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using FirstTask.Builders;
using FirstTask.Core.Models;
using FirstTask.Painters;
using FirstTask.Rotators;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private readonly Pen _pen;
        private readonly List<Square> _squares;
        private Bitmap _image;
        private Square _square;

        public Form1()
        {
            InitializeComponent();
            _squares = new List<Square>();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += DoWork;
            backgroundWorker.RunWorkerCompleted += RotateCompleted;
            backgroundWorker.ProgressChanged += ProgressChanged;
            StopButton.Enabled = false;
            RotateButton.Enabled = false;
            _pen = new Pen(Color.Red);
            ColorPanel.BackColor = _pen.Color;
            LineWidthLable.Text = _pen.Width.ToString(CultureInfo.InvariantCulture);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            if (AngleTextBox.Text.Length == 0)
            {
                AngleTextBox.Focus();
                return;
            }

            StopButton.Enabled = true;
            AngleTextBox.Enabled = false;
            RotateButton.Enabled = false;
            UpperLeftCornerXTextBox.Enabled = false;
            UpperLeftCornerYTextBox.Enabled = false;
            SideTextBox.Enabled = false;
            backgroundWorker.RunWorkerAsync(Math.Abs(RotationSpeedTrackBar.Value));
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            SmoothRotate(worker, e);
        }

        private void SmoothRotate(BackgroundWorker worker, DoWorkEventArgs e)
        {
            var angle = int.Parse(AngleTextBox.Text);
            var centerX = (_square.BottomLeft.X + _square.UpperRight.X) / 2;
            var centerY = (_square.BottomLeft.Y + _square.UpperRight.Y) / 2;
            var centerPoint = new PointF(centerX, centerY);
            var resultSquare = new Square();
            _squares.Add(_square);
            for (float i = 1; i <= angle; ++i)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                resultSquare = SquareRotator.Rotate(_square, centerPoint, (int)i);
                _squares.Add(resultSquare);
                PictureBox.Image = SquarePainter.Paint(_squares, _pen, PictureBox.Width, PictureBox.Height);
                _squares.RemoveAt(_squares.Count - 1);
                worker.ReportProgress((int)(i / angle * 100));
                Thread.Sleep(Convert.ToInt32(e.Argument));
            }

            _squares.Add(resultSquare);
            _square = resultSquare;
        }

        private void RotateCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpperLeftCornerXTextBox.Enabled = true;
            UpperLeftCornerYTextBox.Enabled = true;
            SideTextBox.Enabled = true;
            AngleTextBox.Enabled = true;
            RotateButton.Enabled = true;
            StopButton.Enabled = false;
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            StopButton.Enabled = false;
        }

        private void SideTextBox_TextChanged(object sender, EventArgs e)
        {
            _square = ReadSquare();
            PaintSquare();
        }

        private void UpperLeftCornerXTextBox_TextChanged(object sender, EventArgs e)
        {
            _square = ReadSquare();
            PaintSquare();
        }

        private void UpperLeftCornerYTextBox_TextChanged(object sender, EventArgs e)
        {
            _square = ReadSquare();
            PaintSquare();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPanel.BackColor = colorDialog.Color;
                _pen.Color = colorDialog.Color;
                PaintSquare();
            }
        }

        private void LineWidthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            _pen.Width = LineWidthTrackBar.Value;
            LineWidthLable.Text = LineWidthTrackBar.Value.ToString();
            PaintSquare();
        }

        private Square ReadSquare()
        {
            return SquareBuilder.Build(float.Parse(UpperLeftCornerXTextBox.Text),
                float.Parse(UpperLeftCornerYTextBox.Text), float.Parse(SideTextBox.Text));
        }

        private void PaintSquare()
        {
            if (UpperLeftCornerXTextBox.Text.Length == 0)
            {
                UpperLeftCornerXTextBox.Text = "0";
            }

            if (UpperLeftCornerYTextBox.Text.Length == 0)
            {
                UpperLeftCornerYTextBox.Text = "0";
            }

            if (SideTextBox.Text.Length == 0)
            {
                SideTextBox.Text = "0";
            }

            RotateButton.Enabled = true;
            _squares.Add(_square);
            _image = SquarePainter.Paint(_squares, _pen, PictureBox.Width, PictureBox.Height);
            _squares.RemoveAt(_squares.Count - 1);
            PictureBox.Image = _image;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _squares.Clear();
            PictureBox.Image = null;
        }
    }
}
