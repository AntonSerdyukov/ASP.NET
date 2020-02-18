using System.Collections.Generic;

namespace FinalProjectWindowsForms
{
    interface IEmployeesFile
    {
        List<EmployeeData> FileData { get; set; }
        List<EmployeeData> GetDataFromFile();
        void AddData(EmployeeData data);
        void RemoveAllData();
        void RemoveData(string name, string surname);
        void EditEmployee(string name, string surname, string newNumOfSkippingDays, string newNumOfOverWorkingDays);
    }
}
