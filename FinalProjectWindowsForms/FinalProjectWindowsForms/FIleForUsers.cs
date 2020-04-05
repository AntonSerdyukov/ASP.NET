using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWindowsForms
{
    class FileForUsers
    {
        public string JsonFilePath { get; }
        public FileInfo ExistedFile { get; }
        public FileStream CreatedFile { get; }
        public List<UserData> FileData { get; set; }

        public FileForUsers()
        {
            JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userlist.json");
            ExistedFile = new FileInfo(JsonFilePath);

            if (ExistedFile.Exists == false)
            {
                FileStream CreatedFile = File.Create(JsonFilePath);
                CreatedFile.Close();
            }

            FileData = GetDataFromFile();
        }

        public List<UserData> GetDataFromFile()
        {
            FileData = new List<UserData>();
            string[] stringFileData = File.ReadAllLines(JsonFilePath);

            for (int i = 0; i < stringFileData.Length; i++)
            {
                FileData.Add(JsonConvert.DeserializeObject<UserData>(stringFileData[i]));
            }

            return FileData;
        }

        public void AddData(UserData data)
        {
            FileData.Add(data);

            using (StreamWriter sw = new StreamWriter(JsonFilePath, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data));
            }

        }

        public bool IsUserExist(string login, string password)
        {
            foreach (var user in FileData)
            {
                if (user.Login == login && user.Password == password)
                {
                    return true;
                }
            }

            return false;

        }


    }
}
