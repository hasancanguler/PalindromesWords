namespace SearchForString
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.Button();
            this.lstFound = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 38);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(648, 123);
            this.txtString.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 167);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(188, 23);
            this.txtAra.TabIndex = 1;
            this.txtAra.Text = "Ara";
            this.txtAra.UseVisualStyleBackColor = true;
            this.txtAra.Click += new System.EventHandler(this.txtAra_Click);
            // 
            // lstFound
            // 
            this.lstFound.FormattingEnabled = true;
            this.lstFound.Location = new System.Drawing.Point(12, 196);
            this.lstFound.Name = "lstFound";
            this.lstFound.Size = new System.Drawing.Size(188, 225);
            this.lstFound.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFound);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button txtAra;
        private System.Windows.Forms.ListBox lstFound;
    }
}

