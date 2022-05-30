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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

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
            GroupsViewer1.groupsBindingSource.DataSource = Storage.Instance.db.groups;
            GroupsViewer1.groupsBindingSource.ResetBindings(true);

            students1.studentsBindingSource.DataSource = Storage.Instance.db.students;
            students1.studentsBindingSource.ResetBindings(true);
            students1.bsGroupRegistry.DataSource = Storage.Instance.db.groups;
            students1.bsGroupRegistry.ResetBindings(true);

            ratings1.ratingsBindingSource.DataSource = Storage.Instance.db.ratings;
            ratings1.ratingsBindingSource.ResetBindings(true);
            ratings1.bsStudentRegistry.DataSource = Storage.Instance.db.students;
            ratings1.bsStudentRegistry.ResetBindings(true);

            //label1.Text = Storage.Instance.db.groups.Count().ToString();
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

        private void ConvertToExcel(Excel.Worksheet worksheet, DataGridView DGV)
        {
            Excel.Range CR = (Excel.Range)worksheet.Cells[2, 1];
            CR.Select();

            int ColumnCount = DGV.ColumnCount;

            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                worksheet.Cells[1, c + 1] = DGV.Columns[c].HeaderText;
            }

            copyDataGridViewtoClipboard(DGV, CR, worksheet);

            ReleaseObject(CR);
        }

        private void copyDataGridViewtoClipboard(DataGridView dataGridView, Excel.Range CR, Excel.Worksheet xlSheet)
        {
            Clipboard.Clear();
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
                xlSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }

        public void ExportToExcel()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel | *.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = saveFileDialog.FileName;

            Excel.Application xlApp = new Excel.ApplicationClass();
            Excel.Workbook xlBook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);

            xlSheet.Name = "Groups";

            ConvertToExcel(xlSheet, GroupsViewer1.groupsDataGridView);

            xlSheet = (Excel.Worksheet)xlBook.Worksheets.Add();
            xlSheet.Name = "Students";

            ConvertToExcel(xlSheet, students1.studentsDataGridView);

            xlSheet = (Excel.Worksheet)xlBook.Worksheets.Add();
            xlSheet.Name = "Ratings";

            ConvertToExcel(xlSheet, ratings1.ratingsDataGridView);

            xlBook.SaveAs(filename);

            foreach (Excel.Worksheet worksheet in xlBook.Worksheets)
            {
                ReleaseObject(worksheet);
            }

            ReleaseObject(xlSheet);
            ReleaseObject(xlBook);

            xlApp.Quit();

            ReleaseObject(xlApp);

        }

        void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            GC.Collect();
        }

        public void ExportToWord()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = saveFileDialog.FileName;

            Word.Document oDoc = new Word.Document();

            Word.Paragraph oPar = oDoc.Paragraphs.Add();
            ConvertToWord(oPar, oDoc, GroupsViewer1.groupsDataGridView, "Groups");
            
            oPar = oDoc.Paragraphs.Add();
            ConvertToWord(oPar, oDoc, students1.studentsDataGridView, "Students");

            oPar = oDoc.Paragraphs.Add(); 
            ConvertToWord(oPar, oDoc, ratings1.ratingsDataGridView, "Ratings");
            oDoc.SaveAs(filename);

            ReleaseObject(oPar);
            ReleaseObject(oDoc);

        }

        private void ConvertToWord(Word.Paragraph oPar, Word.Document oDoc, DataGridView DGV, string nameDGV) 
        {
            if (DGV.Rows.Count == 0) return;

            oPar.Range.Font.Name = "Times New Roman";
            oPar.Range.Font.Size = 14;
            oPar.Range.Font.Bold = 1;
            oPar.Range.Text = nameDGV;

            oPar.Range.InsertParagraphAfter();

            oPar = oDoc.Paragraphs.Add();

            int RowCount = DGV.Rows.Count;
            int ColumnCount = DGV.Columns.Count;
            Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

            for (int r = 0; r < RowCount; r++)
            {
                for (int c = 0; c < ColumnCount; c++)
                {
                    DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                }
            }

            //oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

            dynamic oRange = oPar.Range;

            string oTemp = "";
            for (int r = 0; r <= RowCount - 1; r++)
            {
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oTemp = oTemp + DataArray[r, c] + "\t";

                }
            }

            oRange.Text = oTemp;
            
            object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
            object ApplyBorders = true;
            object AutoFit = true;
            object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

            oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                  Type.Missing, Type.Missing, ref ApplyBorders,
                                  Type.Missing, Type.Missing, Type.Missing,
                                  Type.Missing, Type.Missing, Type.Missing,
                                  Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

            oRange.Select();

            label1.Text = oDoc.Tables.Count.ToString();

            oDoc.Application.Selection.Tables[1].Select();
            oDoc.Application.Selection.Tables[1].Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            oDoc.Application.Selection.Tables[1].Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
            oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
            oDoc.Application.Selection.Tables[1].Rows[1].Select();
            oDoc.Application.Selection.InsertRowsAbove(1);
            oDoc.Application.Selection.Tables[1].Rows[1].Select();

            oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
            oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
            oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 12;

            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
            }

            oPar.Range.InsertParagraphAfter();

            //oDoc.Application.Selection.Tables[oDoc.Tables.Count].set_Style("Grid Table 4 - Accent 5");
            //oDoc.Application.Selection.Tables[oDoc.Tables.Count].Rows[1].Select();
            //oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
        }


        //Код взятий з інтернету і перероблений під потреби
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;

                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

    }
}
