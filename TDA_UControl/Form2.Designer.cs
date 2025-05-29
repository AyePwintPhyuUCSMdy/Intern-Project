namespace Dashboard
{
    partial class Form2
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
            this.testUserControl12 = new Dashboard.TestUserControl1();
            this.SuspendLayout();
            // 
            // testUserControl12
            // 
            this.testUserControl12.Location = new System.Drawing.Point(0, 0);
            this.testUserControl12.MinimumSize = new System.Drawing.Size(84, 53);
            this.testUserControl12.Name = "testUserControl12";
            this.testUserControl12.Size = new System.Drawing.Size(206, 315);
            this.testUserControl12.TabIndex = 1;
            this.testUserControl12.Title = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 276);
            this.Controls.Add(this.testUserControl12);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private TestUserControl1 testUserControl12;
    }
}