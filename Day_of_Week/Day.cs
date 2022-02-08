using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms.Day_of_Week
{
//Написать программу, которая по введенной дате определяет день
//недели.Результат выводить в текстовое поле (желательно по-русски).
    public partial class Day : Form
    {
        public Day()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxDay.Text == "")
            {
                //заглавные русские буквы дня недели
                DayOfWeek.Text = dateTimePicker.Value.Date.ToString("dddd").ToUpper();
                DayOfWeek.BackColor = Color.Aquamarine;//подцветка 
                maskedTextBoxDay.Text = dateTimePicker.Value.ToShortDateString();
               
            }
            else
            {
                try
                {
                    DateTime day = new DateTime();
                    day = DateTime.Parse(maskedTextBoxDay.Text);
                    DayOfWeek.Text = day.ToString("dddd").ToUpper();
                    DayOfWeek.BackColor = Color.Aquamarine;
                    dateTimePicker.Value = day;                    
                }
                catch (Exception)//ошибки
                {                   
                    maskedTextBoxDay.BackColor = Color.Yellow;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            maskedTextBoxDay.Clear();
            DayOfWeek.Clear();
            maskedTextBoxDay.BackColor = Color.White;            
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
