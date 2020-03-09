using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectroCardsWebApplication.Models
{
    public class Patient
    {
        public int  PatientId { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Surname { get; set; }
        // цена
        public string Patronymic { get; set; }

        public string BirthDate { get; set; }
        // название книги
        public string Telephone { get; set; }
        // автор книги
        public string WorkPlace { get; set; }
        // цена
        public string Photo { get; set; }
    }
}