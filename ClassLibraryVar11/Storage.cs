using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Aspose.Cells;
using Aspose.Cells.Utility;
using Aspose.Words.Pdf2Word;
using Aspose.Words;

namespace DomainModel
{
    public partial class Storage
    {

        private static readonly Storage instance = new Storage();

        public static Storage Instance { get => instance; }

        private Storage()
        {
            db = new DataBase();

            cascadeDelete = false; //ToDo 3

            //ToDo 4
            DataBaseSerializable dbs = new DataBaseSerializable(db);

            saveFormat = SaveFormat.bin;
            try
            {
                saveFile = GetSaveFile();
            }
            catch { }
        }

        public partial class DataBase
        {
            public GroupList groups { get; set; }
            public StudentList students { get; set; }
            public RatingList ratings { get; set; }

            public DataBase()
            {
                groups = new GroupList();
                students = new StudentList();
                ratings = new RatingList();

            }

            public DataBase(DataBaseSerializable dbs)
            {
                this.groups = new GroupList(dbs.groups);
                this.students = new StudentList(dbs.students);
                this.ratings = new RatingList(dbs.ratings);
            }
        }

        [Serializable]
        public class DataBaseSerializable
        {
            public List<Group> groups { get; set; }
            public List<Student> students { get; set; }
            public List<Rating> ratings { get; set; }

            public DataBaseSerializable (DataBase db)
            {
                groups = db.groups.GetList();
                students = db.students.GetList();
                ratings = db.ratings.GetList();
            }

            public DataBaseSerializable() { }
        }

        public DataBase db { get; private set; }

        public DataBaseSerializable dbs { get; private set; }

    }
}

namespace DomainModel
{
    public partial class Storage
    {

        public bool cascadeDelete;

        public bool AllowRemoveGroup(string groupName)
        {
            //bool res = (from p in db.students where p.GroupNumber == groupName select p);
            bool res = db.students.FirstOrDefault(p => p.GroupNumber == groupName) == null;
            return res;
        }

        public bool AllowRemoveStudent(string studentNumber)
        {
            bool res = db.ratings.FirstOrDefault(p => p.studentNumber == studentNumber) == null;
            return res;
        }

        public void CascadeDelete(Student student)
        {
            var relatedRatings = Storage.Instance.db.ratings.Where(p => p.studentNumber == student.studentNumber);

            foreach (Rating rating in relatedRatings.ToList())
            {
                CascadeDelete(rating);
            }

            db.students.Remove(student);
        }

        public void CascadeDelete(Rating rating)
        {
            db.ratings.Remove(rating);
        }

        //public bool RemoveCascadeGroup()
    }
}

namespace DomainModel
{
    //ToDo #4
    public partial class Storage
    {

        public string saveFile;

        private string GetSaveFile()
        {
            using (StreamReader streamReader = new StreamReader("savefile.txt"))
            {
                string str = streamReader.ReadLine();
                switch (streamReader.ReadLine())
                {
                    case "bin": saveFormat = SaveFormat.bin; break;
                    case "xml": saveFormat = SaveFormat.xml; break;
                    case "json": saveFormat = SaveFormat.json; break;
                    default: saveFormat = SaveFormat.bin; break;
                }
                streamReader.Close();
                return str;
            }
        }

        private void TakeSaveFile(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter("savefile.txt", false))
            {
                saveFile = filename;
                streamWriter.WriteLine(filename);
                switch (saveFormat)
                {
                    case SaveFormat.bin: streamWriter.WriteLine("bin"); break;
                    case SaveFormat.xml: streamWriter.WriteLine("xml"); break;
                    case SaveFormat.json: streamWriter.WriteLine("json"); break;
                }
                streamWriter.Close();
            }
        }

        [Serializable]
        public partial class DataBase { }

        public enum SaveFormat { bin, xml, json };

        public SaveFormat saveFormat { get; set; }
        
        public void SaveLast()
        {
            try
            {
                saveFile = GetSaveFile();

                switch (saveFormat)
                {
                    case SaveFormat.bin:
                        SaveBin(saveFile);
                        break;
                    case SaveFormat.xml:
                        SaveXml(saveFile);
                        break;
                    case SaveFormat.json:
                        SaveJson(saveFile);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Не вдалося зберегти інформацію у файл", "Помилка", MessageBoxButtons.OK);
            }
        }

        public void LoadLast()
        {
            try
            {
                saveFile = GetSaveFile();    

                switch (saveFormat)
                {
                    case SaveFormat.bin:
                        LoadBin(saveFile);
                        break;
                    case SaveFormat.xml:
                        LoadXml(saveFile);
                        break;
                    case SaveFormat.json:
                        LoadJson(saveFile);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Не вдалося завантажити інформацію з файлу", "Помилка", MessageBoxButtons.OK);
            }
        }

        public void Save ()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = saveFileDialog.FileName;

            TakeSaveFile(filename);
            //try
            //{
                switch (saveFormat)
                {
                    case SaveFormat.bin:
                        SaveBin(filename);
                        break;
                    case SaveFormat.xml:
                        SaveXml(filename);
                        break;
                    case SaveFormat.json:
                        SaveJson(filename);
                        break;
                }
            //}
            //catch { MessageBox.Show("Не вдалося зберегти інформацію у файл. Спробуйте змінити " +
                //"засіб серіалізації або перевиберіть файл.", "Помилка", MessageBoxButtons.OK); }
        }

        public void Load()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = openFileDialog.FileName;

            TakeSaveFile(filename);

            try
            {
                switch (saveFormat)
                {
                    case SaveFormat.bin:
                        LoadBin(filename);
                        break;
                    case SaveFormat.xml:
                        LoadXml(filename);
                        break;
                    case SaveFormat.json:
                        LoadJson(filename);
                        break;
                }
            }
            catch { MessageBox.Show("Не вдалося завантажити інформацію з файлу. Спробуйте змінити " +
                "засіб десеріалізації або перевиберіть файл.", "Помилка", MessageBoxButtons.OK); }
        }

        private void SaveBin(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                dbs = new DataBaseSerializable(db);
                //formatter.Serialize(file, db);
                formatter.Serialize(file, dbs);
                file.Close();
            }
        }

        private void LoadBin(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(filename, FileMode.Open))
            {
                dbs = (DataBaseSerializable)formatter.Deserialize(file);
                db.groups = new GroupList(dbs.groups);
                db.students = new StudentList(dbs.students);
                db.ratings = new RatingList(dbs.ratings);
                file.Close();
            }
        }

        private void SaveJson(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename, false))
            {
                string jsonSave = JsonSerializer.Serialize(db);
                file.Write(jsonSave);
                file.Close();
            }
        }

        private void LoadJson(string filename)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                string jsonLoad = file.ReadToEnd();
                db = JsonSerializer.Deserialize<DataBase>(jsonLoad);
                file.Close();
            }
        }

        private void SaveXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataBaseSerializable));
            using (FileStream fls = new FileStream(filename, FileMode.Create))
            {
                dbs = new DataBaseSerializable(db);
                //formatter.Serialize(file, db);
                serializer.Serialize(fls, dbs);
                fls.Close();
            }
        }

        private void LoadXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataBaseSerializable));
            using (FileStream fls = new FileStream(filename, FileMode.Open))
            {
                dbs = (DataBaseSerializable)serializer.Deserialize(fls);
                db.groups = new GroupList(dbs.groups);
                db.students = new StudentList(dbs.students);
                db.ratings = new RatingList(dbs.ratings);
                fls.Close();
            }
        }

    }

}

namespace DomainModel
{
    public partial class Storage
    {

        public void ConvertToExcel()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel |*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = saveFileDialog.FileName;

            Workbook workbook = new Workbook();
            Worksheet worksheet = (Worksheet)workbook.Worksheets[0];

            string jsonInput = JsonSerializer.Serialize(db);

            JsonLayoutOptions options = new JsonLayoutOptions();
            options.ArrayAsTable = true;

            JsonUtility.ImportData(jsonInput, worksheet.Cells, 3, 3, options);

            workbook.Save(filename);

            //Excel.Application xlApp = new Excel.ApplicationClass();
            //Excel.Workbook xlBook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            //Excel.Worksheet xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);

            //xlSheet.Activate();
        }

        public void ConvertToWord()
        {
            string filename;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.Filter = "Word Documents|*.docx";

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

                filename = saveFileDialog.FileName;
            }

            Workbook workbook = new Workbook();
            Worksheet worksheet = (Worksheet)workbook.Worksheets[0];

            string jsonInput = JsonSerializer.Serialize(db);

            JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, new JsonLayoutOptions());

            CreateFile("output.pdf");

            Aspose.Words.Pdf2Word.PdfDocumentReaderPlugin pdf2Word = new PdfDocumentReaderPlugin();

            workbook.Save("output.pdf", Aspose.Cells.SaveFormat.Pdf);

            var document = new Document("output.pdf");


            document.Save(filename, Aspose.Words.SaveFormat.Docx);

            //SaveDocument(document, filename);

        }

        private void CreateFile(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                file.Close();
            }
        }

        private void SaveDocument (Document document, string filename)
        {
        }
    }
}
