
namespace BeginingWinForms.CountDays
{
    partial class Count_days
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
            this.rbYears = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDays = new System.Windows.Forms.RadioButton();
            this.rbMinuts = new System.Windows.Forms.RadioButton();
            this.rbSec = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnResert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbYears
            // 
            this.rbYears.AutoSize = true;
            this.rbYears.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbYears.Location = new System.Drawing.Point(22, 20);
            this.rbYears.Name = "rbYears";
            this.rbYears.Size = new System.Drawing.Size(96, 31);
            this.rbYears.TabIndex = 0;
            this.rbYears.TabStop = true;
            this.rbYears.Text = "в годах";
            this.rbYears.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMonth.Location = new System.Drawing.Point(124, 20);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(121, 31);
            this.rbMonth.TabIndex = 1;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "в месяцах";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbDays
            // 
            this.rbDays.AutoSize = true;
            this.rbDays.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDays.Location = new System.Drawing.Point(262, 20);
            this.rbDays.Name = "rbDays";
            this.rbDays.Size = new System.Drawing.Size(89, 31);
            this.rbDays.TabIndex = 2;
            this.rbDays.TabStop = true;
            this.rbDays.Text = "в днях";
            this.rbDays.UseVisualStyleBackColor = true;
            // 
            // rbMinuts
            // 
            this.rbMinuts.AutoSize = true;
            this.rbMinuts.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMinuts.Location = new System.Drawing.Point(357, 20);
            this.rbMinuts.Name = "rbMinuts";
            this.rbMinuts.Size = new System.Drawing.Size(126, 31);
            this.rbMinuts.TabIndex = 3;
            this.rbMinuts.TabStop = true;
            this.rbMinuts.Text = "в минутах";
            this.rbMinuts.UseVisualStyleBackColor = true;
            // 
            // rbSec
            // 
            this.rbSec.AutoSize = true;
            this.rbSec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSec.Location = new System.Drawing.Point(489, 20);
            this.rbSec.Name = "rbSec";
            this.rbSec.Size = new System.Drawing.Size(129, 31);
            this.rbSec.TabIndex = 4;
            this.rbSec.TabStop = true;
            this.rbSec.Text = "в секундах";
            this.rbSec.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(438, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnResert
            // 
            this.btnResert.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResert.Location = new System.Drawing.Point(174, 301);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(94, 40);
            this.btnResert.TabIndex = 6;
            this.btnResert.Text = "Сброс";
            this.btnResert.UseVisualStyleBackColor = true;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Осталось";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCount.Location = new System.Drawing.Point(267, 222);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(171, 34);
            this.textBoxCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите дату";
            // 
            // mTextBoxDate
            // 
            this.mTextBoxDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mTextBoxDate.Location = new System.Drawing.Point(267, 24);
            this.mTextBoxDate.Mask = "00/00/0000";
            this.mTextBoxDate.Name = "mTextBoxDate";
            this.mTextBoxDate.Size = new System.Drawing.Size(175, 34);
            this.mTextBoxDate.TabIndex = 11;
            this.mTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbYears);
            this.panel1.Controls.Add(this.rbMonth);
            this.panel1.Controls.Add(this.rbDays);
            this.panel1.Controls.Add(this.rbMinuts);
            this.panel1.Controls.Add(this.rbSec);
            this.panel1.Location = new System.Drawing.Point(23, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 72);
            this.panel1.TabIndex = 12;
            // 
            // Count_days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mTextBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Count_days";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count_days";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbYears;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbDays;
        private System.Windows.Forms.RadioButton rbMinuts;
        private System.Windows.Forms.RadioButton rbSec;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTextBoxDate;
        private System.Windows.Forms.Panel panel1;
    }
}