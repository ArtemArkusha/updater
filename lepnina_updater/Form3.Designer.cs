namespace lepnina_updater
{
    partial class Form3
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
            this.RT_box2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RT_box2
            // 
            this.RT_box2.Location = new System.Drawing.Point(12, 12);
            this.RT_box2.Name = "RT_box2";
            this.RT_box2.Size = new System.Drawing.Size(392, 173);
            this.RT_box2.TabIndex = 0;
            this.RT_box2.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 197);
            this.Controls.Add(this.RT_box2);
            this.Name = "Form3";
            this.Text = "Creater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RT_box2;
    }
}