using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace XY_ParserWPF.com.gellert.parsing
{/// <summary>
/// Класс для парсинга координат
/// </summary>
    class Parser
    {
        private static readonly char[] delimiterChars = { ',', ' ' };
        /// <summary>
        /// Метод для парсинга данных в тип decimal
        /// </summary>
        /// <param name="textInput"></param>
        /// <param name="textOutput"></param>
        public static void Parsing(TextBox textInput, TextBox textOutput)
        {
            string str = textInput.Text;
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
                    textOutput.AppendText($"\nX:{coordinates[i]};");

                }
                else
                {
                    textOutput.AppendText($" Y:{coordinates[i]};");
                }
            }
        }
    }
}
