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
            this.DailyWrapperTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DailyWeatherInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionLabelOfDay = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.HourlyColumnTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HourlySettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel.SuspendLayout();
            this.CitySettingsTableLayoutPanel.SuspendLayout();
            this.WeatherInfoWrapperPanel.SuspendLayout();
            this.WeatherInfoTableLayoutPanel.SuspendLayout();
            this.CurrentTemperatureTableLayoutPanelWrapper.SuspendLayout();
            this.CurrentTemperatureTableLayoutPanel.SuspendLayout();
            this.DegreeImageTableLayoutPanel.SuspendLayout();
            this.CurrentTemperatureAdditionalInfoTableLayoutPanel.SuspendLayout();
            this.DailyWrapperTableLayoutPanel.SuspendLayout();
            this.DailyWeatherInfoTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.HourlyColumnTableLayoutPanel.SuspendLayout();
            this.HourlySettingsTableLayoutPanel.SuspendLayout();
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
            this.WeatherInfoTableLayoutPanel.Controls.Add(this.DailyWrapperTableLayoutPanel, 0, 1);
            this.WeatherInfoTableLayoutPanel.Controls.Add(this.HourlyColumnTableLayoutPanel, 0, 2);
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
            // DailyWrapperTableLayoutPanel
            // 
            this.DailyWrapperTableLayoutPanel.ColumnCount = 1;
            this.DailyWrapperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DailyWrapperTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.DailyWrapperTableLayoutPanel.Controls.Add(this.DailyWeatherInfoTableLayoutPanel, 0, 1);
            this.DailyWrapperTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyWrapperTableLayoutPanel.Location = new System.Drawing.Point(3, 203);
            this.DailyWrapperTableLayoutPanel.Name = "DailyWrapperTableLayoutPanel";
            this.DailyWrapperTableLayoutPanel.RowCount = 2;
            this.DailyWrapperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DailyWrapperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.DailyWrapperTableLayoutPanel.Size = new System.Drawing.Size(748, 194);
            this.DailyWrapperTableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailyWeatherInfoTableLayoutPanel
            // 
            this.DailyWeatherInfoTableLayoutPanel.ColumnCount = 5;
            this.DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DailyWeatherInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DailyWeatherInfoTableLayoutPanel.Controls.Add(this.tableLayoutPanel5, 4, 0);
            this.DailyWeatherInfoTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.DailyWeatherInfoTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.DailyWeatherInfoTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.DailyWeatherInfoTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.DailyWeatherInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyWeatherInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 41);
            this.DailyWeatherInfoTableLayoutPanel.Name = "DailyWeatherInfoTableLayoutPanel";
            this.DailyWeatherInfoTableLayoutPanel.RowCount = 1;
            this.DailyWeatherInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DailyWeatherInfoTableLayoutPanel.Size = new System.Drawing.Size(742, 150);
            this.DailyWeatherInfoTableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(595, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(144, 144);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 36);
            this.label11.TabIndex = 3;
            this.label11.Text = "label2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 36);
            this.label12.TabIndex = 2;
            this.label12.Text = "label2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 36);
            this.label13.TabIndex = 0;
            this.label13.Text = "label2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(447, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(142, 144);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 36);
            this.label8.TabIndex = 3;
            this.label8.Text = "label2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 36);
            this.label9.TabIndex = 2;
            this.label9.Text = "label2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 36);
            this.label10.TabIndex = 0;
            this.label10.Text = "label2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(299, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(142, 144);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "label2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "label2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "label2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(151, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(142, 144);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "label2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "label2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DescriptionLabelOfDay, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TempLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DateLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(142, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DescriptionLabelOfDay
            // 
            this.DescriptionLabelOfDay.AutoSize = true;
            this.DescriptionLabelOfDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabelOfDay.Location = new System.Drawing.Point(3, 108);
            this.DescriptionLabelOfDay.Name = "DescriptionLabelOfDay";
            this.DescriptionLabelOfDay.Size = new System.Drawing.Size(136, 36);
            this.DescriptionLabelOfDay.TabIndex = 3;
            this.DescriptionLabelOfDay.Text = "label2";
            this.DescriptionLabelOfDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TempLabel.Location = new System.Drawing.Point(3, 72);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(136, 36);
            this.TempLabel.TabIndex = 2;
            this.TempLabel.Text = "label2";
            this.TempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Location = new System.Drawing.Point(3, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(136, 36);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "label2";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourlyColumnTableLayoutPanel
            // 
            this.HourlyColumnTableLayoutPanel.ColumnCount = 1;
            this.HourlyColumnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlyColumnTableLayoutPanel.Controls.Add(this.HourlySettingsTableLayoutPanel, 0, 0);
            this.HourlyColumnTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourlyColumnTableLayoutPanel.Location = new System.Drawing.Point(3, 403);
            this.HourlyColumnTableLayoutPanel.Name = "HourlyColumnTableLayoutPanel";
            this.HourlyColumnTableLayoutPanel.RowCount = 2;
            this.HourlyColumnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HourlyColumnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.HourlyColumnTableLayoutPanel.Size = new System.Drawing.Size(748, 194);
            this.HourlyColumnTableLayoutPanel.TabIndex = 2;
            // 
            // HourlySettingsTableLayoutPanel
            // 
            this.HourlySettingsTableLayoutPanel.ColumnCount = 4;
            this.HourlySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HourlySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HourlySettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HourlySettingsTableLayoutPanel.Controls.Add(this.label14, 0, 0);
            this.HourlySettingsTableLayoutPanel.Controls.Add(this.SummaryButton, 2, 0);
            this.HourlySettingsTableLayoutPanel.Controls.Add(this.DetailsButton, 3, 0);
            this.HourlySettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourlySettingsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.HourlySettingsTableLayoutPanel.Name = "HourlySettingsTableLayoutPanel";
            this.HourlySettingsTableLayoutPanel.RowCount = 1;
            this.HourlySettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlySettingsTableLayoutPanel.Size = new System.Drawing.Size(742, 32);
            this.HourlySettingsTableLayoutPanel.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Hourly";
            // 
            // SummaryButton
            // 
            this.SummaryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryButton.Location = new System.Drawing.Point(583, 3);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(75, 26);
            this.SummaryButton.TabIndex = 1;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsButton.Location = new System.Drawing.Point(664, 3);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(75, 26);
            this.DetailsButton.TabIndex = 2;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
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
            this.DailyWrapperTableLayoutPanel.ResumeLayout(false);
            this.DailyWrapperTableLayoutPanel.PerformLayout();
            this.DailyWeatherInfoTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.HourlyColumnTableLayoutPanel.ResumeLayout(false);
            this.HourlySettingsTableLayoutPanel.ResumeLayout(false);
            this.HourlySettingsTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel DailyWrapperTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel DailyWeatherInfoTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DescriptionLabelOfDay;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TableLayoutPanel HourlyColumnTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel HourlySettingsTableLayoutPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button DetailsButton;
    }
}
