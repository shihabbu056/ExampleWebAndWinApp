using ExampleWebAndWin.Bll.Bll;
using ExampleWebAndWin.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWinApp.Screens
{
    public partial class StudentInfoForm : Form
    {
        //private Student _student;
        private StudentManager _studentManager;
        private List<Student> students = new List<Student>();
        private Student _student;
        private int cellSelectedRow;
        public StudentInfoForm()
        {
            InitializeComponent();
           // _student = new Student();
            _studentManager = new StudentManager();
            
        }       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _student = new Student();
            _student.StudentId = Convert.ToInt32(textBoxStudentId.Text);
            _student.FirstName = textBoxFirstName.Text;
            _student.LastName = textBoxLastName.Text;
            _student.Email = textBoxEmail.Text;
            _student.RollNo = Convert.ToInt64(textBoxRollNo.Text);
            _student.Contact = Convert.ToInt64(textBoxRollNo.Text);
            students.Add(_student);

            MessageBox.Show("Student Save Successfully.");
            dataGridViewDisplayAllStudent.DataSource = null;
            dataGridViewDisplayAllStudent.DataSource = students;

            ClearTextBox();
            

        }
        public void ClearTextBox()
        {
            textBoxStudentId.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxRollNo.Text = "";
            textBoxContact.Text = "";
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            //dataGridViewDisplayAllStudent = null;
            dataGridViewDisplayAllStudent.DataSource = students;
            //foreach (Student studentss in students)
            //{
            //    dataGridViewDisplayAllStudent.DataSource = studentss;
            //}
            //DisplayAllStudent(student);
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataGrid = dataGridViewDisplayAllStudent.Rows[cellSelectedRow];
            newDataGrid.Cells[0].Value = textBoxStudentId.Text;
            newDataGrid.Cells[1].Value = textBoxFirstName.Text;
            newDataGrid.Cells[2].Value = textBoxLastName.Text;
            newDataGrid.Cells[3].Value = textBoxEmail.Text;
            newDataGrid.Cells[4].Value = textBoxRollNo.Text;
            newDataGrid.Cells[5].Value = textBoxContact.Text;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cellSelectedRow = dataGridViewDisplayAllStudent.CurrentCell.RowIndex;
            dataGridViewDisplayAllStudent.Rows.RemoveAt(cellSelectedRow);
        }

        private void dataGridViewDisplayAllStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewDisplayAllStudent.Rows[cellSelectedRow];
            textBoxStudentId.Text = row.Cells[0].Value.ToString();
            textBoxFirstName.Text = row.Cells[1].Value.ToString();
            textBoxLastName.Text = row.Cells[2].Value.ToString();
            textBoxEmail.Text = row.Cells[3].Value.ToString();
            textBoxRollNo.Text = row.Cells[4].Value.ToString();
            textBoxContact.Text = row.Cells[5].Value.ToString();
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            buttonSave.Text = "Add New";
        }

        //private void DisplayAllStudent(Student student)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
