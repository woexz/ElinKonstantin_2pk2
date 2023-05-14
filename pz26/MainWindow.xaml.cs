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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Security.AccessControl;

namespace Wpfpz26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool saveStatusBool;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wn = new Window1();
            wn.ShowDialog();
            MainTextBox.Text = Window1.mainTBString;//заполнение TextBox текстом из файла.
        }//открытие диалогового окна

        private void SaveText_Click(object sender, RoutedEventArgs e)
        {
            if(Window1.nameFile != null)
            {
                FileStream fileStream = new FileStream(Window1.nameFile, FileMode.Open, FileAccess.Write);
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Unicode))
                {
                    streamWriter.Write(MainTextBox.Text);
                }
                fileStream.Close();
                SaveStatus.Text = "Сохранено";
                DateStatus.Text = Convert.ToString(DateTime.Now);
            }
        }

        private void StatusSaveVoid(object sender, KeyEventArgs e)
        {
            FileStream fileStream = new FileStream(Window1.nameFile, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Unicode))
            {
                string fileText = streamReader.ReadToEnd();
                string textBoxText = MainTextBox.Text;
                if(fileText != textBoxText)
                {
                    SaveStatus.Text = "Требуется сохранение";
                }
                else if(fileText == textBoxText)
                {
                    SaveStatus.Text = "Сохранено";
                }
            }
            fileStream.Close();
        }
    }
}
