using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DomainModel
{
    [Serializable]
    public partial class Student
    { 
        [DisplayName("Номер залікової книжки")]
        public string studentNumber { get; set; }

        [DisplayName("Номер групи")]
        public string GroupNumber { get; set; }

        [DisplayName("Фамілія")]
        public string lastName { get; set; }

        [DisplayName("Ім'я")]
        public string firstName { get; set; }

        [DisplayName("По-батькові")]
        public string patronymic { get; set; }

        [DisplayName("Адреса")]
        public string address { get; set; }


    }
}

namespace DomainModel
{
    public partial class Student
    {

    }
}
