namespace C04_P02
{
    partial class Form1
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
            this.WorkshopListbox = new System.Windows.Forms.ListBox();
            this.LocationListbox = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.DiscountGroupbox = new System.Windows.Forms.GroupBox();
            this.FivePercentButton = new System.Windows.Forms.RadioButton();
            this.TenPercentButton = new System.Windows.Forms.RadioButton();
            this.FifteenPercentButton = new System.Windows.Forms.RadioButton();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DiscountGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkshopListbox
            // 
            this.WorkshopListbox.FormattingEnabled = true;
            this.WorkshopListbox.ItemHeight = 20;
            this.WorkshopListbox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.WorkshopListbox.Location = new System.Drawing.Point(12, 12);
            this.WorkshopListbox.Name = "WorkshopListbox";
            this.WorkshopListbox.Size = new System.Drawing.Size(150, 124);
            this.WorkshopListbox.TabIndex = 0;
            // 
            // LocationListbox
            // 
            this.LocationListbox.FormattingEnabled = true;
            this.LocationListbox.ItemHeight = 20;
            this.LocationListbox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.LocationListbox.Location = new System.Drawing.Point(319, 12);
            this.LocationListbox.Name = "LocationListbox";
            this.LocationListbox.Size = new System.Drawing.Size(144, 124);
            this.LocationListbox.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 298);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(375, 293);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(88, 34);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Location = new System.Drawing.Point(137, 139);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(200, 30);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiscountGroupbox
            // 
            this.DiscountGroupbox.Controls.Add(this.DiscountLabel);
            this.DiscountGroupbox.Controls.Add(this.FifteenPercentButton);
            this.DiscountGroupbox.Controls.Add(this.FivePercentButton);
            this.DiscountGroupbox.Controls.Add(this.TenPercentButton);
            this.DiscountGroupbox.Location = new System.Drawing.Point(0, 2);
            this.DiscountGroupbox.Name = "DiscountGroupbox";
            this.DiscountGroupbox.Size = new System.Drawing.Size(479, 357);
            this.DiscountGroupbox.TabIndex = 5;
            this.DiscountGroupbox.TabStop = false;
            // 
            // FivePercentButton
            // 
            this.FivePercentButton.AutoSize = true;
            this.FivePercentButton.Location = new System.Drawing.Point(152, 178);
            this.FivePercentButton.Name = "FivePercentButton";
            this.FivePercentButton.Size = new System.Drawing.Size(188, 24);
            this.FivePercentButton.TabIndex = 6;
            this.FivePercentButton.TabStop = true;
            this.FivePercentButton.Text = "employed 1-2 Years ?";
            this.FivePercentButton.UseVisualStyleBackColor = true;
            // 
            // TenPercentButton
            // 
            this.TenPercentButton.AutoSize = true;
            this.TenPercentButton.Location = new System.Drawing.Point(152, 208);
            this.TenPercentButton.Name = "TenPercentButton";
            this.TenPercentButton.Size = new System.Drawing.Size(188, 24);
            this.TenPercentButton.TabIndex = 6;
            this.TenPercentButton.TabStop = true;
            this.TenPercentButton.Text = "employed 3-5 Years ?";
            this.TenPercentButton.UseVisualStyleBackColor = true;
            // 
            // FifteenPercentButton
            // 
            this.FifteenPercentButton.AutoSize = true;
            this.FifteenPercentButton.Location = new System.Drawing.Point(152, 238);
            this.FifteenPercentButton.Name = "FifteenPercentButton";
            this.FifteenPercentButton.Size = new System.Drawing.Size(187, 24);
            this.FifteenPercentButton.TabIndex = 6;
            this.FifteenPercentButton.TabStop = true;
            this.FifteenPercentButton.Text = "employed 5 + Years ?";
            this.FifteenPercentButton.UseVisualStyleBackColor = true;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiscountLabel.Location = new System.Drawing.Point(137, 292);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(200, 30);
            this.DiscountLabel.TabIndex = 8;
            this.DiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 358);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LocationListbox);
            this.Controls.Add(this.WorkshopListbox);
            this.Controls.Add(this.DiscountGroupbox);
            this.Name = "Form1";
            this.Text = "Workshop Training Cost Calculator";
            this.DiscountGroupbox.ResumeLayout(false);
            this.DiscountGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox WorkshopListbox;
        private System.Windows.Forms.ListBox LocationListbox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.GroupBox DiscountGroupbox;
        private System.Windows.Forms.RadioButton FifteenPercentButton;
        private System.Windows.Forms.RadioButton FivePercentButton;
        private System.Windows.Forms.RadioButton TenPercentButton;
        private System.Windows.Forms.Label DiscountLabel;
    }
}

