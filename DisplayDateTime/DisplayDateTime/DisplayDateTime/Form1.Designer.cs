namespace DisplayDateTime
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
            this.getDate = new System.Windows.Forms.Button();
            this.displayedDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getDate
            // 
            this.getDate.Location = new System.Drawing.Point(102, 196);
            this.getDate.Name = "getDate";
            this.getDate.Size = new System.Drawing.Size(75, 23);
            this.getDate.TabIndex = 0;
            this.getDate.Text = "Get Date";
            this.getDate.UseVisualStyleBackColor = true;
            this.getDate.Click += new System.EventHandler(this.getDate_Click);
            // 
            // displayedDate
            // 
            this.displayedDate.AutoSize = true;
            this.displayedDate.Location = new System.Drawing.Point(117, 102);
            this.displayedDate.Name = "displayedDate";
            this.displayedDate.Size = new System.Drawing.Size(35, 13);
            this.displayedDate.TabIndex = 1;
            this.displayedDate.Text = "empty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.displayedDate);
            this.Controls.Add(this.getDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDate;
        private System.Windows.Forms.Label displayedDate;
    }
}

