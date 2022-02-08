using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms.Static
{
    public partial class Runing_Static : Form
    {
//Задание 5
//Разработать приложение «убегающий статик»:) Суть приложения:на форме расположен статический элемент 
//управления(«статик»). Пользователь пытается подвести курсор мыши к «статику», и, если курсор находиться
//близко со статиком, элемент управления «убегает». Предусмотреть перемещение «статика» только в пределах формы.

// У меня статик - это картинка мухи, чтоб интересней гонятся было
        public Runing_Static()
        {
            InitializeComponent();
        }

        private void btnStatic_MouseMove(object sender, MouseEventArgs e)
        {
            //т.к. не сказано как именно он убегает - то рандомно :)
            Random r = new Random();
            btnStatic.Left = r.Next(0, this.ClientSize.Width - btnStatic.Width);
            btnStatic.Top = r.Next(0, this.ClientSize.Height - btnStatic.Height);
        }
    }
}
