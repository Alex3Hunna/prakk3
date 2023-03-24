using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakk3
{
    internal class Program
    {
        class CesarChifr
        {
            public char[] mes;
            public int keyrec;
            private char[] a = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };



            public string Encrypt()
            {
                int number_symbol;
                int smechenie;
                string result;
                for (int i = 0; i < mes.Length; i++)
                {
                    int m;
                    for (m = 0; m < a.Length; m++)
                    {
                        if (mes[i] == a[m])
                        {
                            break;
                        }
                    }
                    if (m < 33)
                    {
                        number_symbol = m;
                        smechenie = number_symbol + keyrec;
                        if (smechenie > 32)
                        {
                            smechenie = smechenie - 33;
                        }
                        mes[i] = a[smechenie];
                    }
                }
                result = new string(mes);
                return result;
            }
            public string Decipher()
            {
                int number_symbol;
                int smechenie;
                string result;
                for (int i = 0; i < mes.Length; i++)
                {
                    int m;
                    for (m = 0; m < a.Length; m++)
                    {
                        if (mes[i] == a[m])
                        {
                            break;
                        }
                    }
                    if (m < 33)
                    {
                        number_symbol = m;
                        smechenie = number_symbol + (33 - keyrec);



                        if (smechenie > 32)
                        {
                            smechenie = smechenie - 33;
                        }
                        mes[i] = a[smechenie];
                    }
                }
                result = new string(mes);
                return result;
            }
        }
        static void Main(string[] args)
        {
            CesarChifr cesar = new CesarChifr();
            Console.WriteLine("Используется нижний регистр русского языка");
            Console.Write("Введите текст: ");
            string m = Convert.ToString(Console.ReadLine());
            m = m.ToLower();
            char[] message = m.ToCharArray();
            cesar.mes = message;
            Console.Write("Ввести ключ: ");
            cesar.keyrec = Convert.ToInt32(Console.ReadLine());
            string result = cesar.Encrypt();
            Console.WriteLine("Зашифрованный текст: " + result);
            result = cesar.Decipher();
            Console.WriteLine("Расшифрованный текст: " + result);
            Console.ReadKey(true);
        }
    }
}
