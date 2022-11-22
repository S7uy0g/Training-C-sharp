namespace Training
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heading = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Heading.Location = new System.Drawing.Point(277, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(273, 54);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Coder Finder";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(107, 75);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(150, 31);
            this.Username.TabIndex = 1;
            this.Username.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Heading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Heading;
        private TextBox Username;
    }
}