using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.IO;

namespace PictureToPC
{
    public class Config
    {
        public static string FolderName = "Mees Studio";
        public static string FileName = "data.json";

        public static string FilePath = "./" + FileName;
        public Data Data;

        public Config()
        {
            check();
            load();
        }

        private void load()
        {
            string data = File.ReadAllText(FilePath);
            if (data == "")
            {
                Data = new Data();
                save();
            }
            else
            {
                Data = JsonConvert.DeserializeObject<Data>(data);
            }
        }

        public void Save()
        {
            save();
        }

        private void check()
        {
            //check if file and folder exist
            if (!File.Exists(FilePath))
            {
                _ = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + FolderName);
                File.Create(FilePath).Close();
                Data = new Data();
                save();
            }
        }

        private void save()
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Data));
        }
    }

    public class Data
    {
        public int Aufgabe;
        public int Hints;
        public int WrongCount;
        public bool Hint;


        public Data()
        {
            Aufgabe = 0;
            Hints = 0;

            WrongCount = 0;

            Hint = false;
        }
    }
}

