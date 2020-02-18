using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace FinalProjectWindowsForms
{
    class EmployeesFile: IEmployeesFile
    {
        public string JsonFilePath { get; }
        public FileInfo ExistedFile { get; }
        public FileStream CreatedFile { get; }
        public List<EmployeeData> FileData { get; set; }

        public EmployeesFile()
        {
            JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.json");
            ExistedFile = new FileInfo(JsonFilePath);

            if (ExistedFile.Exists == false)
            {
                FileStream CreatedFile = File.Create(JsonFilePath);
                CreatedFile.Close();
            }

            FileData = GetDataFromFile();
        }

        public List<EmployeeData> GetDataFromFile()
        {
            FileData = new List<EmployeeData>();
            string[] stringFileData = File.ReadAllLines(JsonFilePath);

            for (int i = 0; i < stringFileData.Length; i++)
            {
                FileData.Add(JsonConvert.DeserializeObject<EmployeeData>(stringFileData[i]));
            }

            return FileData;
        }

        public void AddData(EmployeeData data)
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

        public void RemoveData(string name,string surname)
        {

            for (int i = 0; i < FileData.Count; i++)
            {

                if (FileData[i].Name == name && FileData[i].Surname==surname)
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

        public void EditEmployee(string name, string surname, string newNumOfSkippingDays, string newNumOfOverWorkingDays)
        {

            for (int i = 0; i < FileData.Count; i++)
            {
                if (FileData[i].Name == name && FileData[i].Surname == surname)
                {                  
                    RemoveData(name,surname);
                    Validator validator = new Validator();
                    EmployeeData updatedEmployee = new EmployeeData(name, surname, 0, 0, validator.ConvertToIntValue(newNumOfSkippingDays), validator.ConvertToIntValue(newNumOfOverWorkingDays), FileData[i].ProfessionName);
                    AddData(updatedEmployee);
                }

            }
        }

        public void EditEmployeeByPlanSalary(EmployeeData employee, decimal planSalary)
        {

            for (int i = 0; i < FileData.Count; i++)
            {

                if (FileData[i].Name == employee.Name && FileData[i].Surname == employee.Surname)
                {

                    FileData[i].PlannedSalary = planSalary;
                    break;
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

        public void EditEmployeeByRealSalary(EmployeeData employee, decimal realSalary)
        {
            for (int i = 0; i < FileData.Count; i++)
            {

                if (FileData[i].Name == employee.Name && FileData[i].Surname == employee.Surname)
                {

                    FileData[i].RealSalary = realSalary;
                    break;
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

        public bool IsEmployeeExist(string name,string surname)
        {
            foreach (var employee in FileData)
            {
                if (employee.Name==name && employee.Surname == surname)
                {
                    return true;
                }
            }

            return false;
            
        }


    }

}

