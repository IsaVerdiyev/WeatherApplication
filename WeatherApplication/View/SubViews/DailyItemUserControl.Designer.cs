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
            this.DesciptionLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ItemTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTableLayoutPanel
            // 
            this.ItemTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ItemTableLayoutPanel.ColumnCount = 1;
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLayoutPanel.Controls.Add(this.DesciptionLabel, 0, 3);
            this.ItemTableLayoutPanel.Controls.Add(this.TemperatureLabel, 0, 2);
            this.ItemTableLayoutPanel.Controls.Add(this.DateLabel, 0, 0);
            this.ItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemTableLayoutPanel.Name = "ItemTableLayoutPanel";
            this.ItemTableLayoutPanel.RowCount = 4;
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4898F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4898F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.2653F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.ItemTableLayoutPanel.Size = new System.Drawing.Size(150, 150);
            this.ItemTableLayoutPanel.TabIndex = 0;
            this.ItemTableLayoutPanel.Click += new System.EventHandler(this.ItemClick);
            this.ItemTableLayoutPanel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.ItemTableLayoutPanel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // DesciptionLabel
            // 
            this.DesciptionLabel.AutoSize = true;
            this.DesciptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DesciptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesciptionLabel.Location = new System.Drawing.Point(3, 129);
            this.DesciptionLabel.Name = "DesciptionLabel";
            this.DesciptionLabel.Size = new System.Drawing.Size(144, 21);
            this.DesciptionLabel.TabIndex = 3;
            this.DesciptionLabel.Click += new System.EventHandler(this.ItemClick);
            this.DesciptionLabel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.DesciptionLabel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperatureLabel.Location = new System.Drawing.Point(3, 72);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(144, 57);
            this.TemperatureLabel.TabIndex = 2;
            this.TemperatureLabel.Click += new System.EventHandler(this.ItemClick);
            this.TemperatureLabel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.TemperatureLabel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Location = new System.Drawing.Point(3, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(144, 36);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Click += new System.EventHandler(this.ItemClick);
            this.DateLabel.MouseEnter += new System.EventHandler(this.ItemMouseEnter);
            this.DateLabel.MouseLeave += new System.EventHandler(this.ItemMouseLeave);
            // 
            // DailyItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemTableLayoutPanel);
            this.Name = "DailyItemUserControl";
            this.ItemTableLayoutPanel.ResumeLayout(false);
            this.ItemTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemTableLayoutPanel;
        private System.Windows.Forms.Label DesciptionLabel;
        public System.Windows.Forms.Label TemperatureLabel;
        public System.Windows.Forms.Label DateLabel;
    }
}
