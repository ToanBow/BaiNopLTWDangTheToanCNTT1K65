using System.Diagnostics;

namespace DttLesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dtt Lesson01");
            string choice;
            List<Student> students = new List<Student>(){
                new Student {maSinhVien="241230865",hoTen="Dang The Toan", ngaySinh=new DateTime(2006,06,25), gioiTinh=true,email="thetoan.official@gmail.com",soDienThoai="0379111973",nganhHoc="CNTT",diemTrungBinh=10,trangThai=true},
                new Student {maSinhVien="241230650",hoTen="Mai Thanh An", ngaySinh=new DateTime(2006,09,04), gioiTinh=true,email="maithanhan@gmail.com",soDienThoai="0321415355",nganhHoc="CNTT",diemTrungBinh=7,trangThai=true},
                new Student {maSinhVien="241230652",hoTen="Bui Hai Anh", ngaySinh=new DateTime(2006,06,12), gioiTinh=true,email="haianh@gmail.com",soDienThoai="032432455",nganhHoc="CNTT",diemTrungBinh=8,trangThai=true},
                new Student {maSinhVien="241230850",hoTen="Trinh Van Thang", ngaySinh=new DateTime(2006,06,24), gioiTinh=true,email="trinhthang@gmail.com",soDienThoai="092323455",nganhHoc="CNTT",diemTrungBinh=9,trangThai=true},
                new Student {maSinhVien="241230839",hoTen="Nguyen Trong Tan", ngaySinh=new DateTime(2006,12,24), gioiTinh=true,email="tttan@gmail.com",soDienThoai="0624923492",nganhHoc="CNTT",diemTrungBinh=8,trangThai=true}
             };
            do
            {
                ChucNang();
                Console.Write("Nhap lua chon cua ban: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ThemSinhVien(students);
                        break;
                    case "2":
                        HienThiSinhVien(students);
                        break;
                    case "3":
                        TimSinhVienTheoMa(students);
                        break;
                    case "4":
                        TimGanDungTheoHoTen(students);
                        break;
                    case "5":
                        CapNhatSinhVien(students);
                        break;
                    case "6":
                        XoaSinhVien(students);
                        break;
                    case "7":
                        SapXepTheoHoTen(students);
                        break;
                    case "8":
                        SapXepTheoDiemTrungBinh(students);
                        break;
                    case "9":
                        HienThiSinhVienCoDiemTu8TroLen(students);
                        break;
                    case "10":
                        HienThiSinhVienCoDiemCaoNhat(students);
                        break;
                    case "11":
                        TinhDiemTrungBinhToanBoSinhVien(students);
                        break;
                    case "12":
                        ThongKeSinhVienTheoNganh(students);
                        break;
                    case "13":
                        ThongKeSinhVienTheoTrangThai(students);
                        break;
                    case "14":
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le vui long chon lai!");
                        break;
                }
            } while (choice != "14");
        }

        static void ChucNang()
        {
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim gan dung theo ho ten");
            Console.WriteLine("5. Cap nhat sinh vien");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo ho ten");
            Console.WriteLine("8. Sap xep theo diem trung binh");
            Console.WriteLine("9. Hien thi sinh vien co diem tu 8 tro len");
            Console.WriteLine("10. Hien thi sinh vien co diem cao nhat");
            Console.WriteLine("11. Tinh diem trung binh toan bo sinh vien");
            Console.WriteLine("12. Thong ke sinh vien theo nganh");
            Console.WriteLine("13. Thong ke sinh vien theo trang thai");
            Console.WriteLine("14. Thoat");
        }

        static void ThemSinhVien(List<Student> students)
        {
            Student student = new Student();
            Console.Write("Nhap ma sinh vien: ");
            student.maSinhVien = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            student.hoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            student.ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhap gioi tinh (true/false): ");
            student.gioiTinh = bool.Parse(Console.ReadLine());
            Console.Write("Nhap email: ");
            student.email = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            student.soDienThoai = Console.ReadLine();
            Console.Write("Nhap nganh hoc: ");
            student.nganhHoc = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            student.diemTrungBinh = float.Parse(Console.ReadLine());
            Console.Write("Nhap trang thai hoc tap (true/false): ");
            student.trangThai = bool.Parse(Console.ReadLine());
            students.Add(student);
        }

        static void HienThiSinhVien(List<Student> students)
        {
            Console.WriteLine("DANH SACH SINH VIEN");
            foreach (var student in students)
            {
                Console.WriteLine($"Ma SV: {student.maSinhVien}, Ho Ten: {student.hoTen}, Ngay Sinh: {student.ngaySinh}, Gioi tinh: {student.gioiTinh}, Email: {student.email}, So dien thoai: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem trung binh: {student.diemTrungBinh}, Trang thai hoc tap: {student.trangThai}\n");
            }
        }

        static void TimSinhVienTheoMa(List<Student> students)
        {
            string find;
            bool timThay = false;
            Console.Write("Nhap ma sinh vien can tim: ");
            find = Console.ReadLine();
            foreach (var student in students)
            {
                if(find == student.maSinhVien)
                {
                    timThay = true;
                    Console.WriteLine("THONG TIN SINH VIEN DA TIM THAY!");
                    Console.WriteLine($"Ma SV: {student.maSinhVien}, Ho Ten: {student.hoTen}, Ngay Sinh: {student.ngaySinh}, Gioi tinh: {student.gioiTinh}, Email: {student.email}, So dien thoai: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem trung binh: {student.diemTrungBinh}, Trang thai hoc tap: {student.trangThai}\n");
                }
            }
            if(timThay == false)
            {
                Console.WriteLine($"Khong tim thay sinh vien nao co ma sinh vien {find}");
            }
        }

        static void TimGanDungTheoHoTen(List<Student> students)
        {
            Console.Write("Nhap ten/ho ten can tim: ");
            string find = Console.ReadLine();
            bool timThay = false;
            foreach (var student in students) { 
                if(student.hoTen != null && student.hoTen.ToLower().Contains(find.ToLower()))
                {
                    timThay = true;
                    Console.WriteLine($"Ma SV: {student.maSinhVien}, Ho Ten: {student.hoTen}, Ngay Sinh: {student.ngaySinh}, Gioi tinh: {student.gioiTinh}, Email: {student.email}, So dien thoai: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem trung binh: {student.diemTrungBinh}, Trang thai hoc tap: {student.trangThai}\n");
                }
            }
            if (timThay == false)
            {
                Console.WriteLine($"Khong tim thay sinh vien nao co ho ten chua '{find}'");
            }
        }

        static void CapNhatSinhVien(List<Student> students)
        {
            bool timThay = false;
            Console.Write("Nhap ma sinh vien can cap nhat: ");
            string find = Console.ReadLine();
            foreach (var student in students)
            {
                if(find == student.maSinhVien)
                {
                    timThay = true;
                    Console.Write("Nhap ma sinh vien moi: ");
                    student.maSinhVien = Console.ReadLine();
                    Console.Write("Nhap ho ten moi: ");
                    student.hoTen = Console.ReadLine();
                    Console.Write("Nhap ngay sinh (dd/MM/yyyy) moi: ");
                    student.ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    Console.Write("Nhap gioi tinh (true/false) moi: ");
                    student.gioiTinh = bool.Parse(Console.ReadLine());
                    Console.Write("Nhap email moi: ");
                    student.email = Console.ReadLine();
                    Console.Write("Nhap so dien thoai moi: ");
                    student.soDienThoai = Console.ReadLine();
                    Console.Write("Nhap nganh hoc moi: ");
                    student.nganhHoc = Console.ReadLine();
                    Console.Write("Nhap diem trung binh moi: ");
                    student.diemTrungBinh = float.Parse(Console.ReadLine());
                    Console.Write("Nhap trang thai hoc tap (true/false) moi: ");
                    student.trangThai = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Cap nhat sinh vien thanh cong");
                    break;
                }
            }
            if (timThay == false)
            {
                Console.WriteLine($"Khong tim thay sinh voi voi ma sv {find}");
            }
        }

        static void XoaSinhVien(List<Student> students)
        {
            bool timThay = false;
            int index = -1;
            Console.Write("Nhap ma sinh vien can xoa: ");
            string find = Console.ReadLine();
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].maSinhVien == find)
                {
                    index = i;
                    break;
                }
            }
            if(index != -1)
            {
                Console.WriteLine($"Xoa thanh cong sinh vien co ma sinh vien {find}");
                students.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"Khong tim thay sinh vien nao co ma sinh vien {find}");
            }
        }

        static void SapXepTheoHoTen(List<Student> students)
        {
            for(int i = 0; i < students.Count - 1; i++)
            {
                for(int j = i + 1; j < students.Count; j++)
                {
                    if (string.Compare(students[i].hoTen, students[j].hoTen) > 0)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sap xep thanh cong (a-z) theo ho ten sv");
        }

        static void SapXepTheoDiemTrungBinh(List<Student> students)
        {
            for(int i=0;i<students.Count - 1; i++)
            {
                for(int j= i + 1; j < students.Count; j++)
                {
                    if (students[i].diemTrungBinh < students[j].diemTrungBinh)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sap xep danh sach theo so diem tb giam dan thanh cong!");
        }

        static void HienThiSinhVienCoDiemTu8TroLen(List<Student> students)
        {
            bool timthay = false;
            Console.WriteLine("DANH SACH SINH VIEN CO DIEM TRUNG BINH TU 8 TRO LEN");
            foreach(var student in students)
            {
                if (student.diemTrungBinh >= 8)
                {
                    timthay = true;
                    Console.WriteLine($"Ma SV: {student.maSinhVien}, Ho Ten: {student.hoTen}, Ngay Sinh: {student.ngaySinh}, Gioi tinh: {student.gioiTinh}, Email: {student.email}, So dien thoai: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem trung binh: {student.diemTrungBinh}, Trang thai hoc tap: {student.trangThai}\n");
                }
            }
            if (timthay == false)
            {
                Console.WriteLine("Khong co sinh vien co diem trung binh tu 8 tro len");
            }
        }

        static void HienThiSinhVienCoDiemCaoNhat(List<Student> students)
        {
            float diemMax = students[0].diemTrungBinh;
            for(int i = 0; i < students.Count; i++)
            {
                if (diemMax < students[i].diemTrungBinh)
                {
                    diemMax = students[i].diemTrungBinh;
                }
            }
            Console.WriteLine("DANH SACH SINH VIEN CO DIEM TRUNG BINH CAO NHAT");
            for(int i = 0; i < students.Count; i++)
            {
                if (diemMax == students[i].diemTrungBinh)
                {
                    Console.WriteLine($"Ma SV: {students[i].maSinhVien}, Ho Ten: {students[i].hoTen}, Ngay Sinh: {students[i].ngaySinh}, Gioi tinh: {students[i].gioiTinh}, Email: {students[i].email}, So dien thoai: {students[i].soDienThoai}, Nganh hoc: {students[i].nganhHoc}, Diem trung binh: {students[i].diemTrungBinh}, Trang thai hoc tap: {students[i].trangThai}\n");
                }
            }
        }

        static void TinhDiemTrungBinhToanBoSinhVien(List<Student> students)
        {
            float diemTBToanSV = 0;
            float sum = 0;
            foreach(var student in students)
            {
                sum+= student.diemTrungBinh;
            }
            diemTBToanSV = sum / students.Count;
            Console.WriteLine($"Diem trung binh cua tat ca sinh vien la: {diemTBToanSV}");
        }

        static void ThongKeSinhVienTheoNganh(List<Student> students)
        {
            List<string> dsNganh = new List<string>();
            foreach (var student in students)
            {
                bool daCo = false;
                foreach (var nganh in dsNganh)
                {
                    if (nganh == student.nganhHoc)
                    {
                        daCo = true;
                        break;
                    }
                }
                if (daCo == false)
                {
                    dsNganh.Add(student.nganhHoc);
                }
            }

            Console.WriteLine("DANH SACH SINH VIEN THEO NGANH");
            foreach(var nganh in dsNganh)
            {
                int dem = 0;
                foreach(var student in students)
                {
                    if(nganh == student.nganhHoc)
                    {
                        dem++;
                    }
                }
                Console.WriteLine($"Nganh {nganh} co so sinh vien la: {dem}");
            }
        }
        
        static void ThongKeSinhVienTheoTrangThai(List<Student> students)
        {
            int dangHoc = 0;
            int nghiHoc = 0;
            foreach(var student in students)
            {
                if(student.trangThai == true)
                {
                    dangHoc++;
                }
                else
                {
                    nghiHoc++;
                }
            }
            Console.WriteLine($"So luong sinh vien dang hoc la: {dangHoc}");
            Console.WriteLine($"So luong sinh vien da nghi hoc la: {nghiHoc}");
        }
    }
}