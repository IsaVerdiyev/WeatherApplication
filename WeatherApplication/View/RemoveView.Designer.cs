namespace WeatherApplication.View
{
    partial class RemoveView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CitiesListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CitiesListBox
            // 
            this.CitiesListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CitiesListBox.FormattingEnabled = true;
            this.CitiesListBox.Location = new System.Drawing.Point(0, 0);
            this.CitiesListBox.Name = "CitiesListBox";
            this.CitiesListBox.Size = new System.Drawing.Size(237, 134);
            this.CitiesListBox.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveButton.Location = new System.Drawing.Point(0, 134);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(119, 45);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelButton.Location = new System.Drawing.Point(115, 134);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(122, 45);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemoveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 179);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CitiesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveView";
            this.Text = "RemoveView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CitiesListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}