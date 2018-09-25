namespace WeatherApplication.View.SubViews
{
    partial class HourlyItemUserControl
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
            this.WindLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.IconTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemTableLayoutPanel.SuspendLayout();
            this.IconTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemTableLayoutPanel
            // 
            this.ItemTableLayoutPanel.AutoSize = true;
            this.ItemTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemTableLayoutPanel.ColumnCount = 1;
            this.ItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLayoutPanel.Controls.Add(this.WindLabel, 0, 4);
            this.ItemTableLayoutPanel.Controls.Add(this.HumidityLabel, 0, 3);
            this.ItemTableLayoutPanel.Controls.Add(this.TemperatureLabel, 0, 1);
            this.ItemTableLayoutPanel.Controls.Add(this.DescriptionLabel, 0, 2);
            this.ItemTableLayoutPanel.Controls.Add(this.HourLabel, 0, 5);
            this.ItemTableLayoutPanel.Controls.Add(this.IconTableLayoutPanel, 0, 0);
            this.ItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemTableLayoutPanel.Name = "ItemTableLayoutPanel";
            this.ItemTableLayoutPanel.RowCount = 6;
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ItemTableLayoutPanel.Size = new System.Drawing.Size(156, 156);
            this.ItemTableLayoutPanel.TabIndex = 0;
            // 
            // WindLabel
            // 
            this.WindLabel.AutoSize = true;
            this.WindLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindLabel.Location = new System.Drawing.Point(3, 100);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(144, 23);
            this.WindLabel.TabIndex = 6;
            this.WindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HumidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumidityLabel.Location = new System.Drawing.Point(3, 77);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(144, 23);
            this.HumidityLabel.TabIndex = 5;
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureLabel.Location = new System.Drawing.Point(3, 31);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(144, 23);
            this.TemperatureLabel.TabIndex = 0;
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 54);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(144, 23);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HourLabel.Location = new System.Drawing.Point(3, 123);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(144, 27);
            this.HourLabel.TabIndex = 7;
            this.HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconTableLayoutPanel
            // 
            this.IconTableLayoutPanel.AutoSize = true;
            this.IconTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IconTableLayoutPanel.ColumnCount = 3;
            this.IconTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IconTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IconTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IconTableLayoutPanel.Controls.Add(this.IconPictureBox, 1, 0);
            this.IconTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.IconTableLayoutPanel.Name = "IconTableLayoutPanel";
            this.IconTableLayoutPanel.RowCount = 1;
            this.IconTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IconTableLayoutPanel.Size = new System.Drawing.Size(144, 25);
            this.IconTableLayoutPanel.TabIndex = 8;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IconPictureBox.Location = new System.Drawing.Point(0, 3);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(144, 19);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IconPictureBox.TabIndex = 5;
            this.IconPictureBox.TabStop = false;
            // 
            // HourlyItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ItemTableLayoutPanel);
            this.Name = "HourlyItemUserControl";
            this.Size = new System.Drawing.Size(156, 156);
            this.ItemTableLayoutPanel.ResumeLayout(false);
            this.ItemTableLayoutPanel.PerformLayout();
            this.IconTableLayoutPanel.ResumeLayout(false);
            this.IconTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemTableLayoutPanel;
        public System.Windows.Forms.Label TemperatureLabel;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Label WindLabel;
        public System.Windows.Forms.Label HourLabel;
        public System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.TableLayoutPanel IconTableLayoutPanel;
        public System.Windows.Forms.PictureBox IconPictureBox;
    }
}
