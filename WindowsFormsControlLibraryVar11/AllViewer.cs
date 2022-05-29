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
    public partial class AllViewer : UserControl
    {

        public AllViewer()
        {
            InitializeComponent();
            SetRestriction();
        }

        public Storage Bind
        {
            set
            {
                GroupsViewer1.groupsBindingSource.DataSource = value.db.groups;
                students1.studentsBindingSource.DataSource = value.db.students;
                ratings1.ratingsBindingSource.DataSource = value.db.ratings;

                ratings1.bsStudentRegistry.DataSource = value.db.students;
                students1.bsGroupRegistry.DataSource = value.db.groups;


                //GroupsViewer1.groupsBindingNavigator.BindingSource = GroupsViewer1.groupsBindingSource;
                //ratings1.ratingsBindingNavigator.BindingSource = ratings1.ratingsBindingSource;
                //students1.studentsBindingNavigator.BindingSource = students1.studentsBindingSource;
                
            }
        }

        void SetRestriction()
        {
            GroupsViewer1.groupsBindingSource.AddingNew += NewGroup;
            ratings1.ratingsBindingSource.AddingNew += NewRating;
            students1.studentsBindingSource.AddingNew += NewStudent;

            //ToDo #3

            GroupsViewer1.groupsBindingSource.PositionChanged += CheckGroupRelation;
            students1.studentsBindingSource.PositionChanged += CheckStudentRelation;

            GroupsViewer1.groupsBindingSource.ListChanged += CheckGroupRelation;
            students1.studentsBindingSource.ListChanged += CheckStudentRelation;

            tabControl1.Selected += ResetBindingSourses;
        }

        private void NewGroup (object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Group();
            /**{
                numberGroup = "New Group",
                specialtyName = "Some specialty",
                courseNumber = 1,
                educationForm = "dailly",
                facultyNumber = 1,
                headmanNumber = null
            };*/
        }

        //ToDo #3

        private void NewRating(object sender, AddingNewEventArgs e) => e.NewObject = new Rating();

        private void NewStudent(object sender, AddingNewEventArgs e) => e.NewObject = new Student();

        private void CheckGroupRelation(object sender, EventArgs e)
        {
            if (GroupsViewer1.groupsBindingSource.Current == null) return;

            GroupsViewer1.currentGroup = (GroupsViewer1.groupsBindingSource.Current as Group);

            var groupName = (GroupsViewer1.groupsBindingSource.Current as Group).numberGroup;
            GroupsViewer1.groupsBindingNavigator.DeleteItem.Enabled = Storage.Instance.AllowRemoveGroup(groupName) || Storage.Instance.cascadeDelete;
        }

        private void CheckStudentRelation(object sender, EventArgs e)
        {
            if (students1.studentsBindingSource.Current == null) return;

            students1.currentStudent = (students1.studentsBindingSource.Current as Student);

            var studentNumber = (students1.studentsBindingSource.Current as Student).studentNumber;
            students1.studentsBindingNavigator.DeleteItem.Enabled = Storage.Instance.AllowRemoveStudent(studentNumber) || Storage.Instance.cascadeDelete;
        }

        private void ResetBindingSourses(object sender, TabControlEventArgs e)
        {
            GroupsViewer1.groupsBindingSource.ResetBindings(true);
            students1.studentsBindingSource.ResetBindings(true);
            ratings1.ratingsBindingSource.ResetBindings(true);
        }

        public void ResetBindingSourses()
        {
            GroupsViewer1.groupsBindingSource.DataSource = Storage.Instance.db.groups;
            GroupsViewer1.groupsBindingSource.ResetBindings(true);

            students1.studentsBindingSource.DataSource = Storage.Instance.db.students;
            students1.studentsBindingSource.ResetBindings(true);

            ratings1.ratingsBindingSource.DataSource = Storage.Instance.db.ratings;
            ratings1.ratingsBindingSource.ResetBindings(true);

            //label1.Text = Storage.Instance.db.groups.Count().ToString();
        }

        public void AllowCascadeDelete(bool e) => Storage.Instance.cascadeDelete = e;

    }
}
