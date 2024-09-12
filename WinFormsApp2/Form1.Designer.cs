namespace WinFormsApp2
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
            TopLeft = new Button();
            TopCenter = new Button();
            TopRight = new Button();
            CenterLeft = new Button();
            CenterCenter = new Button();
            CenterRight = new Button();
            BottomLeft = new Button();
            BottomCenter = new Button();
            BottomRight = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TopLeft
            // 
            TopLeft.Dock = DockStyle.Fill;
            TopLeft.Location = new Point(3, 3);
            TopLeft.Name = "TopLeft";
            TopLeft.Size = new Size(448, 203);
            TopLeft.TabIndex = 0;
            TopLeft.UseVisualStyleBackColor = true;
            TopLeft.Click += GameButtonClick;
            // 
            // TopCenter
            // 
            TopCenter.Dock = DockStyle.Fill;
            TopCenter.Location = new Point(457, 3);
            TopCenter.Name = "TopCenter";
            TopCenter.Size = new Size(448, 203);
            TopCenter.TabIndex = 1;
            TopCenter.UseVisualStyleBackColor = true;
            TopCenter.Click += GameButtonClick;
            // 
            // TopRight
            // 
            TopRight.Dock = DockStyle.Fill;
            TopRight.Location = new Point(911, 3);
            TopRight.Name = "TopRight";
            TopRight.Size = new Size(448, 203);
            TopRight.TabIndex = 2;
            TopRight.UseVisualStyleBackColor = true;
            TopRight.Click += GameButtonClick;
            // 
            // CenterLeft
            // 
            CenterLeft.Dock = DockStyle.Fill;
            CenterLeft.Location = new Point(3, 212);
            CenterLeft.Name = "CenterLeft";
            CenterLeft.Size = new Size(448, 203);
            CenterLeft.TabIndex = 3;
            CenterLeft.UseVisualStyleBackColor = true;
            CenterLeft.Click += GameButtonClick;
            // 
            // CenterCenter
            // 
            CenterCenter.Dock = DockStyle.Fill;
            CenterCenter.Location = new Point(457, 212);
            CenterCenter.Name = "CenterCenter";
            CenterCenter.Size = new Size(448, 203);
            CenterCenter.TabIndex = 4;
            CenterCenter.UseVisualStyleBackColor = true;
            CenterCenter.Click += GameButtonClick;
            // 
            // CenterRight
            // 
            CenterRight.Dock = DockStyle.Fill;
            CenterRight.Location = new Point(911, 212);
            CenterRight.Name = "CenterRight";
            CenterRight.Size = new Size(448, 203);
            CenterRight.TabIndex = 5;
            CenterRight.UseVisualStyleBackColor = true;
            CenterRight.Click += GameButtonClick;
            // 
            // BottomLeft
            // 
            BottomLeft.Dock = DockStyle.Fill;
            BottomLeft.Location = new Point(3, 421);
            BottomLeft.Name = "BottomLeft";
            BottomLeft.Size = new Size(448, 203);
            BottomLeft.TabIndex = 6;
            BottomLeft.UseVisualStyleBackColor = true;
            BottomLeft.Click += GameButtonClick;
            // 
            // BottomCenter
            // 
            BottomCenter.Dock = DockStyle.Fill;
            BottomCenter.Location = new Point(457, 421);
            BottomCenter.Name = "BottomCenter";
            BottomCenter.Size = new Size(448, 203);
            BottomCenter.TabIndex = 7;
            BottomCenter.UseVisualStyleBackColor = true;
            BottomCenter.Click += GameButtonClick;
            // 
            // BottomRight
            // 
            BottomRight.Dock = DockStyle.Fill;
            BottomRight.Location = new Point(911, 421);
            BottomRight.Name = "BottomRight";
            BottomRight.Size = new Size(448, 203);
            BottomRight.TabIndex = 8;
            BottomRight.UseVisualStyleBackColor = true;
            BottomRight.Click += GameButtonClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(664, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Siema";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(TopLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(TopCenter, 1, 0);
            tableLayoutPanel1.Controls.Add(BottomRight, 2, 2);
            tableLayoutPanel1.Controls.Add(TopRight, 2, 0);
            tableLayoutPanel1.Controls.Add(BottomCenter, 1, 2);
            tableLayoutPanel1.Controls.Add(CenterLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(BottomLeft, 0, 2);
            tableLayoutPanel1.Controls.Add(CenterCenter, 1, 1);
            tableLayoutPanel1.Controls.Add(CenterRight, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1362, 627);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1368, 648);
            tableLayoutPanel2.TabIndex = 11;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 648);
            Controls.Add(tableLayoutPanel2);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button TopLeft;
        private Button TopCenter;
        private Button TopRight;
        private Button CenterLeft;
        private Button CenterCenter;
        private Button CenterRight;
        private Button BottomLeft;
        private Button BottomCenter;
        private Button BottomRight;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
