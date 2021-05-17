using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_MOD97_Csharp;
using console_DLL;

namespace Curs_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double num_country = 0;//-Номер країни при переводі буквенного значення у цифровий
        public decimal buff_digits;//Буфер для зберігання інформації в момент розрахунку
        public decimal buff_operation;//Буфер вибору операціі
        public string buff_word;//Буфер для формування коду у формат IBAN
        public string word_country;//Символьне представлення у форматі ALPHA-2
        public string IBAN_format;//кінцева строка IBAN
        public decimal kontrol_digits = 0;//контрольна сума
        public int size;//Розмір довжини номеру для обробки виключень
        public int size_MFO;//Розмір довжини коду МФО для обробки виключень
        double method_num_of_country()
        /* 
         * Метод для передачі значень 
         * num_country
         * word_country
         * size_MFO
         * size
         * Все залежить від вибору країни
         */
        {
            if (collection_of_countries.Text == "Німеччина(DE)")
            {
                num_country = 1314;
                word_country = "DE";
                size_MFO = 8;
                size = 10;
            }
            if (collection_of_countries.Text == "Австрія(AT)")
            {
                num_country = 1029;
                word_country = "AT";
                size_MFO = 5;
                size = 11;
            }
            if (collection_of_countries.Text == "Хорватія(HR)")
            {
                num_country = 1727;
                word_country = "HR";
                size_MFO = 7;
                size = 10;
            }
            if (collection_of_countries.Text == "Данія(DK)")
            {
                num_country = 1320;
                word_country = "DK";
                size_MFO = 4;
                size = 10;
            }
            if (collection_of_countries.Text == "Гренландія(GL)")
            {
                num_country = 1621;
                word_country = "GL";
                size_MFO = 4;
                size = 10;
            }
            if (collection_of_countries.Text == "Казахстан(KZ)")
            {
                num_country = 2035;
                word_country = "KZ";
                size_MFO = 3;
                size = 13;
            }
            if (collection_of_countries.Text == "Ліван(LB)")
            {
                num_country = 2111;
                word_country = "LB";
                size_MFO = 4;
                size = 20;
            }
            if (collection_of_countries.Text == "Ліхтенштейн(LI)")
            {
                num_country = 2118;
                word_country = "LI";
                size_MFO = 5;
                size = 12;
            }
            if (collection_of_countries.Text == "Литва(LT)")
            {
                num_country = 2129;
                word_country = "LT";
                size_MFO = 5;
                size = 11;
            }
            if (collection_of_countries.Text == "Люксембург(LU)")
            {
                num_country = 2130;
                word_country = "LU";
                size_MFO = 3;
                size = 13;
            }
            if (collection_of_countries.Text == "Саудівська Аравія(SA)")
            {
                num_country = 2810;
                word_country = "SA";
                size_MFO = 2;
                size = 18;
            }
            if (collection_of_countries.Text == "Швеція(SE)")
            {
                num_country = 2814;
                word_country = "SE";
                size_MFO = 3;
                size = 17;
            }
            if (collection_of_countries.Text == "Україна(UA)")
            {
                num_country = 3010;
                word_country = "UA";
                size_MFO = 6;
                size = 19;
            }
            if (collection_of_countries.Text == "Об\'єднані Арабські Емірати(AE)")
            {
                num_country = 1014;
                word_country = "AE";
                size_MFO = 3;
                size = 16;
            }
            if (collection_of_countries.Text == "")
            {
                MessageBox.Show("Виберіть країну!", "Помилка використання");
            }
            return num_country;
        }
        void method_kontrol_digits()
        {
            /*
             * buff_word-буфер для формування числа для ф-ії mod97,
             з нього буде створене число з різних частин, а саме:
             textBox_kod.Text-МФО банку, що буде вводитися користувачем
             textBox_nomer.Text-номер рахунок, що буде вводитися користувачем
             Convert.ToString (num_country) -літерні-цифрове співвідношення країни (Наприклад для України UA-3010)
             "00" -ісходние контрольні цифри, нулі ставляться для знаходження правильного контрольного числа 
           */
            buff_word = textBox_kod.Text;
            int buff = textBox_nomer.Text.Length;
            if (buff > size)//Якщо число більше допустимого-помилка
            {
                MessageBox.Show("Помилка вводу рахунка!", "Помилка!");
            }
            else
            {
                if (buff < size)//Якщо число меньше допустимого перед числом ставлять нулі
                {
                    int mince = size - Convert.ToInt32(textBox_nomer.Text.Length);
                    for (int count = 0; count < mince; count++)
                    {
                        buff_word += "0";
                    }
                }
                buff_word += textBox_nomer.Text;
                buff_word += Convert.ToString(num_country);
                buff_word += "00";
                ulong len = Convert.ToUInt64(buff_word.Length);//Довжика коду IBAN
                kontrol_digits = Generate.mod97_test(buff_word, len);//Метод із додатковох бібліотеки коду
            }
        }
        void method_form_IBAN()
        /*
         * Метод для кінцевого формування IBAN
         */
        {
            IBAN_format = word_country;
            IBAN_format += Convert.ToString(kontrol_digits);
            IBAN_format += textBox_kod.Text;
            int buff = textBox_nomer.Text.Length;
            if (buff < size)
            {
                int mince = size - Convert.ToInt32(textBox_nomer.Text.Length);
                for (int count = 0; count < mince; count++)
                {
                    IBAN_format += "0";
                }
            }
            IBAN_format += textBox_nomer.Text;
            textBox_IBAN.Text = IBAN_format;
        }
        void method_test_kontrol_digits()
        /*
         * Метод перевірки контрольної суми
         */
        {
            buff_word = textBox_kod.Text;
            int buff = textBox_nomer.Text.Length;
            if (buff > size)//Якщо більше,то помилка
            {
                MessageBox.Show("Помилка вводу рахунка!", "Помилка!");
            }
            else
            {
                if (buff < size)//Якщо менше,перед числом ставлять нулі
                {
                    int mince = size - Convert.ToInt32(textBox_nomer.Text.Length);
                    for (int count = 0; count < mince; count++)
                    {
                        buff_word += "0";
                    }
                }
                buff_word += textBox_nomer.Text;
                buff_word += Convert.ToString(num_country);
                buff_word += "00";
                ulong len = Convert.ToUInt64(buff_word.Length);
                ulong test = Generate.mod97_test(buff_word, len);
                if (kontrol_digits == 0)//Обробка неправильності контрольної суми
                {
                    kontrol_digits = test;
                    MessageBox.Show("Правильне контрольне число:" + kontrol_digits, "УВАГА!");
                }
                else
                {
                    if (kontrol_digits != test)
                    {
                        MessageBox.Show("Правильне контрольне число:" + test, "УВАГА!");
                    }
                    if (kontrol_digits == test)
                    {
                        MessageBox.Show("Правильне контрольне число:" + kontrol_digits, "УВАГА!");
                    }
                }
            }
        }
        private void rasch_Click(object sender, EventArgs e)
        {
            /*
             * Обробка натиснення на кнопку "Розрахувати"
             */
            method_num_of_country();
            int buff = Convert.ToInt32(textBox_kod.Text.Length);
            if (buff < size_MFO || buff > size_MFO)
            {
                MessageBox.Show("Помилка вводу коду МФО!", "Помилка!");
            }
            else
            {
                method_kontrol_digits();
                method_form_IBAN();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Кнопка тестування кнотрольної суми
             */
            method_num_of_country();
            int buff = Convert.ToInt32(textBox_kod.Text.Length);
            if (buff < size_MFO || buff > size_MFO)
            {
                MessageBox.Show("Помилка вводу коду МФО!", "Помилка!");
            }
            else
            {
                method_test_kontrol_digits();
                method_form_IBAN();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        /*
         * Копка "Скопіювати"
         */
        {
            Clipboard.SetData(DataFormats.Text, (Object)textBox_IBAN.Text);
        }

        private void console_button_Click(object sender, EventArgs e)
        /*
         * Відкрити консоль.
         */
        {
            System.Diagnostics.Process.Start("console.exe");
            this.Close();
        }
    }
}
