using FlashCards.Properties;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlashCards.Classes
{
    public static class FileHandler
    {

        private static string _filepath = Properties.Settings.Default.CardsFile;

        public static List<FlashCardData>? FiletoList()
        {

            if (!File.Exists(_filepath))
            {
                _filepath = Directory.GetCurrentDirectory() + "/Files";
                Directory.CreateDirectory(_filepath);
                _filepath += "/CardsFile.txt";
                File.Create(_filepath);

                Properties.Settings.Default.CardsFile = _filepath;
                Properties.Settings.Default.Save();
            }


            string file = File.ReadAllText(_filepath);
            var ret = JsonConvert.DeserializeObject<List<FlashCardData>>(file);
            return ret;
        }



        public static void ListtoFile(ref List<FlashCardData> list)
        {
            if (!File.Exists(_filepath))
            {
                MessageBox.Show(String.Format("File Doesn't Exist: {0}", _filepath));
                return;
            }

            string jsonstring = JsonConvert.SerializeObject(list);
            File.WriteAllText(_filepath, jsonstring);

        }
    }
}
