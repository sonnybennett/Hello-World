namespace Hello_World
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.sonny = new System.Windows.Forms.TextBox();
            this.Sam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(336, 176);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 1;
            // 
            // sonny
            // 
            this.sonny.Location = new System.Drawing.Point(101, 190);
            this.sonny.Name = "sonny";
            this.sonny.Size = new System.Drawing.Size(100, 20);
            this.sonny.TabIndex = 2;
            this.sonny.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Sam
            // 
            this.Sam.Location = new System.Drawing.Point(116, 252);
            this.Sam.Name = "Sam";
            this.Sam.Size = new System.Drawing.Size(100, 20);
            this.Sam.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sam);
            this.Controls.Add(this.sonny);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox sonny;
        private System.Windows.Forms.TextBox Sam;
    }
}

