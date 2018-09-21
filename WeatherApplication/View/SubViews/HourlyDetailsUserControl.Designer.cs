namespace WeatherApplication.View.SubViews
{
    partial class HourlyDetailsUserControl
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
            this.HourlyDetailsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // HourlyDetailsTableLayoutPanel
            // 
            this.HourlyDetailsTableLayoutPanel.ColumnCount = 1;
            this.HourlyDetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlyDetailsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourlyDetailsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HourlyDetailsTableLayoutPanel.Name = "HourlyDetailsTableLayoutPanel";
            this.HourlyDetailsTableLayoutPanel.RowCount = 1;
            this.HourlyDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlyDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.HourlyDetailsTableLayoutPanel.Size = new System.Drawing.Size(754, 345);
            this.HourlyDetailsTableLayoutPanel.TabIndex = 0;
            // 
            // HourlyDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HourlyDetailsTableLayoutPanel);
            this.Name = "HourlyDetailsUserControl";
            this.Size = new System.Drawing.Size(754, 345);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HourlyDetailsTableLayoutPanel;
    }
}
