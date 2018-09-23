namespace WeatherApplication.View.SubViews
{
    partial class NoCitiesView
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
            this.NoCitiesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoCitiesLabel
            // 
            this.NoCitiesLabel.AutoSize = true;
            this.NoCitiesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoCitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoCitiesLabel.Location = new System.Drawing.Point(0, 0);
            this.NoCitiesLabel.Name = "NoCitiesLabel";
            this.NoCitiesLabel.Size = new System.Drawing.Size(545, 42);
            this.NoCitiesLabel.TabIndex = 0;
            this.NoCitiesLabel.Text = "There is no city. Add city please";
            this.NoCitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoCitiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoCitiesLabel);
            this.Name = "NoCitiesView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoCitiesLabel;
    }
}
