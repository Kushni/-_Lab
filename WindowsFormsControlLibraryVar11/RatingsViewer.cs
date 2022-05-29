using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel;

namespace UserInteface
{
    public partial class RatingsViewer : UserControl
    {
        public RatingsViewer()
        {
            InitializeComponent();
            ratingsDataGridView.AllowUserToAddRows = false;
            ratingsDataGridView.AllowUserToDeleteRows = false;
            ratingsDataGridView.RowHeadersVisible = false;
            ratingsBindingSource.ResetBindings(true);
            //Load += this.OnLoad;
        }

        public void OnLoad(object source, EventArgs e)
        {
            ratingsBindingSource.DataSource = new SortableBindingList<Rating>();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ratingsBindingSource.ResetBindings(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ratingsBindingSource.ResetBindings(true);
        }
    }
}
