using System;
using System.Windows.Forms;

namespace BeginingWinForms.Oil
{
    public partial class BestOil : Form
    {
        double[] oil = { 35.84, 34.99, 35.30, 19.65 };//цена топлива
        int tempTimer = 0;//итератор таймера
        double Total { get; set; } = 0;//общая сумма
        double PayCafe { get; set; } = 0;//сумма кафе
        double PayOil { get; set; } = 0;//сумма за бензин

        //Если выбран переключатель количества бензина в литрах
        private void rbCountOil_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCount.ReadOnly = false;
            textBoxSum.ReadOnly = true;
            groupBoxOil.Text = "До сплати";
            label_oil.Text = "грн.";
            textBoxSum.Text = "0,00";
            ForPayOil.Text = "0,00";
            textBoxCount.Focus();
        }

        //если выбран переключатель сумма на сколько надо заправить
        private void rbSumOil_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCount.ReadOnly = true;
            textBoxSum.ReadOnly = false;
            textBoxCount.Text = "0,00";
            groupBoxOil.Text = "Заправити";
            label_oil.Text = "л.";
            ForPayOil.Text = "0,00";
            textBoxSum.Focus();
        }

        //ввод количества литров
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCountOil.Checked)
                {
                    if (textBoxCount.Text != null)
                    {
                        PayOil = Math.Round(double.Parse(Price.Text) * double.Parse(textBoxCount.Text), 2);
                        ForPayOil.Text = Math.Round(double.Parse(Price.Text) * double.Parse(textBoxCount.Text), 2).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //если ввводится сумма денег на бензин
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbSumOil.Checked)
                {
                    if (textBoxSum.Text != null)
                    {
                        PayOil = Math.Round(double.Parse(textBoxSum.Text), 2);
                        ForPayOil.Text = Math.Round(double.Parse(textBoxSum.Text) / double.Parse(Price.Text), 2).ToString();
                   
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //при закрытиии формы
        private void BestOil_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (Total == 0)
            {
                MessageBox.Show($"Продаж нет!", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Сумма выручки за {DateTime.Now.ToShortDateString()} = {Math.Round(Total, 2)} грн.", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //хотдог
        private void cbHotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHotdog.Checked)
            {
                CountHotdog.ReadOnly = false;
                CountHotdog.Focus();
            }
            else
            {
                PayCafe -= (double.Parse(PriceHotdog.Text) * double.Parse(CountHotdog.Text));
                CountHotdog.ReadOnly = true;
                CountHotdog.Text = "0";
                ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
            }
        }

        //количество хотдогов
        private void CountHotdog_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CountHotdog.Text != "")
                {
                    PayCafe += (double.Parse(PriceHotdog.Text) * double.Parse(CountHotdog.Text));
                    ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
                }
            }
            catch (Exception)
            {
                CountHotdog.Text = "0";
                MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //гамбургер
        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (Hamburger.Checked)
            {
                CountHamburger.ReadOnly = false;
                CountHamburger.Focus();
            }
            else
            {
                PayCafe -= (double.Parse(PriceHamburger.Text) * double.Parse(CountHamburger.Text));
                CountHamburger.ReadOnly = true;
                CountHamburger.Text = "0";
                ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
            }
        }

        //количество гамбургеров
        private void CountHamburger_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CountHamburger.Text != "")
                {
                    PayCafe += (double.Parse(PriceHamburger.Text) * double.Parse(CountHamburger.Text));
                    ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
                }
            }
            catch (Exception)
            {
                CountHamburger.Text = "0";
                MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //картошка фри
        private void Potatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (Potatoes.Checked)
            {
                CountPotatoes.ReadOnly = false;
                CountPotatoes.Focus();
            }
            else
            {
                PayCafe -= (double.Parse(PricePotatoes.Text) * double.Parse(CountPotatoes.Text));
                CountPotatoes.ReadOnly = true;
                CountPotatoes.Text = "0";
                ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
            }
        }

        //количество картошки фри
        private void CountPotatoes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CountPotatoes.Text != "")
                {
                    PayCafe += (double.Parse(PricePotatoes.Text) * double.Parse(CountPotatoes.Text));
                    ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
                }
            }
            catch (Exception)
            {
                CountPotatoes.Text = "0";
                MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //кока-кола
        private void CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola.Checked)
            {
                CountCocaCola.ReadOnly = false;
                CountCocaCola.Focus();
            }
            else
            {
                PayCafe -= (double.Parse(PriceCocacola.Text) * double.Parse(CountCocaCola.Text));
                CountCocaCola.ReadOnly = true;
                CountCocaCola.Text = "0";
                ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
            }
        }

        //количество кока-колы
        private void CountCocaCola_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CountCocaCola.Text != "")
                {
                    PayCafe += (double.Parse(PriceCocacola.Text) * double.Parse(CountCocaCola.Text));
                    ForPayCafe.Text = Math.Round(PayCafe, 0).ToString();
                }
            }
            catch (Exception)
            {
                CountCocaCola.Text = "0";
                MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка порахувати
        private void TotalSum_Click(object sender, EventArgs e)
        {
            if (PayOil + double.Parse(ForPayCafe.Text) != 0)
            {
                Total = (Math.Round((PayOil + double.Parse(ForPayCafe.Text)), 2));

                TotalPay.Text = (Math.Round((PayOil + double.Parse(ForPayCafe.Text)), 2)).ToString();

                Timer.Start();
            }
            else
            {
                MessageBox.Show("Ничего не выбрано", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //таймер на продолжение/отмену
        private void Timer_Tick_1(object sender, EventArgs e)
        {
            Timer s = sender as Timer;
            tempTimer++;
            if (tempTimer == 10)
            {
                DialogResult result = MessageBox.Show("Завершить работу с этим клиентом?", "Очистить форму?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Total = (Math.Round((PayOil + double.Parse(ForPayCafe.Text)), 2));
                    Timer.Stop();
                    ForPayCafe.Text = "0,00";
                    ForPayOil.Text = "0,00";
                    rbCountOil.Checked = false;
                    rbSumOil.Checked = false;
                    Price.Text = "";
                    CocaCola.Checked = false;
                    Hamburger.Checked = false;
                    cbHotdog.Checked = false;
                    Potatoes.Checked = false;
                    textBoxCount.Text = "";
                    textBoxSum.Text = "";
                    tempTimer = 0;
                    TotalPay.Text = "0,00";
                    Money.Text = "";
                    Dacha.Text = "0,00";
                    comboBox1.SelectedIndex = -1;
                }
                else
                {
                    tempTimer = 0;
                }
            }
        }

        //кнока решта
        private void btnDacha_Click_1(object sender, EventArgs e)
        {
            if (Money.Text != "")
            {
                try
                {
                    if (double.Parse(Money.Text) > double.Parse(TotalPay.Text))
                        Dacha.Text = (Math.Round((double.Parse(Money.Text) - double.Parse(TotalPay.Text)), 2)).ToString();
                    else
                        MessageBox.Show($"Недостаточно денег! Ещё необходимо {(Math.Round((double.Parse(Money.Text) - double.Parse(TotalPay.Text)), 2)).ToString()}",
                            "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int CountOil = 4;//количество наименований бензина +

        //цена на бензин
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox radio = sender as ComboBox;
            for (int i = 0; i < CountOil; i++)
            {
                if (radio.SelectedIndex == i)
                {
                    Price.Text = $"{oil[i]}";
                }
            }
        }

        public BestOil()
        {
            InitializeComponent();
        }
    }
}
