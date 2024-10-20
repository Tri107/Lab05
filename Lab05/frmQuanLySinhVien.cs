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
        BindingList<StudentViewModel> student;

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
            dgvDanhSachSinhVien.DataSource = null;  // Reset lại DataSource
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

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < students.Count)
            {
                var selectedStudent = students[e.RowIndex];
                txtMaSinhVien.Text = selectedStudent.StudentID.ToString();
                txtHoTen.Text = selectedStudent.StudentName;
                txtDiemTB.Text = selectedStudent.AverageScore;
                cbxKhoa.Text = selectedStudent.FacultyName;  
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new StudentViewModel
                {
                    StudentID = txtMaSinhVien.Text,
                    StudentName = txtHoTen.Text,
                    AverageScore = txtDiemTB.Text,
                    FacultyName = cbxKhoa.Text
                };
                students.Add(student);  // Thêm sinh viên vào BindingList
                BindToDGV(students);  // Cập nhật lại DataGridView
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSinhVien.SelectedRows.Count > 0)
            {
                var rowIndex = dgvDanhSachSinhVien.SelectedRows[0].Index;
                students.RemoveAt(rowIndex);  // Xóa sinh viên tại vị trí đã chọn trong BindingList
                BindToDGV(students);  // Cập nhật lại DataGridView
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            cbxKhoa.SelectedIndex = -1;  // Bỏ chọn khoa
            MessageBox.Show("Đã hủy bỏ các thông tin vừa nhập", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();  // Đóng form
            }
        }

        private void btnAddAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";  // Lọc các loại tệp ảnh
            openFileDialog.Title = "Chọn ảnh sinh viên";

            // Nếu người dùng chọn ảnh thành công
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh đã chọn lên PictureBox (giả sử có PictureBox tên là pictureBoxAnh)
                picAnhDaiDien.Image = Image.FromFile(openFileDialog.FileName);
                picAnhDaiDien.SizeMode = PictureBoxSizeMode.StretchImage;  // Tùy chỉnh kích thước hiển thị
                MessageBox.Show("Đã thêm ảnh thành công!", "Thông báo");
            }
        }

        private void btnXoaTimMa_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaNhanVienXoa.Text;

            // Kiểm tra xem mã sinh viên có rỗng hay không
            if (string.IsNullOrEmpty(maSinhVien))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên để xóa!", "Thông báo");
                return;
            }

            // Tìm sinh viên theo mã sinh viên trong danh sách
            var studentToRemove = students.FirstOrDefault(s => s.StudentID == maSinhVien);

            // Kiểm tra xem sinh viên có tồn tại hay không
            if (studentToRemove != null)
            {
                // Xóa sinh viên khỏi danh sách
                students.Remove(studentToRemove);

                // Cập nhật lại DataGridView sau khi xóa
                BindToDGV(students);

                MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + maSinhVien, "Thông báo");
            }
        }

        private void chkChuaDkChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChuaDkChuyenNganh.Checked)
            {
                // Lọc danh sách sinh viên chưa đăng ký chuyên ngành
                var filteredStudents = students.Where(s => string.IsNullOrEmpty(s.MajorName)).ToList();
                BindToDGV(filteredStudents);  // Hiển thị danh sách lọc
            }
            else
            {
                BindToDGV(students);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();

        }
    }
        
    
}
