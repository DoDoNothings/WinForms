using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms.Game
{
    public class Hidden_Number : Form
    {
        #region Задание 2
//Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. Для запроса к пользователю использовать
//MessageBox.После того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого, и предоставить
//пользователю возможность сыграть еще раз, не выходя из программы (MessageBox’ы оформляются кнопками и значками соответственно ситуации).
        public static void Play()
        {
            DialogResult result;
            int numQuery = 1;
            Boolean exit = true;
            while (exit)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Задуманное число",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Количество попыток = {numQuery}", "Число угадано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numQuery = 0;
                    result = MessageBox.Show($"Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) exit=false;
                }
                numQuery++;
            }
        }
    }
}
#endregion
