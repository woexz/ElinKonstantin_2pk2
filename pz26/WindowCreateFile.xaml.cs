using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Wpfpz26
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static string nameFile;
        public static string mainTBString;

        public Window1()
        {
            InitializeComponent();
        }

        private void CreateFileOk_Click(object sender, RoutedEventArgs e)
        {
            nameFile = $"C:/Users/Артем/Desktop/{NameFile.Text}.txt";
            if (File.Exists(nameFile))
            {
                FileStream fileStream = new FileStream(nameFile, FileMode.Open, FileAccess.Read);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    mainTBString = reader.ReadToEnd();
                }
                fileStream.Close();
            }
            else
            {
                File.Create(nameFile);
            }
            this.DialogResult = true;
        }//Создание документа по названию или его открытие при вводе названия, которое уже есть. //Закрыте диалогового окна.
    }
}
