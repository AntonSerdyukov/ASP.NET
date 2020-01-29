using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FinalProject
{

    class JsonFile
    {
        public string JsonFilePath { get; }
        public FileInfo ExistedFile { get; }
        public FileStream CreatedFile { get; }
        public List<DataForJson> FileData { get; set; }

        public JsonFile()
        {
            JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "budgetlist.json");
            ExistedFile = new FileInfo(JsonFilePath);

            if (ExistedFile.Exists == false)
            {
                FileStream CreatedFile = File.Create(JsonFilePath);
                CreatedFile.Close();
            }
          
            FileData = GetDataFromFile();
        }

        public List<DataForJson> GetDataFromFile()
        {
            FileData = new List<DataForJson>();
            string[] stringFileData = File.ReadAllLines(JsonFilePath);

            for (int i = 0; i < stringFileData.Length; i++)
            {
                FileData.Add(JsonConvert.DeserializeObject<DataForJson>(stringFileData[i]));
            }

            return FileData;
        }

        public void AddData(DataForJson data)
        {
            FileData.Add(data);

            using (StreamWriter sw = new StreamWriter(JsonFilePath, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data));
            }

        }

        public void RemoveAllData()
        {

            for (int i = 0; i < FileData.Count; i++)
            {
                FileData.RemoveAt(i);
            }

            using (StreamWriter sw = new StreamWriter(JsonFilePath, false)) { }
                        
        }

        public void RemoveData(DateTime date)
        {

            for (int i = 0; i < FileData.Count; i++)
            {

                if (FileData[i].Date == date)
                {
                    FileData.RemoveAt(i);
                }

            }

            using (StreamWriter sw = new StreamWriter(JsonFilePath, false))
            {

                for (int i = 0; i < FileData.Count; i++)
                {                   
                    sw.WriteLine(JsonConvert.SerializeObject(FileData[i]));                   
                }

            }

        }

    }

}
