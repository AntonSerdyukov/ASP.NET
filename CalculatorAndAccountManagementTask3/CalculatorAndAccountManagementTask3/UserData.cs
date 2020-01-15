using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorAndAccountManagementTask3
{
    class UserData
    {
        string jsonFilePath;
        List<string> users;

        public UserData()
        {
            jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userlist.json");
            FileInfo file = new FileInfo(jsonFilePath);

            if (file.Exists == false)
            {
                FileStream fileStream = File.Create(jsonFilePath);
                fileStream.Close();
            }

            users = GetUsersFromFile();
        }

        public List<string> GetUsersFromFile()
        {
            List<string> users = File.ReadAllLines(jsonFilePath).ToList<string>();
            return users;
        }

        public bool CheckAdminExist(Admin admin)
        {

            if (users.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < users.Count; i++)
            {

                User existedUser = JsonConvert.DeserializeObject<User>(users[i]);

                if (admin.Name == existedUser.Name)
                {

                    if (admin.Password == existedUser.Password)
                    {
                        return true;
                    }

                }

            }

            return false;
        }

        public void AddUser(User user)
        {

            using (var sw = new StreamWriter(jsonFilePath, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(user));
                users.Add(JsonConvert.SerializeObject(user));
            }

        }

        public void AddAdmin(Admin admin)
        {

            using (var sw = new StreamWriter(jsonFilePath, true))
            {
                sw.WriteLine(JsonConvert.SerializeObject(admin));
                users.Add(JsonConvert.SerializeObject(admin));
            }

        }

        public bool DeleteUser(User user)
        {
            bool isUserFound = false;

            for (int i = 0; i < users.Count; i++)
            {

                if (users[i] == JsonConvert.SerializeObject(user))
                {
                    users.RemoveAt(i);
                    isUserFound = true;
                }

            }

            if (isUserFound == false)
            {
                return false;
            }
            else
            {

                using (var sw = new StreamWriter(jsonFilePath, false))
                {

                    for (int i = 0; i < users.Count; i++)
                    {
                        sw.WriteLine(users[i]);
                    }

                }

                return true;
            }

        }

        public void EditUser(User oldUser, User newUser)
        {

            for (int i = 0; i < users.Count; i++)
            {

                if (users[i] == JsonConvert.SerializeObject(oldUser))
                {
                    users.RemoveAt(i);
                    users.Add(JsonConvert.SerializeObject(newUser));

                    using (var sw = new StreamWriter(jsonFilePath, false))
                    {

                        for (int j = 0; j < users.Count; j++)
                        {
                            sw.WriteLine(users[j]);
                        }

                    }

                    break;
                }

            }

        }

        public User GetUser(string name)
        {

            for (int i = 0; i < users.Count; i++)
            {
                User user = JsonConvert.DeserializeObject<User>(users[i]);

                if (name == user.Name)
                {
                    return user;
                }

            }

            return null;
        }

        public bool CheckUserPassword(string password)
        {

            for (int i = 0; i < users.Count; i++)
            {
                User user = JsonConvert.DeserializeObject<User>(users[i]);

                if (password == user.Password)
                {
                    return false;
                }

            }

            return true;
        }

        public bool CheckUserName(string name)
        {

            for (int i = 0; i < users.Count; i++)
            {
                User user = JsonConvert.DeserializeObject<User>(users[i]);

                if (name == user.Name)
                {
                    return false;
                }

            }

            return true;
        }

        public bool CheckUserAccount(User user)
        {

            for (int i = 0; i < users.Count; i++)
            {
                User existedUser = JsonConvert.DeserializeObject<User>(users[i]);

                if (user.Name == existedUser.Name)
                {

                    if (user.Password == existedUser.Password)
                    {
                        return true;
                    }

                }

            }

            return false;
        }
    }
}
