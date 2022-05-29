using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel;

namespace WindowsFormsControlLibraryVar11
{
    public partial class GroupsViewer: UserControl
    {
        public GroupsViewer()
        {
            InitializeComponent();
            groupsDataGridView.AllowUserToAddRows = false;
            groupsDataGridView.AllowUserToDeleteRows = false;
            groupsDataGridView.RowHeadersVisible = false;


            //Load += this.OnLoad;
        }

        public Group currentGroup;

        public void OnLoad(object source, EventArgs e)
        {
            groupsBindingSource.DataSource = new SortableBindingList<Group>();
            //groupsBindingNavigator.DeleteItem.
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (Storage.Instance.cascadeDelete) CurrentDeleteCascade();

            groupsBindingSource.ResetBindings(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupsBindingSource.ResetBindings(true);
        }

        //ToDo #3

        public void CurrentDeleteCascade()
        {
            var relatedStudents = Storage.Instance.db.students.Where(p => p.GroupNumber == currentGroup.numberGroup);

            foreach (Student student in relatedStudents.ToList())
            {
                Storage.Instance.CascadeDelete(student);
            }
        }
    }
}
