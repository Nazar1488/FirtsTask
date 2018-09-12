namespace FirstTask
{
    partial class Form1
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.RotateBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AngleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RotationSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.RotateButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AngleLable = new System.Windows.Forms.Label();
            this.RotationSpeedLable = new System.Windows.Forms.Label();
            this.CoordinatesBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UpperLeftCornerYTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UpperLeftCornerXTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UpperLeftCornerLable = new System.Windows.Forms.Label();
            this.SideLable = new System.Windows.Forms.Label();
            this.SizeLable = new System.Windows.Forms.Label();
            this.UpperLeftCornerXLable = new System.Windows.Forms.Label();
            this.UpperLeftCornerYLable = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PenGroupBox = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.LineWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LineWidthLable = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.RotateBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationSpeedTrackBar)).BeginInit();
            this.CoordinatesBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.PenGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(868, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(868, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(650, 16);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.41936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.58064F));
            this.tableLayoutPanel1.Controls.Add(this.ControlPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 514);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.PenGroupBox);
            this.ControlPanel.Controls.Add(this.RotateBox);
            this.ControlPanel.Controls.Add(this.CoordinatesBox);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(675, 3);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(190, 508);
            this.ControlPanel.TabIndex = 4;
            // 
            // RotateBox
            // 
            this.RotateBox.Controls.Add(this.panel2);
            this.RotateBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RotateBox.Location = new System.Drawing.Point(0, 150);
            this.RotateBox.Name = "RotateBox";
            this.RotateBox.Size = new System.Drawing.Size(190, 185);
            this.RotateBox.TabIndex = 4;
            this.RotateBox.TabStop = false;
            this.RotateBox.Text = "Rotate";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AngleTextBox);
            this.panel2.Controls.Add(this.RotationSpeedTrackBar);
            this.panel2.Controls.Add(this.RotateButton);
            this.panel2.Controls.Add(this.StopButton);
            this.panel2.Controls.Add(this.AngleLable);
            this.panel2.Controls.Add(this.RotationSpeedLable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 166);
            this.panel2.TabIndex = 8;
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AngleTextBox.Location = new System.Drawing.Point(68, 37);
            this.AngleTextBox.Mask = "000";
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(86, 20);
            this.AngleTextBox.TabIndex = 8;
            // 
            // RotationSpeedTrackBar
            // 
            this.RotationSpeedTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RotationSpeedTrackBar.Location = new System.Drawing.Point(40, 87);
            this.RotationSpeedTrackBar.Maximum = -10;
            this.RotationSpeedTrackBar.Minimum = -30;
            this.RotationSpeedTrackBar.Name = "RotationSpeedTrackBar";
            this.RotationSpeedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.RotationSpeedTrackBar.TabIndex = 3;
            this.RotationSpeedTrackBar.Value = -20;
            // 
            // RotateButton
            // 
            this.RotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateButton.Location = new System.Drawing.Point(3, 140);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 23);
            this.RotateButton.TabIndex = 3;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(103, 140);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AngleLable
            // 
            this.AngleLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AngleLable.AutoSize = true;
            this.AngleLable.Location = new System.Drawing.Point(28, 40);
            this.AngleLable.Name = "AngleLable";
            this.AngleLable.Size = new System.Drawing.Size(37, 13);
            this.AngleLable.TabIndex = 4;
            this.AngleLable.Text = "Angle:";
            // 
            // RotationSpeedLable
            // 
            this.RotationSpeedLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RotationSpeedLable.AutoSize = true;
            this.RotationSpeedLable.Location = new System.Drawing.Point(53, 71);
            this.RotationSpeedLable.Name = "RotationSpeedLable";
            this.RotationSpeedLable.Size = new System.Drawing.Size(79, 13);
            this.RotationSpeedLable.TabIndex = 6;
            this.RotationSpeedLable.Text = "Rotation speed";
            // 
            // CoordinatesBox
            // 
            this.CoordinatesBox.Controls.Add(this.panel1);
            this.CoordinatesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesBox.Location = new System.Drawing.Point(0, 0);
            this.CoordinatesBox.Name = "CoordinatesBox";
            this.CoordinatesBox.Size = new System.Drawing.Size(190, 150);
            this.CoordinatesBox.TabIndex = 0;
            this.CoordinatesBox.TabStop = false;
            this.CoordinatesBox.Text = "Coordinates";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SideTextBox);
            this.panel1.Controls.Add(this.UpperLeftCornerYTextBox);
            this.panel1.Controls.Add(this.UpperLeftCornerXTextBox);
            this.panel1.Controls.Add(this.UpperLeftCornerLable);
            this.panel1.Controls.Add(this.SideLable);
            this.panel1.Controls.Add(this.SizeLable);
            this.panel1.Controls.Add(this.UpperLeftCornerXLable);
            this.panel1.Controls.Add(this.UpperLeftCornerYLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 131);
            this.panel1.TabIndex = 9;
            // 
            // SideTextBox
            // 
            this.SideTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SideTextBox.Location = new System.Drawing.Point(68, 98);
            this.SideTextBox.Mask = "000";
            this.SideTextBox.Name = "SideTextBox";
            this.SideTextBox.Size = new System.Drawing.Size(86, 20);
            this.SideTextBox.TabIndex = 11;
            this.SideTextBox.Text = "0";
            this.SideTextBox.TextChanged += new System.EventHandler(this.SideTextBox_TextChanged);
            // 
            // UpperLeftCornerYTextBox
            // 
            this.UpperLeftCornerYTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperLeftCornerYTextBox.Location = new System.Drawing.Point(68, 55);
            this.UpperLeftCornerYTextBox.Mask = "000";
            this.UpperLeftCornerYTextBox.Name = "UpperLeftCornerYTextBox";
            this.UpperLeftCornerYTextBox.Size = new System.Drawing.Size(86, 20);
            this.UpperLeftCornerYTextBox.TabIndex = 10;
            this.UpperLeftCornerYTextBox.Text = "0";
            this.UpperLeftCornerYTextBox.ValidatingType = typeof(int);
            this.UpperLeftCornerYTextBox.TextChanged += new System.EventHandler(this.UpperLeftCornerYTextBox_TextChanged);
            // 
            // UpperLeftCornerXTextBox
            // 
            this.UpperLeftCornerXTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperLeftCornerXTextBox.Location = new System.Drawing.Point(68, 29);
            this.UpperLeftCornerXTextBox.Mask = "000";
            this.UpperLeftCornerXTextBox.Name = "UpperLeftCornerXTextBox";
            this.UpperLeftCornerXTextBox.Size = new System.Drawing.Size(86, 20);
            this.UpperLeftCornerXTextBox.TabIndex = 9;
            this.UpperLeftCornerXTextBox.Text = "0";
            this.UpperLeftCornerXTextBox.ValidatingType = typeof(int);
            this.UpperLeftCornerXTextBox.TextChanged += new System.EventHandler(this.UpperLeftCornerXTextBox_TextChanged);
            // 
            // UpperLeftCornerLable
            // 
            this.UpperLeftCornerLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperLeftCornerLable.AutoSize = true;
            this.UpperLeftCornerLable.Location = new System.Drawing.Point(65, 13);
            this.UpperLeftCornerLable.Name = "UpperLeftCornerLable";
            this.UpperLeftCornerLable.Size = new System.Drawing.Size(86, 13);
            this.UpperLeftCornerLable.TabIndex = 0;
            this.UpperLeftCornerLable.Text = "Upper left corner";
            // 
            // SideLable
            // 
            this.SideLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SideLable.AutoSize = true;
            this.SideLable.Location = new System.Drawing.Point(31, 101);
            this.SideLable.Name = "SideLable";
            this.SideLable.Size = new System.Drawing.Size(31, 13);
            this.SideLable.TabIndex = 6;
            this.SideLable.Text = "Side:";
            // 
            // SizeLable
            // 
            this.SizeLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SizeLable.AutoSize = true;
            this.SizeLable.Location = new System.Drawing.Point(96, 82);
            this.SizeLable.Name = "SizeLable";
            this.SizeLable.Size = new System.Drawing.Size(27, 13);
            this.SizeLable.TabIndex = 5;
            this.SizeLable.Text = "Size";
            // 
            // UpperLeftCornerXLable
            // 
            this.UpperLeftCornerXLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperLeftCornerXLable.AutoSize = true;
            this.UpperLeftCornerXLable.Location = new System.Drawing.Point(45, 32);
            this.UpperLeftCornerXLable.Name = "UpperLeftCornerXLable";
            this.UpperLeftCornerXLable.Size = new System.Drawing.Size(17, 13);
            this.UpperLeftCornerXLable.TabIndex = 3;
            this.UpperLeftCornerXLable.Text = "X:";
            // 
            // UpperLeftCornerYLable
            // 
            this.UpperLeftCornerYLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperLeftCornerYLable.AutoSize = true;
            this.UpperLeftCornerYLable.Location = new System.Drawing.Point(45, 58);
            this.UpperLeftCornerYLable.Name = "UpperLeftCornerYLable";
            this.UpperLeftCornerYLable.Size = new System.Drawing.Size(17, 13);
            this.UpperLeftCornerYLable.TabIndex = 4;
            this.UpperLeftCornerYLable.Text = "Y:";
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = global::FirstTask.Properties.Resources.Locator_Grid;
            this.PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(666, 508);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // PenGroupBox
            // 
            this.PenGroupBox.Controls.Add(this.panel3);
            this.PenGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PenGroupBox.Location = new System.Drawing.Point(0, 335);
            this.PenGroupBox.Name = "PenGroupBox";
            this.PenGroupBox.Size = new System.Drawing.Size(190, 173);
            this.PenGroupBox.TabIndex = 5;
            this.PenGroupBox.TabStop = false;
            this.PenGroupBox.Text = "Pen";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LineWidthLable);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ColorPanel);
            this.panel3.Controls.Add(this.LineWidthTrackBar);
            this.panel3.Controls.Add(this.ColorButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 154);
            this.panel3.TabIndex = 0;
            // 
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorButton.Location = new System.Drawing.Point(55, 56);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 23);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Location = new System.Drawing.Point(68, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(50, 50);
            this.ColorPanel.TabIndex = 1;
            // 
            // LineWidthTrackBar
            // 
            this.LineWidthTrackBar.Location = new System.Drawing.Point(34, 106);
            this.LineWidthTrackBar.Minimum = 1;
            this.LineWidthTrackBar.Name = "LineWidthTrackBar";
            this.LineWidthTrackBar.Size = new System.Drawing.Size(117, 45);
            this.LineWidthTrackBar.TabIndex = 2;
            this.LineWidthTrackBar.Value = 1;
            this.LineWidthTrackBar.ValueChanged += new System.EventHandler(this.LineWidthTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line width:";
            // 
            // LineWidthLable
            // 
            this.LineWidthLable.AutoSize = true;
            this.LineWidthLable.Location = new System.Drawing.Point(71, 82);
            this.LineWidthLable.Name = "LineWidthLable";
            this.LineWidthLable.Size = new System.Drawing.Size(0, 13);
            this.LineWidthLable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "First task";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.RotateBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationSpeedTrackBar)).EndInit();
            this.CoordinatesBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.PenGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox RotateBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label RotationSpeedLable;
        private System.Windows.Forms.TrackBar RotationSpeedTrackBar;
        private System.Windows.Forms.Label AngleLable;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.GroupBox CoordinatesBox;
        private System.Windows.Forms.Label SideLable;
        private System.Windows.Forms.Label SizeLable;
        private System.Windows.Forms.Label UpperLeftCornerYLable;
        private System.Windows.Forms.Label UpperLeftCornerXLable;
        private System.Windows.Forms.Label UpperLeftCornerLable;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox AngleTextBox;
        private System.Windows.Forms.MaskedTextBox SideTextBox;
        private System.Windows.Forms.MaskedTextBox UpperLeftCornerYTextBox;
        private System.Windows.Forms.MaskedTextBox UpperLeftCornerXTextBox;
        private System.Windows.Forms.GroupBox PenGroupBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar LineWidthTrackBar;
        private System.Windows.Forms.Label LineWidthLable;
    }
}

