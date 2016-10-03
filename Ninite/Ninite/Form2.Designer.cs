namespace Ninite
{
    partial class FormAddPrograms
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
            this.clbPrograms = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbPrograms
            // 
            this.clbPrograms.FormattingEnabled = true;
            this.clbPrograms.Location = new System.Drawing.Point(12, 12);
            this.clbPrograms.Name = "clbPrograms";
            this.clbPrograms.Size = new System.Drawing.Size(260, 229);
            this.clbPrograms.TabIndex = 0;
            // 
            // FormAddPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.clbPrograms);
            this.Name = "FormAddPrograms";
            this.Text = "Add Programs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbPrograms;
    }
}