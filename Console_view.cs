using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curs_project;

namespace console_DLL
{
    public class Console_window
    {
        public int size_MFO;
        public int size;
        public int num_country;
        public ulong buff_digits;
        public ulong kontrol_digits;
        public string buff_word;
        public string kod;
        public string nomer;
        public string word_country;
        public string IBAN_format;
        public string strana;
        public string buffer;
        public void copy()
        {
            Console.WriteLine("Скопіювати ваш IBAN?\n" + "1.Так\n" + "2.Ні\n");
            string jmp = Console.ReadLine();
            if (jmp != "1" && jmp != "2")
            {
                Console.WriteLine("Помилка вводу,спробуйте ще раз(Введіть лише цифри)!");
                copy();
            }
            if (jmp == "1")
            {
                Clipboard.SetData(DataFormats.Text, (Object)IBAN_format);
            }
            Console.WriteLine("Дякуємо за користування!");
            return;
        }
        public static UInt64 mod97_test(string s, UInt64 len)
        {
            UInt64 i, j, parts = len / 7;
            string rem = "00";

            for (i = 1; i <= parts + Convert.ToUInt64((len % 7 != 0)); ++i)
            {
                rem = rem.Substring(0, 2) + s.Substring(((int)i - 1) * 7,
                   Math.Min(s.Substring(((int)i - 1) * 7).Length, 7));
                j = Convert.ToUInt64(rem) % 97;

                string tmp;
                tmp = (j / 10).ToString(); ;

                tmp += (j % 10).ToString();
                rem = tmp + rem.Substring(2);
            }

            return Convert.ToUInt64(rem) % 97;
        }
        public string NOMER()
        {
            Console.WriteLine("Введіть номер рахунку:\n");
            nomer = Console.ReadLine();
            buff_digits = UInt64.Parse(nomer);
            if (buff_digits == 0)
            {
                Console.WriteLine("Введіть тільки номер рахунку!\n");
                NOMER();
            }
            if (nomer.Length > size)
            {
                Console.WriteLine("Ви ввели не дійсний номер рахунку(Велика к-сть цифр)\n");
                NOMER();
            }
            if (nomer.Length < size)
            {
                int mince = size - nomer.Length;
                buffer = "";
                for (int count = 0; count < mince; count++)
                {
                    buffer += "0";
                }
                buffer += nomer;
                return buffer;
            }
            return nomer;
        }
        public string MFO()
        {
            Console.WriteLine("Введіть код МФО банку:\n");
            kod = Console.ReadLine();
            buff_digits = UInt64.Parse(kod);
            if (buff_digits == 0)
            {
                Console.WriteLine("Введіть тільки цифри коду МФО банку!\n");
                MFO();
            }
            if (kod.Length != size_MFO)
            {
                Console.WriteLine("Невірний код МФО,необхідка к-сть цифр:" + size_MFO + "\n");
                MFO();
            }
            return kod;
        }
        public void generation()
        {
            buff_word = "";
            buff_word = MFO();
            buff_word += NOMER();
            buff_word += Convert.ToString(num_country);
            buff_word += "00";
            ulong len = Convert.ToUInt64(buff_word.Length);
            kontrol_digits = mod97_test(buff_word, len);
            IBAN_format = word_country;
            IBAN_format += Convert.ToString(kontrol_digits);
            IBAN_format += kod;
            if (nomer.Length < size)
            {
                int mince = size - nomer.Length;
                buffer = "";
                for (int count = 0; count < mince; count++)
                {
                    buffer += "0";
                }
                buffer += nomer;
                IBAN_format += buffer;
            }
            else
            {
                IBAN_format += nomer;
            }
            Console.WriteLine("Ваш IBAN:" + "\n" + IBAN_format);
            copy();
        }
        public void second_menu()
        {
            Console.WriteLine(
            "\n1.Австрія(AT)" +
            "\n2.Гренландія(GL)" +
            "\n3.Данія(DK)" +
            "\n4.Казахстан(KZ)" +
            "\n5.Ліван(LB)" +
            "\n6.Ліхтенштейн(LI)" +
            "\n7.Литва(LT)" +
            "\n8.Люксембург(LU)" +
            "\n9.Німеччина(DE)" +
            "\n10.Об\'єднані Арабські Емірати(AE)" +
            "\n11.Саудівська Аравія(SA)" +
            "\n12.Україна(UA)" +
            "\n13.Хорватія(HR)" +
            "\n14.Швеція(SE)");
            Console.WriteLine("Виберіть номер країни,для генерації!\n");
            string chooser = Console.ReadLine();
            switch (chooser)
            {
                case "1":
                    num_country = 1029;
                    word_country = "AT";
                    size_MFO = 5;
                    size = 11;
                    strana = "Австрія(AT)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "2":
                    num_country = 1621;
                    word_country = "GL";
                    size_MFO = 4;
                    size = 10;
                    strana = "Гренландія(GL)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "3":
                    num_country = 1320;
                    word_country = "DK";
                    size_MFO = 4;
                    size = 10;
                    strana = "Данія(DK)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "4":
                    num_country = 2035;
                    word_country = "KZ";
                    size_MFO = 3;
                    size = 13;
                    strana = "Казахстан(KZ)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "5":
                    num_country = 2111;
                    word_country = "LB";
                    size_MFO = 4;
                    size = 20;
                    strana = "Ліван(LB)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "6":
                    num_country = 2118;
                    word_country = "LI";
                    size_MFO = 5;
                    size = 12;
                    strana = "Ліхтенштейн(LI)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "7":
                    num_country = 2129;
                    word_country = "LT";
                    size_MFO = 5;
                    size = 11;
                    strana = "Литва(LT)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "8":
                    num_country = 2130;
                    word_country = "LU";
                    size_MFO = 3;
                    size = 13;
                    strana = "Люксембург(LU)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "9":
                    num_country = 1314;
                    word_country = "DE";
                    size_MFO = 8;
                    size = 10;
                    strana = "Німеччина(DE)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "10":
                    num_country = 1014;
                    word_country = "AE";
                    size_MFO = 3;
                    size = 16;
                    strana = "Об\'єднані Арабські Емірати(AE)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "11":
                    num_country = 2810;
                    word_country = "SA";
                    size_MFO = 2;
                    size = 18;
                    strana = "Саудівська Аравія(SA)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "12":
                    num_country = 3010;
                    word_country = "UA";
                    size_MFO = 6;
                    size = 19;
                    strana = "Україна(UA)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "13":
                    num_country = 1727;
                    word_country = "HR";
                    size_MFO = 7;
                    size = 10;
                    strana = "Хорватія(HR)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
                case "14":
                    num_country = 2814;
                    word_country = "SE";
                    size_MFO = 3;
                    size = 17;
                    strana = "Швеція(SE)";
                    Console.WriteLine("Ви обрали країну " + strana + "\n");
                    generation();
                    break;
            }
        }
        [STAThread]
        public static void roadtograph()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public void cont()
        {
            string s = Console.ReadLine();
            if (s != "1" && s != "2")
            {

                Console.WriteLine("Помилка.Введіть ПРАВИЛЬНИЙ номер необхідної операції!" + "\n");
            }
            if (s == "1")
            {
                second_menu();
            }
            if (s == "2")
            {
                roadtograph();
            }
        }
        public void first_menu()
        {
            Console.WriteLine("Ви перейшли до консольного виду програми!");
            Console.WriteLine("1.Продовжити в консольному виді!");
            Console.WriteLine("2.Перейти до графічного виду!");
            Console.WriteLine("Введіть номер необхідної операції!" + "\n");
            cont();
        }
    }
}
