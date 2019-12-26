using System;
using System.IO;

namespace XY_ParserConsole
{
    class Program
    {
    /// <summary>
    /// Приложение для парсинга координат из текстового формата в тип decimal
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int check = 0;
            int input;

            string inputStr;
            string defaultInput = "23.8976, 12.3218, 25.76, 11.9463, 24.8293, 12.2";

            char[] delimiterChars = {',',' '};

            Console.WriteLine("Выберите действие:\n" +
                "1. Ввести данные вручную;\n" +
                "2. Прочитать данные из файла\n" +
                "3. Использовать значения по умолчанию.\n");
            
            do
            {
                check = 0;
                inputStr = Console.ReadLine();

                if (Int32.TryParse(inputStr, out input))
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Введите данные:");
                            string str = Console.ReadLine();
                            Parsing(str, delimiterChars);
                            break;
                        case 2:
                            Parsing(defaultInput, delimiterChars);
                            break;
                        case 3:
                            ReadFrom(delimiterChars);
                            break;
                        default:
                            check = 1;
                            Console.WriteLine("Вы ввели неверное значение, попробуйте снова.");
                            continue;
                    }
                }
                else
                {
                    check = 1;
                    Console.WriteLine("Вы ввели неверное значение, попробуйте снова.");
                }
            }
            while (check == 1);

            Console.ReadKey();
        }
        /// <summary>
        /// Метод для парсинга координат
        /// </summary>
        /// <param name="str"></param>
        /// <param name="delimiterChars"></param>
        private static void Parsing(string str, char[] delimiterChars)
        {
            string[] strCoords = str.Split(delimiterChars);
            decimal[] coordinates = new decimal[strCoords.Length];

            for (int i = 0; i < strCoords.Length; i++)
            {
                strCoords[i] = strCoords[i].Replace('.', ',');
                coordinates[i] = decimal.Parse(strCoords[i]);
            }

            for (int i = 0; i < strCoords.Length; i++)
            {
                if ((i % 2) != 1)
                {
                    Console.Write($"\nX:{coordinates[i]};");
                }
                else
                {
                    Console.Write($"\tY:{coordinates[i]}");
                }
            }
        }
        /// <summary>
        /// Метод чтения значений из файла
        /// </summary>
        /// <param name="delimiterChars"></param>
        private static void ReadFrom(char[] delimiterChars)
        {
            string path = "coord.txt";
            string str;
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    str = sr.ReadToEnd();
                    Parsing(str, delimiterChars);
                }

            }
        }
    }
}
    
