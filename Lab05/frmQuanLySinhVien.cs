using Lab05.BUS;
using Lab05.BUS.ViewModel;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab05
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        List<StudentViewModel> students;
        List<FacultyViewModel> faculties;

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadStudent();
            LoadFaculty();
            BindToDGV(students);
            BindToCMB(faculties);
        }

        private void BindToCMB(List<FacultyViewModel> faculties)
        {
            cbxKhoa.DataSource = faculties;
            cbxKhoa.DisplayMember = "FacultyName";
            cbxKhoa.ValueMember = "FacultyID";
        }

        private void BindToDGV(List<StudentViewModel> students)
        {
            dgvDanhSachSinhVien.DataSource = students;
        }

        private void LoadFaculty()
        {
            faculties = facultyService.GetAll().Select(k => new FacultyViewModel
            {
                FacultyID = k.FacultyID,
                FacultyName = k.FacultyName,
            }).ToList();
        }

        private void LoadStudent()
        {
            students = studentService.GetAll().Select(sv => new StudentViewModel
            {
                StudentID =sv.StudentID,
                StudentName = sv.FullName,  // Sử dụng đúng thuộc tính FullName
                FacultyName = sv.Faculty?.FacultyName,  // Tránh lỗi null
                AverageScore = sv.AverageScore.ToString(),
                MajorName = sv.Major?.Name
            }).ToList();
        }




    }
        
    
}
