
namespace BeginingWinForms.Static
{
    partial class Runing_Static
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Runing_Static));
            this.btnStatic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatic
            // 
            this.btnStatic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatic.Image = ((System.Drawing.Image)(resources.GetObject("btnStatic.Image")));
            this.btnStatic.Location = new System.Drawing.Point(409, 200);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(101, 93);
            this.btnStatic.TabIndex = 0;
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnStatic_MouseMove);
            // 
            // Runing_Static
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 549);
            this.Controls.Add(this.btnStatic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Runing_Static";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runing_Static";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatic;
    }
}