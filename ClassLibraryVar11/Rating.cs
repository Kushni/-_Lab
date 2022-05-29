using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DomainModel
{
    [Serializable]
    public class Rating
    {

        [DisplayName("Номер залікової книжки")]
        public string studentNumber { get; set; }

        [DisplayName("Назва предмету")]
        public string lessonName { get; set; }

        [DisplayName("Номер семестру")]
        public int? semesterNumber { get; set; }

        [DisplayName("Оцінка за національною шкалою")]
        public string nationalRating { get; set; }

        [DisplayName("Оцінка за стобальною шкалою")]
        public string hundredRating { get; set; }

        [DisplayName("Оцінка за ECTS")]
        public string ECTSRating { get; set; }

    }
}

