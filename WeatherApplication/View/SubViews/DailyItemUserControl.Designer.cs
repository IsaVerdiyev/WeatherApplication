namespace WeatherApplication.View.SubViews
{
    partial class DailyItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TemperatureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MinTemperatureLabel = new System.Windows.Forms.Label();
            this.MaxTemperatureLabel = new System.Windows.Forms.Label();
            this.ItemTableLayoutPanel.SuspendLayout();
            this.TemperatureTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTableLayoutPanel
            // 
            this.ItemTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ItemTableLayoutPanel.ColumnCount = 1;
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLayoutPanel.Controls.Add(this.DateLabel, 0, 0);
            this.ItemTableLayoutPanel.Controls.Add(this.TemperatureTableLayoutPanel, 0, 1);
            this.ItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ItemTableLayoutPanel.Name = "ItemTableLayoutPanel";
            this.ItemTableLayoutPanel.RowCount = 2;
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ItemTableLayoutPanel.Size = new System.Drawing.Size(150, 150);
            this.ItemTableLayoutPanel.TabIndex = 0;
            this.ItemTableLayoutPanel.Click += new System.EventHandler(this.ItemClick);
            this.ItemTableLayoutPanel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.ItemTableLayoutPanel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(3, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(144, 75);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.Click += new System.EventHandler(this.ItemClick);
            this.DateLabel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.DateLabel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // TemperatureTableLayoutPanel
            // 
            this.TemperatureTableLayoutPanel.ColumnCount = 2;
            this.TemperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TemperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TemperatureTableLayoutPanel.Controls.Add(this.MinTemperatureLabel, 0, 0);
            this.TemperatureTableLayoutPanel.Controls.Add(this.MaxTemperatureLabel, 0, 0);
            this.TemperatureTableLayoutPanel.Location = new System.Drawing.Point(3, 78);
            this.TemperatureTableLayoutPanel.Name = "TemperatureTableLayoutPanel";
            this.TemperatureTableLayoutPanel.RowCount = 1;
            this.TemperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TemperatureTableLayoutPanel.Size = new System.Drawing.Size(144, 69);
            this.TemperatureTableLayoutPanel.TabIndex = 1;
            this.TemperatureTableLayoutPanel.Click += new System.EventHandler(this.ItemClick);
            this.TemperatureTableLayoutPanel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.TemperatureTableLayoutPanel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // MinTemperatureLabel
            // 
            this.MinTemperatureLabel.AutoSize = true;
            this.MinTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinTemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTemperatureLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.MinTemperatureLabel.Location = new System.Drawing.Point(141, 0);
            this.MinTemperatureLabel.Name = "MinTemperatureLabel";
            this.MinTemperatureLabel.Size = new System.Drawing.Size(1, 69);
            this.MinTemperatureLabel.TabIndex = 4;
            this.MinTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinTemperatureLabel.Click += new System.EventHandler(this.ItemClick);
            this.MinTemperatureLabel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.MinTemperatureLabel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // MaxTemperatureLabel
            // 
            this.MaxTemperatureLabel.AutoSize = true;
            this.MaxTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxTemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTemperatureLabel.Location = new System.Drawing.Point(3, 0);
            this.MaxTemperatureLabel.Name = "MaxTemperatureLabel";
            this.MaxTemperatureLabel.Size = new System.Drawing.Size(132, 69);
            this.MaxTemperatureLabel.TabIndex = 3;
            this.MaxTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaxTemperatureLabel.Click += new System.EventHandler(this.ItemClick);
            this.MaxTemperatureLabel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.MaxTemperatureLabel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // DailyItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemTableLayoutPanel);
            this.Name = "DailyItemUserControl";
            this.ItemTableLayoutPanel.ResumeLayout(false);
            this.ItemTableLayoutPanel.PerformLayout();
            this.TemperatureTableLayoutPanel.ResumeLayout(false);
            this.TemperatureTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemTableLayoutPanel;
        public System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TableLayoutPanel TemperatureTableLayoutPanel;
        public System.Windows.Forms.Label MinTemperatureLabel;
        public System.Windows.Forms.Label MaxTemperatureLabel;
    }
}
