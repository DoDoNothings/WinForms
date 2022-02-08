using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms.Resume
{

    #region//Задание 1
    //Вывести на экран свое(краткое!!!) резюме с помощью последовательности MessageBox’ов(числом не менее трех). Причем на заголовке
    //последнего должно отобразиться среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов).
    public class Resume_
    {
        public static DialogResult ShowMessageBoxes()
        {
            int numSymbol = 0;
            int numMessage = 0;

            String message = "20.02.1986 \n г.Донецк / Николаев \n Замужем. Трое детей";
            numSymbol += message.ToArray().Length;
            numMessage++;
            String title = "Общая информация";
            MessageBox.Show(message, title);

            message = " 2003-2008 - ДонНТУ - Учёт и аудит " +
                "\n\n 2009-2011 - ДонНТУ - Программированив в Internet и администрирование компьютерных систем " +
                "\n\n 2020-н.в. - Компьютеная академия ШАГ - Разработка ПО";
            title = "Образование";
            DialogResult result = MessageBox.Show(message, title);
            numSymbol += message.ToArray().Length;
            numMessage++;

            message = " 2005-2010 - ООО Стройэксклюзивпласт - Бухгалтер" +
                "\n\n 2010-2011 - ГФУ ДОГА - Инспектор отдела контроля и гос.обеспечения " +
                "\n\n 2011-н.в. - Департамент Финансов ДОГА - гл.специалист отдела финансов, бух.учета и отчетности";
            title = "Трудовая деятельность";
            result = MessageBox.Show(message, title);
            numSymbol += message.ToArray().Length;
            numMessage++;

            message = "Знание английского языка \nБыстро обучаюсь \nОтветственная \nОпыт работы в электронно-юридических системах";
            numSymbol += message.ToArray().Length;
            numMessage++;
            title = $"Среднее число символов на стр = {numSymbol / numMessage}";
            result = MessageBox.Show(message, title);

            return result;
        }
    }
}
#endregion
