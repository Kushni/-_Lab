using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInteface
{
    public partial class StudentsViewer : UserControl
    {
        public StudentsViewer()
        {
            InitializeComponent();
            studentsDataGridView.AllowUserToAddRows = false;
            studentsDataGridView.AllowUserToDeleteRows = false;
            studentsDataGridView.RowHeadersVisible = false;
            //Load += this.OnLoad;
        }

        public Student currentStudent;

        public void OnLoad(object source, EventArgs e)
        {
            studentsBindingSource.DataSource = new SortableBindingList<Student>();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            studentsBindingSource.ResetBindings(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //ToDo #3
            if (Storage.Instance.cascadeDelete) CurrentDeleteCascade();

            //ToDo #2
            studentsBindingSource.ResetBindings(true);
        }

        //ToDo #3

        public void CurrentDeleteCascade()
        {
            var relatedRatings = Storage.Instance.db.ratings.Where(p => p.studentNumber == currentStudent.studentNumber);

            foreach (Rating rating in relatedRatings.ToList())
            {
                Storage.Instance.CascadeDelete(rating);
            }

            Storage.Instance.db.students.Remove(currentStudent);
        }
    }
}
