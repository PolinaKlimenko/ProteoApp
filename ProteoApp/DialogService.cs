using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;
using System.IO;
using pwiz.CLI.msdata;

namespace ProteoApp
{
    public interface IDialogService
    {
        void ShowMessage(string message);   // показ сообщения
        string FilePath { get; set; }   // путь к выбранному файлу
        bool OpenFileDialog();  // открытие файла
        bool SaveFileDialog();  // сохранение файла
    }
    class DialogService : IDialogService
    {
        private string sourceFilepath;
        public string FilePath { get; set; }
        public MSData MSDataFile { get; private set; }

        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "mzXML (*.mzXML)|*.mzXML|mzML (*.mzML)|*.mzML"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;

                //
                MSDataFile = new MSData();
                ReaderList.FullReaderList.read(FilePath, MSDataFile);
                sourceFilepath = FilePath.ToString();
                //
                return true;
            }
            return false;
        }

        public bool SaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }
            return false;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
