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
    
    public partial class frmRegister : Form
    {
        private readonly StudentService studentServices = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();

        List<StudentViewModel> students;
        List<FacultyViewModel> faculties;
        BindingList<StudentViewModel> student;
        List<MajorViewModel> majors;
        public frmRegister()
        {
            InitializeComponent();
            cbxKhoa.SelectedIndexChanged += cbxKhoa_SelectedIndexChanged;
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadStudent();
            LoadFaculty();
            LoadMajor();
            BindToDGV(students);
            BindToCMBFaculty(faculties);
            BindToCBMMajor(majors);
        }

        private void BindToCBMMajor(List<MajorViewModel> majors)
        {
            cbxChuyenNganh.DataSource = majors;  // cbxMajor là ComboBox
            cbxChuyenNganh.DisplayMember = "MajorName";  // Sửa lại thành MajorName
            cbxChuyenNganh.ValueMember = "MajorID";
        }

        private void LoadMajor()
        {
            if (cbxKhoa.SelectedItem == null) return;

            // Lấy đối tượng FacultyViewModel từ SelectedItem
            var selectedFaculty = cbxKhoa.SelectedItem as FacultyViewModel;

            if (selectedFaculty != null)
            {
                int facultyID = selectedFaculty.FacultyID; // Lấy FacultyID từ đối tượng
                var majors = majorService.GetAllByFaculty(facultyID).Select(m => new MajorViewModel
                {
                    MajorID = m.MajorID,
                    MajorName = m.Name
                }).ToList();

                // Gọi phương thức BindToCBMMajor để hiển thị chuyên ngành
                BindToCBMMajor(majors);
            }
        }

        private void BindToCMBFaculty(List<FacultyViewModel> faculties)
        {
            cbxKhoa.DataSource = faculties;
            cbxKhoa.DisplayMember = "FacultyName";
            cbxKhoa.ValueMember = "FacultyID";
        }

        private void BindToDGV(List<StudentViewModel> students)
        {
            dgvDanhSachDangKy.DataSource = null;  // Reset lại DataSource
            dgvDanhSachDangKy.DataSource = students;
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
            students = studentServices.GetAll().Select(sv => new StudentViewModel
            {
                StudentID = sv.StudentID,
                StudentName = sv.FullName,  // Giả sử sv có thuộc tính FullName cho tên sinh viên
                FacultyName = sv.Faculty?.FacultyName,  // Tránh lỗi null khi Faculty có thể không tồn tại
                AverageScore = sv.AverageScore.ToString(),  // Chuyển điểm trung bình thành chuỗi
                MajorName = sv.Major?.Name  // Tránh lỗi null khi Major có thể không tồn tại
            }).ToList();

            // Gọi phương thức BindToDGV để hiển thị danh sách sinh viên trên DataGridView
            BindToDGV(students);
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMajor();
        }

        private void chkChuaDkChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxChuyenNganh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin sinh viên từ DataGridView
            var selectedStudent = dgvDanhSachDangKy.CurrentRow;
            if (selectedStudent == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)selectedStudent.Cells["StudentID"].Value; // Thay đổi theo tên cột thực tế
            int majorId = ((MajorViewModel)cbxChuyenNganh.SelectedItem).MajorID;

            // Gọi dịch vụ để thực hiện đăng ký
            var result = studentServices.RegisterMajor(studentId, majorId);
            if (result)
            {
                MessageBox.Show("Đăng ký chuyên ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudent(); // Tải lại danh sách sinh viên để cập nhật thông tin
                BindToDGV(students);
            }
            else
            {
                MessageBox.Show("Đăng ký chuyên ngành thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public class StudentService
        {
            // ... Các phương thức khác

            public bool RegisterMajor(int studentId, int majorId)
            {
                using (var context = new StudentModel())
                {
                    var student = context.Students.Find(studentId);
                    if (student != null)
                    {
                        student.MajorID = majorId; // Cập nhật MajorID cho sinh viên
                        context.SaveChanges(); // Lưu thay đổi
                        return true; // Đăng ký thành công
                    }
                    return false; // Sinh viên không tồn tại
                }
            }

           
        }

        private void btnDangKyChuyenNganh_Click(object sender, EventArgs e)
        {
            chkChuaDkChuyenNganh_CheckedChanged(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
