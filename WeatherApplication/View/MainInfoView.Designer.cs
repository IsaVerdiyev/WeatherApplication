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
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CityListBox
            // 
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.Location = new System.Drawing.Point(564, 50);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(120, 95);
            this.CityListBox.TabIndex = 0;
            this.CityListBox.SelectedIndexChanged += new System.EventHandler(this.CityListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(448, 50);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(448, 98);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(151, 50);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.FormattingEnabled = true;
            this.DescriptionListBox.Location = new System.Drawing.Point(106, 297);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.Size = new System.Drawing.Size(120, 95);
            this.DescriptionListBox.TabIndex = 4;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(586, 168);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 5;
            // 
            // MainInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CityListBox);
            this.Name = "MainInfoView";
            this.Size = new System.Drawing.Size(760, 802);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CityListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.TextBox CityTextBox;
    }
}
