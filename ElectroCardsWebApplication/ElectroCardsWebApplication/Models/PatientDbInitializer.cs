using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ElectroCardsWebApplication.Models
{
    public class PatientDbInitializer : CreateDatabaseIfNotExists<PatientContext>
    {
        protected override void Seed(PatientContext db)
        {
            /* db.Patients.Add(new Patient { Name = "Война и мир", Surname = "Л. Толстой", Patronymic = "220",BirthDate="13.02.2000",Telephone="4646567",WorkPlace="fdhghg", Photo="gfddsfd" });
             db.Patients.Add(new Patient { Name = "Отцы и дети", Surname = "И. Тургенев", Patronymic = "180", BirthDate = "13.02.2000", Telephone = "4646567", WorkPlace = "fdhghg", Photo = "gfddsfd" });
             db.Patients.Add(new Patient { Name = "Чайка", Surname = "А. Чехов", Patronymic = "150", BirthDate = "13.02.2000", Telephone = "4646567", WorkPlace = "fdhghg", Photo = "gfddsfd" });
             db.SaveChanges();*/
            base.Seed(db);
        }
    }
}