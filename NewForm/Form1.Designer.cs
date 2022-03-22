
namespace NewForm
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
            this.Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(156, 127);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(106, 50);
            this.Click.TabIndex = 0;
            this.Click.Text = "button1";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.Click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 453);
            this.Controls.Add(this.Click);
            this.Name = "Form1";
            this.Text = "First Console";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Click;
    }
}

