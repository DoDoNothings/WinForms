using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms.CountDays
{
//Задание 7
//Написать программу, вычисляющую сколько осталось времени до указанной даты
//(дата вводится с клавиатуры в Edit). Предусмотреть возможность выдачи результата в годах,
//месяцах, днях, минутах, секундах (для первых двух вариантов ответ дробный). Для переклю-
//чения между вариантами желательно использовать переключатели (RadioButton).
    public partial class Count_days : Form
    {
        public Count_days()
        {
            InitializeComponent();
            rbDays.Checked = true;//первоначально установлено на днях
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {               
                DateTime day = new DateTime();
                day = DateTime.Parse(mTextBoxDate.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan countDay = day - dayNow;
                if (day > dayNow)
                {
                    if (rbYears.Checked)
                    {
                        textBoxCount.Text = (countDay.TotalDays / 365).ToString("0.##");     
                    }
                    if (rbMonth.Checked)
                    {
                        textBoxCount.Text = (countDay.TotalDays / 30).ToString("0.##");
                    }
                    if (rbDays.Checked)
                    {
                        textBoxCount.Text = ((int)countDay.TotalDays).ToString();
                    }
                    if (rbMinuts.Checked)
                    {
                        textBoxCount.Text = ((int)countDay.TotalMinutes).ToString();
                    }
                    if (rbSec.Checked)
                    {
                        textBoxCount.Text = ((int)countDay.TotalSeconds).ToString();
                    }
                    textBoxCount.BackColor = Color.Aquamarine;
                }
                else
                {
                    textBoxCount.Text = "Дата прошла";
                    textBoxCount.BackColor = Color.Orange;
                }
            }
            catch (Exception)
            {
                mTextBoxDate.BackColor = Color.Yellow;
            }
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            textBoxCount.Clear();
            mTextBoxDate.Clear();           
            mTextBoxDate.BackColor = Color.White;
            textBoxCount.BackColor = Color.White;
        }
    }
}
