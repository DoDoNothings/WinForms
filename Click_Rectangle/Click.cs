using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms.Click_Rectangle
{
    public partial class Click : Form
    {
//Задание 3
//Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей
//области формы.
        public Click()
        {
            InitializeComponent();
        }

        //- Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна
        //текущие координаты мыши x и y.
        private void Click_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X = {e.X},  Y = {e.Y}";
        }

        //- Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
        //(рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
        private void Click_MouseDown(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Right)
                {
                    Text = $"Область окна : ширина = {ClientSize.Width} , высота = {ClientSize.Height}";
                }
        }

        private void Click_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }
                string text;
                //- Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: вну-
                //три прямоугольника, снаружи, на границе прямоугольника.
                if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    text = "Снаружи прямоугольника!";
                }
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    text = "На границе прямоугольника!";
                }
                else
                {
                    text = "Внутри прямоугольника";
                }
                MessageBox.Show(text, "Текущая точка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
