﻿namespace WeatherApplication.View.SubViews
{
    partial class GraphUserControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HourlyGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // HourlyGraphic
            // 
            chartArea1.Name = "ChartArea1";
            this.HourlyGraphic.ChartAreas.Add(chartArea1);
            this.HourlyGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.HourlyGraphic.Legends.Add(legend1);
            this.HourlyGraphic.Location = new System.Drawing.Point(0, 0);
            this.HourlyGraphic.Name = "HourlyGraphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Hours";
            this.HourlyGraphic.Series.Add(series1);
            this.HourlyGraphic.Size = new System.Drawing.Size(798, 230);
            this.HourlyGraphic.TabIndex = 0;
            this.HourlyGraphic.Text = "chart1";
            // 
            // GraphUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HourlyGraphic);
            this.Name = "GraphUserControl";
            this.Size = new System.Drawing.Size(798, 230);
            ((System.ComponentModel.ISupportInitialize)(this.HourlyGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart HourlyGraphic;
    }
}
