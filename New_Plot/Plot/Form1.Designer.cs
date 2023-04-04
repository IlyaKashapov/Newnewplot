namespace Plot
{
    using System.Windows.Forms.DataVisualization;

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
            button1 = new Button();
            pic = new PictureBox();
            dek_x = new Label();
            dek_y = new Label();
            ekr_x = new Label();
            ekr_y = new Label();
            minx_dek = new TextBox();
            maxx_dek = new TextBox();
            xxx = new Label();
            miny_dek = new TextBox();
            maxy_dek = new TextBox();
            label4 = new Label();
            textfunc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(713, 162);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 81);
            button1.TabIndex = 1;
            button1.Text = "Построить график";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic.BackColor = SystemColors.ButtonFace;
            pic.Location = new Point(12, 74);
            pic.Name = "pic";
            pic.Size = new Size(695, 453);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Click += pic_Click;
            pic.MouseMove += pic_MouseMove;
            // 
            // dek_x
            // 
            dek_x.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dek_x.AutoSize = true;
            dek_x.Location = new Point(12, 533);
            dek_x.Name = "dek_x";
            dek_x.Size = new Size(44, 20);
            dek_x.TabIndex = 3;
            dek_x.Text = "dek x";
            // 
            // dek_y
            // 
            dek_y.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dek_y.AutoSize = true;
            dek_y.Location = new Point(145, 533);
            dek_y.Name = "dek_y";
            dek_y.Size = new Size(44, 20);
            dek_y.TabIndex = 4;
            dek_y.Text = "dek y";
            dek_y.Click += label2_Click;
            // 
            // ekr_x
            // 
            ekr_x.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ekr_x.AutoSize = true;
            ekr_x.Location = new Point(493, 533);
            ekr_x.Name = "ekr_x";
            ekr_x.Size = new Size(40, 20);
            ekr_x.TabIndex = 5;
            ekr_x.Text = "x ekr";
            // 
            // ekr_y
            // 
            ekr_y.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ekr_y.AutoSize = true;
            ekr_y.Location = new Point(560, 533);
            ekr_y.Name = "ekr_y";
            ekr_y.Size = new Size(40, 20);
            ekr_y.TabIndex = 6;
            ekr_y.Text = "y ekr";
            // 
            // minx_dek
            // 
            minx_dek.Location = new Point(419, 41);
            minx_dek.Name = "minx_dek";
            minx_dek.Size = new Size(43, 27);
            minx_dek.TabIndex = 9;
            minx_dek.Text = "-2";
            // 
            // maxx_dek
            // 
            maxx_dek.Location = new Point(509, 41);
            maxx_dek.Name = "maxx_dek";
            maxx_dek.Size = new Size(44, 27);
            maxx_dek.TabIndex = 10;
            maxx_dek.Text = "2";
            maxx_dek.TextChanged += maxx_dek_TextChanged;
            // 
            // xxx
            // 
            xxx.AutoSize = true;
            xxx.Location = new Point(419, 9);
            xxx.Name = "xxx";
            xxx.Size = new Size(134, 20);
            xxx.TabIndex = 11;
            xxx.Text = "Диапазон x(в дек)";
            // 
            // miny_dek
            // 
            miny_dek.Location = new Point(595, 41);
            miny_dek.Name = "miny_dek";
            miny_dek.Size = new Size(35, 27);
            miny_dek.TabIndex = 12;
            miny_dek.Text = "-1";
            // 
            // maxy_dek
            // 
            maxy_dek.Location = new Point(650, 41);
            maxy_dek.Name = "maxy_dek";
            maxy_dek.Size = new Size(42, 27);
            maxy_dek.TabIndex = 13;
            maxy_dek.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(595, 9);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 16;
            label4.Text = "Диапазон у(в дек)";
            // 
            // textfunc
            // 
            textfunc.Location = new Point(713, 128);
            textfunc.Name = "textfunc";
            textfunc.Size = new Size(75, 27);
            textfunc.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(textfunc);
            Controls.Add(label4);
            Controls.Add(maxy_dek);
            Controls.Add(miny_dek);
            Controls.Add(xxx);
            Controls.Add(maxx_dek);
            Controls.Add(minx_dek);
            Controls.Add(ekr_y);
            Controls.Add(ekr_x);
            Controls.Add(dek_y);
            Controls.Add(dek_x);
            Controls.Add(pic);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private PictureBox pic;
        private Label dek_x;
        private Label dek_y;
        private Label ekr_x;
        private Label ekr_y;
        private TextBox minx_dek;
        private TextBox maxx_dek;
        private Label xxx;
        private TextBox miny_dek;
        private TextBox maxy_dek;
        private Label label4;
        private TextBox textfunc;
    }
}

