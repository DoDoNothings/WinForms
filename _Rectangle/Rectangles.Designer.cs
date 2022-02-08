
namespace BeginingWinForms._Rectangle
{
    partial class Rectangles
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
            this.labelRectanglePosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRectanglePosition
            // 
            this.labelRectanglePosition.AutoSize = true;
            this.labelRectanglePosition.Location = new System.Drawing.Point(7, 395);
            this.labelRectanglePosition.Name = "labelRectanglePosition";
            this.labelRectanglePosition.Size = new System.Drawing.Size(50, 20);
            this.labelRectanglePosition.TabIndex = 0;
            this.labelRectanglePosition.Text = "label1";
            // 
            // Rectangles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRectanglePosition);
            this.Name = "Rectangles";
            this.Text = "Rectangles";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rectangles_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rectangles_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rectangles_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRectanglePosition;
    }
}