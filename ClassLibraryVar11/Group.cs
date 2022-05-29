using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DomainModel
{
    [Serializable]
    public class Group
    {
        [DisplayName("Номер групи")]
        public string numberGroup { get; set; }

        [DisplayName("Назва спеціальності")]
        public string specialtyName { get; set; }

        [DisplayName("Номер курсу")]
        public byte? courseNumber { get; set; }

        [DisplayName("Номер залікової старости")]
        public string headmanNumber { get; set; }

        [DisplayName("Номер факультету")]
        public byte? facultyNumber { get; set; }

        [DisplayName("Форма навчання")]
        public string educationForm { get; set; }

        


    }
}
