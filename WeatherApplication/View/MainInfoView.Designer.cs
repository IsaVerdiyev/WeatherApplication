namespace WeatherApplication.View
{
    partial class MainInfoView
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
            this.WeatherInfoWrapperPanel = new System.Windows.Forms.Panel();
            this.WeatherInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentTemperatureTableLayoutPanelWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentTemperatureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.DegreeImageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.LastUpdateTimeLabel = new System.Windows.Forms.Label();
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.MainTableLayoutPanel.SuspendLayout();
            this.CitySettingsTableLayoutPanel.SuspendLayout();
            this.WeatherInfoWrapperPanel.SuspendLayout();
            this.WeatherInfoTableLayoutPanel.SuspendLayout();
            this.CurrentTemperatureTableLayoutPanelWrapper.SuspendLayout();
            this.CurrentTemperatureTableLayoutPanel.SuspendLayout();
            this.DegreeImageTableLayoutPanel.SuspendLayout();
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.CitySettingsTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.WeatherInfoWrapperPanel, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(760, 802);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // CitySettingsTableLayoutPanel
            // 
            this.CitySettingsTableLayoutPanel.AutoSize = true;
            this.CitySettingsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CitySettingsTableLayoutPanel.ColumnCount = 4;
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CitySettingsTableLayoutPanel.Controls.Add(this.RemoveCityButton, 3, 0);
            this.CitySettingsTableLayoutPanel.Controls.Add(this.AddCityButton, 2, 0);
            this.CitySettingsTableLayoutPanel.Controls.Add(this.CitiesComboBox, 1, 0);
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
            this.RemoveCityButton.Text = "Remove city";
            this.RemoveCityButton.UseVisualStyleBackColor = true;
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
            // 
            // CitiesComboBox
            // 
            this.CitiesComboBox.FormattingEnabled = true;
            this.CitiesComboBox.Location = new System.Drawing.Point(457, 3);
            this.CitiesComboBox.Name = "CitiesComboBox";
            this.CitiesComboBox.Size = new System.Drawing.Size(94, 21);
            this.CitiesComboBox.TabIndex = 2;
            // 
            // WeatherInfoWrapperPanel
            // 
            this.WeatherInfoWrapperPanel.Controls.Add(this.WeatherInfoTableLayoutPanel);
            this.WeatherInfoWrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeatherInfoWrapperPanel.Location = new System.Drawing.Point(3, 38);
            this.WeatherInfoWrapperPanel.Name = "WeatherInfoWrapperPanel";
            this.WeatherInfoWrapperPanel.Size = new System.Drawing.Size(754, 761);
            this.WeatherInfoWrapperPanel.TabIndex = 1;
            // 
            // WeatherInfoTableLayoutPanel
            // 
            this.WeatherInfoTableLayoutPanel.AutoSize = true;
            this.WeatherInfoTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WeatherInfoTableLayoutPanel.ColumnCount = 1;
            this.WeatherInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WeatherInfoTableLayoutPanel.Controls.Add(this.CurrentTemperatureTableLayoutPanelWrapper, 0, 0);
            this.WeatherInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeatherInfoTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.WeatherInfoTableLayoutPanel.Name = "WeatherInfoTableLayoutPanel";
            this.WeatherInfoTableLayoutPanel.RowCount = 3;
            this.WeatherInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.WeatherInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.WeatherInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.WeatherInfoTableLayoutPanel.Size = new System.Drawing.Size(754, 600);
            this.WeatherInfoTableLayoutPanel.TabIndex = 0;
            // 
            // CurrentTemperatureTableLayoutPanelWrapper
            // 
            this.CurrentTemperatureTableLayoutPanelWrapper.ColumnCount = 3;
            this.CurrentTemperatureTableLayoutPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentTemperatureTableLayoutPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CurrentTemperatureTableLayoutPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentTemperatureTableLayoutPanelWrapper.Controls.Add(this.CurrentTemperatureTableLayoutPanel, 1, 0);
            this.CurrentTemperatureTableLayoutPanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentTemperatureTableLayoutPanelWrapper.Location = new System.Drawing.Point(3, 3);
            this.CurrentTemperatureTableLayoutPanelWrapper.Name = "CurrentTemperatureTableLayoutPanelWrapper";
            this.CurrentTemperatureTableLayoutPanelWrapper.RowCount = 1;
            this.CurrentTemperatureTableLayoutPanelWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentTemperatureTableLayoutPanelWrapper.Size = new System.Drawing.Size(748, 194);
            this.CurrentTemperatureTableLayoutPanelWrapper.TabIndex = 0;
            // 
            // CurrentTemperatureTableLayoutPanel
            // 
            this.CurrentTemperatureTableLayoutPanel.ColumnCount = 1;
            this.CurrentTemperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentTemperatureTableLayoutPanel.Controls.Add(this.CityNameLabel, 0, 0);
            this.CurrentTemperatureTableLayoutPanel.Controls.Add(this.DegreeImageTableLayoutPanel, 0, 1);
            this.CurrentTemperatureTableLayoutPanel.Controls.Add(this.DescriptionLabel, 0, 2);
            this.CurrentTemperatureTableLayoutPanel.Controls.Add(this.LastUpdateTimeLabel, 0, 3);
            this.CurrentTemperatureTableLayoutPanel.Controls.Add(this.CurrentTemperatureAdditionalInfoTableLayoutPanel, 0, 4);
            this.CurrentTemperatureTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentTemperatureTableLayoutPanel.Location = new System.Drawing.Point(274, 3);
            this.CurrentTemperatureTableLayoutPanel.Name = "CurrentTemperatureTableLayoutPanel";
            this.CurrentTemperatureTableLayoutPanel.RowCount = 5;
            this.CurrentTemperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentTemperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.CurrentTemperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CurrentTemperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CurrentTemperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CurrentTemperatureTableLayoutPanel.Size = new System.Drawing.Size(200, 188);
            this.CurrentTemperatureTableLayoutPanel.TabIndex = 0;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityNameLabel.Location = new System.Drawing.Point(3, 0);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(194, 37);
            this.CityNameLabel.TabIndex = 0;
            this.CityNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DegreeImageTableLayoutPanel
            // 
            this.DegreeImageTableLayoutPanel.ColumnCount = 3;
            this.DegreeImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DegreeImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DegreeImageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DegreeImageTableLayoutPanel.Controls.Add(this.DegreeLabel, 1, 0);
            this.DegreeImageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DegreeImageTableLayoutPanel.Location = new System.Drawing.Point(3, 40);
            this.DegreeImageTableLayoutPanel.Name = "DegreeImageTableLayoutPanel";
            this.DegreeImageTableLayoutPanel.RowCount = 1;
            this.DegreeImageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DegreeImageTableLayoutPanel.Size = new System.Drawing.Size(194, 69);
            this.DegreeImageTableLayoutPanel.TabIndex = 1;
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DegreeLabel.Location = new System.Drawing.Point(51, 0);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(91, 69);
            this.DegreeLabel.TabIndex = 0;
            this.DegreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 112);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(194, 37);
            this.DescriptionLabel.TabIndex = 2;
            // 
            // LastUpdateTimeLabel
            // 
            this.LastUpdateTimeLabel.AutoSize = true;
            this.LastUpdateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastUpdateTimeLabel.Location = new System.Drawing.Point(3, 149);
            this.LastUpdateTimeLabel.Name = "LastUpdateTimeLabel";
            this.LastUpdateTimeLabel.Size = new System.Drawing.Size(194, 18);
            this.LastUpdateTimeLabel.TabIndex = 3;
            this.LastUpdateTimeLabel.Text = "Last updated at ";
            this.LastUpdateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentTemperatureAdditionalInfoTableLayoutPanel
            // 
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.ColumnCount = 3;
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.Controls.Add(this.PressureLabel, 0, 0);
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.Controls.Add(this.HumidityLabel, 1, 0);
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.Controls.Add(this.WindLabel, 2, 0);
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 170);
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.Name = "CurrentTemperatureAdditionalInfoTableLayoutPanel";
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.RowCount = 1;
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.Size = new System.Drawing.Size(194, 15);
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.TabIndex = 4;
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PressureLabel.Location = new System.Drawing.Point(3, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(58, 15);
            this.PressureLabel.TabIndex = 0;
            this.PressureLabel.Text = "Pressure";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(67, 0);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(47, 13);
            this.HumidityLabel.TabIndex = 1;
            this.HumidityLabel.Text = "Humidity";
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindLabel
            // 
            this.WindLabel.AutoSize = true;
            this.WindLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindLabel.Location = new System.Drawing.Point(131, 0);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(60, 15);
            this.WindLabel.TabIndex = 2;
            this.WindLabel.Text = "Wind ";
            this.WindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainInfoView";
            this.Size = new System.Drawing.Size(760, 802);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.CitySettingsTableLayoutPanel.ResumeLayout(false);
            this.WeatherInfoWrapperPanel.ResumeLayout(false);
            this.WeatherInfoWrapperPanel.PerformLayout();
            this.WeatherInfoTableLayoutPanel.ResumeLayout(false);
            this.CurrentTemperatureTableLayoutPanelWrapper.ResumeLayout(false);
            this.CurrentTemperatureTableLayoutPanel.ResumeLayout(false);
            this.CurrentTemperatureTableLayoutPanel.PerformLayout();
            this.DegreeImageTableLayoutPanel.ResumeLayout(false);
            this.DegreeImageTableLayoutPanel.PerformLayout();
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.ResumeLayout(false);
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CitySettingsTableLayoutPanel;
        private System.Windows.Forms.Button RemoveCityButton;
        private System.Windows.Forms.Button AddCityButton;
        private System.Windows.Forms.ComboBox CitiesComboBox;
        private System.Windows.Forms.Panel WeatherInfoWrapperPanel;
        private System.Windows.Forms.TableLayoutPanel WeatherInfoTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CurrentTemperatureTableLayoutPanelWrapper;
        private System.Windows.Forms.TableLayoutPanel CurrentTemperatureTableLayoutPanel;
        private System.Windows.Forms.Label CityNameLabel;
        private System.Windows.Forms.TableLayoutPanel DegreeImageTableLayoutPanel;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label LastUpdateTimeLabel;
        private System.Windows.Forms.TableLayoutPanel CurrentTemperatureAdditionalInfoTableLayoutPanel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WindLabel;
    }
}
