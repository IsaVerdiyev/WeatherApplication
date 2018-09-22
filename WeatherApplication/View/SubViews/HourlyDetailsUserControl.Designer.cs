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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HourlyDetailsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.HourlyDetailsTableLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 345);
            this.panel1.TabIndex = 0;
            // 
            // HourlyDetailsTableLayoutPanel
            // 
            this.HourlyDetailsTableLayoutPanel.AutoSize = true;
            this.HourlyDetailsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HourlyDetailsTableLayoutPanel.ColumnCount = 1;
            this.HourlyDetailsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlyDetailsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HourlyDetailsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HourlyDetailsTableLayoutPanel.Name = "HourlyDetailsTableLayoutPanel";
            this.HourlyDetailsTableLayoutPanel.RowCount = 1;
            this.HourlyDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HourlyDetailsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.HourlyDetailsTableLayoutPanel.Size = new System.Drawing.Size(0, 345);
            this.HourlyDetailsTableLayoutPanel.TabIndex = 1;
            // 
            // HourlyDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HourlyDetailsUserControl";
            this.Size = new System.Drawing.Size(754, 345);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel HourlyDetailsTableLayoutPanel;
    }
}
