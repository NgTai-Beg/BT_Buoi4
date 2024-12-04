using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi4
{
    public partial class Form1 : Form
    {
        private BindingList<Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new BindingList<Student>();
        }
        private void OnStudentUpdated(Student updatedStudent)
        {
            MessageBox.Show($"Student updated: {updatedStudent.Name}");
        }

        private void OpenForm2(Student student = null)
        {
            Form2 form2 = new Form2(students, student);
            form2.StudentUpdated += OnStudentUpdated;
            form2.ShowDialog();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(students);

            if (form2.ShowDialog() == DialogResult.OK)
            {
                dataStudent.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new BindingList<Student>
            {
                new Student() { Id = 1, Name = "Teo", Luong = 1000 },
                new Student() { Id = 2, Name = "Tai", Luong = 2000 },
                new Student() { Id = 3, Name = "Teooo1", Luong = 200}
            };
            dataStudent.DataSource = students;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataStudent.CurrentRow != null)
            {
                Student selectedStudent = dataStudent.CurrentRow.DataBoundItem as Student;
                Form2 form2 = new Form2(students, selectedStudent);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    dataStudent.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataStudent.CurrentRow != null)
            {
                Student selectedStudent = dataStudent.CurrentRow.DataBoundItem as Student;
                students.Remove(selectedStudent);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
