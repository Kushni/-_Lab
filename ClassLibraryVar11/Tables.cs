using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DomainModel
{

    public class GroupList : SortableBindingList<Group>
    {
        public GroupList()
        {
            originalList = new List<Group>();
        }

        public GroupList(IEnumerable<Group> enumerable)
        {
            originalList = enumerable.ToList();
            populateBaseList(this, originalList);
        }

        public GroupList(List<Group> list)
        {
            originalList = list;
            populateBaseList(this, originalList);
        }
    }

    public class StudentList : SortableBindingList<Student>
    {
        public StudentList()
        {
            originalList = new List<Student>();
        }

        public StudentList(IEnumerable<Student> enumerable)
        {
            originalList = enumerable.ToList();
            populateBaseList(this, originalList);
        }

        public StudentList(List<Student> list)
        {
            originalList = list;
            populateBaseList(this, originalList);
        }
    }

    public class RatingList : SortableBindingList<Rating>
    {
        public RatingList()
        {
            originalList = new List<Rating>();
        }

        public RatingList(IEnumerable<Rating> enumerable)
        {
            originalList = enumerable.ToList();
            populateBaseList(this, originalList);
        }

        public RatingList(List<Rating> list)
        {
            originalList = list;
            populateBaseList(this, originalList);
        }
    }
}

/**
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DomainModel
{

    public class GroupList : BindingList<Group>, { }

    public class StudentList : BindingList<Student> { }

    public class RatingList : BindingList<Rating> { }

}

*/