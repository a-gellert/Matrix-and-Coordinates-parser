using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using XY_ParserWPF;

/// <summary>
/// Класс для загрузки тестового файла
/// </summary>
namespace XY_ParserWPF.com.gellert.upload
{
    class FileUpload
    {
        /// <summary>
        /// Метод для чтения данных из файла и записи в поля
        /// </summary>
        /// <param name="button"></param>
        /// <param name="textBox"></param>
        public static void ReadFrom(Button button, TextBox textBox)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                button.Content = openFileDlg.FileName;
                textBox.Text = File.ReadAllText(openFileDlg.FileName);
            }

        }
    }
}
