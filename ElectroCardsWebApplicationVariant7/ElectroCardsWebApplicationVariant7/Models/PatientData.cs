//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectroCardsWebApplicationVariant7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientData
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Telephone { get; set; }
        public string WorkPlace { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public string Diagnose { get; set; }
        public string Medicine { get; set; }
        public string WayOfUsingMedicine { get; set; }
        public int DoctorId { get; set; }
        public Nullable<int> SickLeaveNum { get; set; }
        public string SickLeavePeriod { get; set; }
        public Nullable<int> DiagnoseCode { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
