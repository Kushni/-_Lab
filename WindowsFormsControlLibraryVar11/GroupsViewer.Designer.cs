using DomainModel;

namespace WindowsFormsControlLibraryVar11
{
    partial class GroupsViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label courseNumberLabel;
            System.Windows.Forms.Label educationFormLabel;
            System.Windows.Forms.Label facultyNumberLabel;
            System.Windows.Forms.Label headmanNumberLabel;
            System.Windows.Forms.Label numberGroupLabel;
            System.Windows.Forms.Label specialtyNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsViewer));
            this.groupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.courseNumberTextBox = new System.Windows.Forms.TextBox();
            this.educationFormTextBox = new System.Windows.Forms.TextBox();
            this.facultyNumberTextBox = new System.Windows.Forms.TextBox();
            this.headmanNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberGroupTextBox = new System.Windows.Forms.TextBox();
            this.specialtyNameTextBox = new System.Windows.Forms.TextBox();
            courseNumberLabel = new System.Windows.Forms.Label();
            educationFormLabel = new System.Windows.Forms.Label();
            facultyNumberLabel = new System.Windows.Forms.Label();
            headmanNumberLabel = new System.Windows.Forms.Label();
            numberGroupLabel = new System.Windows.Forms.Label();
            specialtyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingNavigator)).BeginInit();
            this.groupsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNumberLabel
            // 
            courseNumberLabel.AutoSize = true;
            courseNumberLabel.Location = new System.Drawing.Point(47, 55);
            courseNumberLabel.Name = "courseNumberLabel";
            courseNumberLabel.Size = new System.Drawing.Size(95, 17);
            courseNumberLabel.TabIndex = 2;
            courseNumberLabel.Text = "Номер курсу:";
            // 
            // educationFormLabel
            // 
            educationFormLabel.AutoSize = true;
            educationFormLabel.Location = new System.Drawing.Point(47, 83);
            educationFormLabel.Name = "educationFormLabel";
            educationFormLabel.Size = new System.Drawing.Size(125, 17);
            educationFormLabel.TabIndex = 4;
            educationFormLabel.Text = "Форма навчання:";
            // 
            // facultyNumberLabel
            // 
            facultyNumberLabel.AutoSize = true;
            facultyNumberLabel.Location = new System.Drawing.Point(47, 111);
            facultyNumberLabel.Name = "facultyNumberLabel";
            facultyNumberLabel.Size = new System.Drawing.Size(136, 17);
            facultyNumberLabel.TabIndex = 6;
            facultyNumberLabel.Text = "Номер факультету:";
            // 
            // headmanNumberLabel
            // 
            headmanNumberLabel.AutoSize = true;
            headmanNumberLabel.Location = new System.Drawing.Point(47, 139);
            headmanNumberLabel.Name = "headmanNumberLabel";
            headmanNumberLabel.Size = new System.Drawing.Size(182, 17);
            headmanNumberLabel.TabIndex = 8;
            headmanNumberLabel.Text = "Номер залікової старости:";
            // 
            // numberGroupLabel
            // 
            numberGroupLabel.AutoSize = true;
            numberGroupLabel.Location = new System.Drawing.Point(47, 167);
            numberGroupLabel.Name = "numberGroupLabel";
            numberGroupLabel.Size = new System.Drawing.Size(95, 17);
            numberGroupLabel.TabIndex = 10;
            numberGroupLabel.Text = "Номер групи:";
            // 
            // specialtyNameLabel
            // 
            specialtyNameLabel.AutoSize = true;
            specialtyNameLabel.Location = new System.Drawing.Point(47, 195);
            specialtyNameLabel.Name = "specialtyNameLabel";
            specialtyNameLabel.Size = new System.Drawing.Size(146, 17);
            specialtyNameLabel.TabIndex = 12;
            specialtyNameLabel.Text = "Назва спеціальності:";
            // 
            // groupsBindingNavigator
            // 
            this.groupsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupsBindingNavigator.BindingSource = this.groupsBindingSource;
            this.groupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.groupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.groupsBindingNavigatorSaveItem});
            this.groupsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupsBindingNavigator.Name = "groupsBindingNavigator";
            this.groupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupsBindingNavigator.Size = new System.Drawing.Size(1202, 27);
            this.groupsBindingNavigator.TabIndex = 0;
            this.groupsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // groupsBindingSource
            // 
            //this.groupsBindingSource.DataSource = typeof(DomainModel.Group);
            this.groupsBindingSource.DataSource = Storage.Instance.db.groups;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupsBindingNavigatorSaveItem
            // 
            this.groupsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupsBindingNavigatorSaveItem.Enabled = false;
            this.groupsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupsBindingNavigatorSaveItem.Image")));
            this.groupsBindingNavigatorSaveItem.Name = "groupsBindingNavigatorSaveItem";
            this.groupsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.groupsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // groupsDataGridView
            // 
            this.groupsDataGridView.AutoGenerateColumns = false;
            this.groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.groupsDataGridView.DataSource = this.groupsBindingSource;
            this.groupsDataGridView.Location = new System.Drawing.Point(12, 220);
            this.groupsDataGridView.Name = "groupsDataGridView";
            this.groupsDataGridView.RowHeadersWidth = 51;
            this.groupsDataGridView.RowTemplate.Height = 24;
            this.groupsDataGridView.Size = new System.Drawing.Size(1016, 213);
            this.groupsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numberGroup";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер групи";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "specialtyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва спеціальності";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "courseNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер курсу";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "headmanNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер залікової старости";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "facultyNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер факультету";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "educationForm";
            this.dataGridViewTextBoxColumn6.HeaderText = "Форма навчання";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // bsStudents
            // 
            this.bsStudents.DataSource = typeof(DomainModel.StudentList);
            // 
            // courseNumberTextBox
            // 
            this.courseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "courseNumber", true));
            this.courseNumberTextBox.Location = new System.Drawing.Point(235, 52);
            this.courseNumberTextBox.Name = "courseNumberTextBox";
            this.courseNumberTextBox.Size = new System.Drawing.Size(188, 22);
            this.courseNumberTextBox.TabIndex = 3;
            // 
            // educationFormTextBox
            // 
            this.educationFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "educationForm", true));
            this.educationFormTextBox.Location = new System.Drawing.Point(235, 80);
            this.educationFormTextBox.Name = "educationFormTextBox";
            this.educationFormTextBox.Size = new System.Drawing.Size(188, 22);
            this.educationFormTextBox.TabIndex = 5;
            // 
            // facultyNumberTextBox
            // 
            this.facultyNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "facultyNumber", true));
            this.facultyNumberTextBox.Location = new System.Drawing.Point(235, 108);
            this.facultyNumberTextBox.Name = "facultyNumberTextBox";
            this.facultyNumberTextBox.Size = new System.Drawing.Size(188, 22);
            this.facultyNumberTextBox.TabIndex = 7;
            // 
            // headmanNumberTextBox
            // 
            this.headmanNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "headmanNumber", true));
            this.headmanNumberTextBox.Location = new System.Drawing.Point(235, 136);
            this.headmanNumberTextBox.Name = "headmanNumberTextBox";
            this.headmanNumberTextBox.Size = new System.Drawing.Size(188, 22);
            this.headmanNumberTextBox.TabIndex = 9;
            // 
            // numberGroupTextBox
            // 
            this.numberGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "numberGroup", true));
            this.numberGroupTextBox.Location = new System.Drawing.Point(235, 164);
            this.numberGroupTextBox.Name = "numberGroupTextBox";
            this.numberGroupTextBox.Size = new System.Drawing.Size(188, 22);
            this.numberGroupTextBox.TabIndex = 11;
            // 
            // specialtyNameTextBox
            // 
            this.specialtyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "specialtyName", true));
            this.specialtyNameTextBox.Location = new System.Drawing.Point(235, 192);
            this.specialtyNameTextBox.Name = "specialtyNameTextBox";
            this.specialtyNameTextBox.Size = new System.Drawing.Size(188, 22);
            this.specialtyNameTextBox.TabIndex = 13;
            // 
            // GroupsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(courseNumberLabel);
            this.Controls.Add(this.courseNumberTextBox);
            this.Controls.Add(educationFormLabel);
            this.Controls.Add(this.educationFormTextBox);
            this.Controls.Add(facultyNumberLabel);
            this.Controls.Add(this.facultyNumberTextBox);
            this.Controls.Add(headmanNumberLabel);
            this.Controls.Add(this.headmanNumberTextBox);
            this.Controls.Add(numberGroupLabel);
            this.Controls.Add(this.numberGroupTextBox);
            this.Controls.Add(specialtyNameLabel);
            this.Controls.Add(this.specialtyNameTextBox);
            this.Controls.Add(this.groupsDataGridView);
            this.Controls.Add(this.groupsBindingNavigator);
            this.Name = "GroupsViewer";
            this.Size = new System.Drawing.Size(1202, 450);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingNavigator)).EndInit();
            this.groupsBindingNavigator.ResumeLayout(false);
            this.groupsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingSource groupsBindingSource;
        internal System.Windows.Forms.BindingNavigator groupsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton groupsBindingNavigatorSaveItem;
        internal System.Windows.Forms.DataGridView groupsDataGridView;
        private System.Windows.Forms.TextBox courseNumberTextBox;
        private System.Windows.Forms.TextBox educationFormTextBox;
        private System.Windows.Forms.TextBox facultyNumberTextBox;
        private System.Windows.Forms.TextBox headmanNumberTextBox;
        private System.Windows.Forms.TextBox numberGroupTextBox;
        private System.Windows.Forms.TextBox specialtyNameTextBox;
        private System.Windows.Forms.BindingSource bsStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
