using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using XY_ParserWPF;


namespace XY_ParserWPF.com.gellert.upload
{
    class FileUpload
    {

        public static void ReadFrom(Button button, TextBox textBox)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                button.Content = openFileDlg.FileName;
                textBox.Text = System.IO.File.ReadAllText(openFileDlg.FileName);
            }

        }
    }
}
