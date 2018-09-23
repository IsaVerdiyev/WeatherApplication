namespace WeatherApplication.View
{
    partial class MainView
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
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CitySettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveCityButton = new System.Windows.Forms.Button();
            this.AddCityButton = new System.Windows.Forms.Button();
            this.CitiesComboBox = new System.Windows.Forms.ComboBox();
            this.NewCityTextBox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.CitySettingsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.CitySettingsTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(760, 593);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // CitySettingsTableLayoutPanel
            // 
            this.CitySettingsTableLayoutPanel.AutoSize = true;
            this.CitySettingsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CitySettingsTableLayoutPanel.ColumnCount = 5;
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.Controls.Add(this.RemoveCityButton, 4, 0);
            this.CitySettingsTableLayoutPanel.Controls.Add(this.AddCityButton, 3, 0);
            this.CitySettingsTableLayoutPanel.Controls.Add(this.CitiesComboBox, 1, 0);
            this.CitySettingsTableLayoutPanel.Controls.Add(this.NewCityTextBox, 2, 0);
            this.CitySettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CitySettingsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.CitySettingsTableLayoutPanel.Name = "CitySettingsTableLayoutPanel";
            this.CitySettingsTableLayoutPanel.RowCount = 1;
            this.CitySettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CitySettingsTableLayoutPanel.Size = new System.Drawing.Size(754, 29);
            this.CitySettingsTableLayoutPanel.TabIndex = 0;
            // 
            // RemoveCityButton
            // 
            this.RemoveCityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveCityButton.Location = new System.Drawing.Point(657, 3);
            this.RemoveCityButton.Name = "RemoveCityButton";
            this.RemoveCityButton.Size = new System.Drawing.Size(94, 23);
            this.RemoveCityButton.TabIndex = 0;
            this.RemoveCityButton.Text = "Remove city...";
            this.RemoveCityButton.UseVisualStyleBackColor = true;
            this.RemoveCityButton.Click += new System.EventHandler(this.RemoveCityButton_Click);
            // 
            // AddCityButton
            // 
            this.AddCityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCityButton.Location = new System.Drawing.Point(557, 3);
            this.AddCityButton.Name = "AddCityButton";
            this.AddCityButton.Size = new System.Drawing.Size(94, 23);
            this.AddCityButton.TabIndex = 1;
            this.AddCityButton.Text = "Add city";
            this.AddCityButton.UseVisualStyleBackColor = true;
            this.AddCityButton.Click += new System.EventHandler(this.AddCityButton_Click);
            // 
            // CitiesComboBox
            // 
            this.CitiesComboBox.FormattingEnabled = true;
            this.CitiesComboBox.Location = new System.Drawing.Point(357, 3);
            this.CitiesComboBox.Name = "CitiesComboBox";
            this.CitiesComboBox.Size = new System.Drawing.Size(94, 21);
            this.CitiesComboBox.TabIndex = 2;
            this.CitiesComboBox.SelectedIndexChanged += new System.EventHandler(this.CitiesComboBox_SelectedIndexChanged);
            // 
            // NewCityTextBox
            // 
            this.NewCityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewCityTextBox.Location = new System.Drawing.Point(457, 3);
            this.NewCityTextBox.Name = "NewCityTextBox";
            this.NewCityTextBox.Size = new System.Drawing.Size(94, 20);
            this.NewCityTextBox.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(760, 593);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.CitySettingsTableLayoutPanel.ResumeLayout(false);
            this.CitySettingsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CitySettingsTableLayoutPanel;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.ComboBox CitiesComboBox;
        private System.Windows.Forms.TextBox NewCityTextBox;
        private System.Windows.Forms.Button RemoveCityButton;
    }
}
