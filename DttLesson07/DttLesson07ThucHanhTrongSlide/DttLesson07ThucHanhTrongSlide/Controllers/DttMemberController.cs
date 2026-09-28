using System.Text.RegularExpressions;
using DttLesson07ThucHanhTrongSlide.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttLesson07ThucHanhTrongSlide.Controllers
{
    public class DttMemberController : Controller
    {
        public static readonly List<DttMember> _dttmembers = new List<DttMember>()
    {
        new DttMember { DttMemberId = "M001", DttUserName = "member001", DttFullName = "Nguyễn Văn An", DttEmail = "an.nv001@example.com", DttPassword = "Pass@1001", DttPhone = "0901234001", DttBirthday = new DateTime(2000, 5, 12) },
    new DttMember { DttMemberId = "M002", DttUserName = "member002", DttFullName = "Trần Thị Bình", DttEmail = "binh.tt002@example.com", DttPassword = "Pass@1002", DttPhone = "0901234002", DttBirthday = new DateTime(1999, 8, 20) },
    new DttMember { DttMemberId = "M003", DttUserName = "member003", DttFullName = "Lê Hoàng Long", DttEmail = "long.lh003@example.com", DttPassword = "Pass@1003", DttPhone = "0901234003", DttBirthday = new DateTime(2001, 3, 15) },
    new DttMember { DttMemberId = "M004", DttUserName = "member004", DttFullName = "Phạm Minh Châu", DttEmail = "chau.pm004@example.com", DttPassword = "Pass@1004", DttPhone = "0901234004", DttBirthday = new DateTime(2002, 11, 4) },
    new DttMember { DttMemberId = "M005", DttUserName = "member005", DttFullName = "Hoàng Gia Huy", DttEmail = "huy.hg005@example.com", DttPassword = "Pass@1005", DttPhone = "0901234005", DttBirthday = new DateTime(1998, 7, 25) },
    new DttMember { DttMemberId = "M006", DttUserName = "member006", DttFullName = "Vũ Ngọc Mai", DttEmail = "mai.vn006@example.com", DttPassword = "Pass@1006", DttPhone = "0901234006", DttBirthday = new DateTime(2000, 1, 30) },
    new DttMember { DttMemberId = "M007", DttUserName = "member007", DttFullName = "Bùi Đức Anh", DttEmail = "anh.bd007@example.com", DttPassword = "Pass@1007", DttPhone = "0901234007", DttBirthday = new DateTime(2001, 9, 18) },
    new DttMember { DttMemberId = "M008", DttUserName = "member008", DttFullName = "Đặng Thu Hà", DttEmail = "ha.dt008@example.com", DttPassword = "Pass@1008", DttPhone = "0901234008", DttBirthday = new DateTime(1999, 12, 5) },
    new DttMember { DttMemberId = "M009", DttUserName = "member009", DttFullName = "Ngo Quốc Bảo", DttEmail = "bao.nq009@example.com", DttPassword = "Pass@1009", DttPhone = "0901234009", DttBirthday = new DateTime(2002, 4, 22) },
    new DttMember { DttMemberId = "M010", DttUserName = "member010", DttFullName = "Dương Thùy Linh", DttEmail = "linh.dt010@example.com", DttPassword = "Pass@1010", DttPhone = "0901234010", DttBirthday = new DateTime(2000, 6, 14) },
    new DttMember { DttMemberId = "M011", DttUserName = "member011", DttFullName = "Nguyễn Văn Hải", DttEmail = "hai.nv011@example.com", DttPassword = "Pass@1011", DttPhone = "0901234011", DttBirthday = new DateTime(2001, 2, 10) },
    new DttMember { DttMemberId = "M012", DttUserName = "member012", DttFullName = "Trần Thị Lan", DttEmail = "lan.tt012@example.com", DttPassword = "Pass@1012", DttPhone = "0901234012", DttBirthday = new DateTime(1999, 10, 8) },
    new DttMember { DttMemberId = "M013", DttUserName = "member013", DttFullName = "Lê Văn Hùng", DttEmail = "hung.lv013@example.com", DttPassword = "Pass@1013", DttPhone = "0901234013", DttBirthday = new DateTime(2000, 12, 19) },
    new DttMember { DttMemberId = "M014", DttUserName = "member014", DttFullName = "Phạm Thị Mai", DttEmail = "mai.pt014@example.com", DttPassword = "Pass@1014", DttPhone = "0901234014", DttBirthday = new DateTime(2002, 5, 27) },
    new DttMember { DttMemberId = "M015", DttUserName = "member015", DttFullName = "Hoàng Văn Nam", DttEmail = "nam.hv015@example.com", DttPassword = "Pass@1015", DttPhone = "0901234015", DttBirthday = new DateTime(1998, 8, 16) },
    new DttMember { DttMemberId = "M016", DttUserName = "member016", DttFullName = "Vũ Thị Phương", DttEmail = "phuong.vt016@example.com", DttPassword = "Pass@1016", DttPhone = "0901234016", DttBirthday = new DateTime(2001, 3, 29) },
    new DttMember { DttMemberId = "M017", DttUserName = "member017", DttFullName = "Bùi Văn Quân", DttEmail = "quan.bv017@example.com", DttPassword = "Pass@1017", DttPhone = "0901234017", DttBirthday = new DateTime(2000, 7, 11) },
    new DttMember { DttMemberId = "M018", DttUserName = "member018", DttFullName = "Đặng Thị Thảo", DttEmail = "thao.dt018@example.com", DttPassword = "Pass@1018", DttPhone = "0901234018", DttBirthday = new DateTime(1999, 1, 24) },
    new DttMember { DttMemberId = "M019", DttUserName = "member019", DttFullName = "Ngô Văn Tuấn", DttEmail = "tuan.nv019@example.com", DttPassword = "Pass@1019", DttPhone = "0901234019", DttBirthday = new DateTime(2002, 9, 13) },
    new DttMember { DttMemberId = "M020", DttUserName = "member020", DttFullName = "Dương Thị Vân", DttEmail = "van.dt020@example.com", DttPassword = "Pass@1020", DttPhone = "0901234020", DttBirthday = new DateTime(2001, 6, 2) },
    new DttMember { DttMemberId = "M021", DttUserName = "member021", DttFullName = "Nguyễn Hoàng Sơn", DttEmail = "son.nh021@example.com", DttPassword = "Pass@1021", DttPhone = "0901234021", DttBirthday = new DateTime(2000, 4, 18) },
    new DttMember { DttMemberId = "M022", DttUserName = "member022", DttFullName = "Trần Minh Thư", DttEmail = "thu.tm022@example.com", DttPassword = "Pass@1022", DttPhone = "0901234022", DttBirthday = new DateTime(1999, 11, 25) },
    new DttMember { DttMemberId = "M023", DttUserName = "member023", DttFullName = "Lê Quang Vinh", DttEmail = "vinh.lq023@example.com", DttPassword = "Pass@1023", DttPhone = "0901234023", DttBirthday = new DateTime(2001, 8, 7) },
    new DttMember { DttMemberId = "M024", DttUserName = "member024", DttFullName = "Phạm Hồng Yến", DttEmail = "yen.ph024@example.com", DttPassword = "Pass@1024", DttPhone = "0901234024", DttBirthday = new DateTime(2002, 2, 14) },
    new DttMember { DttMemberId = "M025", DttUserName = "member025", DttFullName = "Hoàng Tuấn Kiệt", DttEmail = "kiet.ht025@example.com", DttPassword = "Pass@1025", DttPhone = "0901234025", DttBirthday = new DateTime(1998, 10, 31) },
    new DttMember { DttMemberId = "M026", DttUserName = "member026", DttFullName = "Vũ Thanh Hằng", DttEmail = "hang.vt026@example.com", DttPassword = "Pass@1026", DttPhone = "0901234026", DttBirthday = new DateTime(2000, 12, 9) },
    new DttMember { DttMemberId = "M027", DttUserName = "member027", DttFullName = "Bùi Tiến Dũng", DttEmail = "dung.bt027@example.com", DttPassword = "Pass@1027", DttPhone = "0901234027", DttBirthday = new DateTime(2001, 5, 21) },
    new DttMember { DttMemberId = "M028", DttUserName = "member028", DttFullName = "Đặng Mỹ Linh", DttEmail = "linh.dm028@example.com", DttPassword = "Pass@1028", DttPhone = "0901234028", DttBirthday = new DateTime(1999, 3, 17) },
    new DttMember { DttMemberId = "M029", DttUserName = "member029", DttFullName = "Ngô Thanh Phong", DttEmail = "phong.nt029@example.com", DttPassword = "Pass@1029", DttPhone = "0901234029", DttBirthday = new DateTime(2002, 7, 6) },
    new DttMember { DttMemberId = "M030", DttUserName = "member030", DttFullName = "Dương Quốc Việt", DttEmail = "viet.dq030@example.com", DttPassword = "Pass@1030", DttPhone = "0901234030", DttBirthday = new DateTime(2000, 1, 19) },
    new DttMember { DttMemberId = "M031", DttUserName = "member031", DttFullName = "Nguyễn Văn Bình", DttEmail = "binh.nv2031@example.com", DttPassword = "Pass@1031", DttPhone = "0901234031", DttBirthday = new DateTime(2001, 9, 28) },
    new DttMember { DttMemberId = "M032", DttUserName = "member032", DttFullName = "Trần Thị Cúc", DttEmail = "cuc.tt032@example.com", DttPassword = "Pass@1032", DttPhone = "0901234032", DttBirthday = new DateTime(1999, 6, 11) },
    new DttMember { DttMemberId = "M033", DttUserName = "member033", DttFullName = "Lê Văn Đạt", DttEmail = "dat.lv033@example.com", DttPassword = "Pass@1033", DttPhone = "0901234033", DttBirthday = new DateTime(2000, 11, 3) },
    new DttMember { DttMemberId = "M034", DttUserName = "member034", DttFullName = "Pham Thị Huệ", DttEmail = "hue.pt034@example.com", DttPassword = "Pass@1034", DttPhone = "0901234034", DttBirthday = new DateTime(2002, 4, 15) },
    new DttMember { DttMemberId = "M035", DttUserName = "member035", DttFullName = "Hoàng Văn Khoa", DttEmail = "khoa.hv035@example.com", DttPassword = "Pass@1035", DttPhone = "0901234035", DttBirthday = new DateTime(1998, 12, 27) },
    new DttMember { DttMemberId = "M036", DttUserName = "member036", DttFullName = "Vũ Thị Lan", DttEmail = "lan.vt2036@example.com", DttPassword = "Pass@1036", DttPhone = "0901234036", DttBirthday = new DateTime(2001, 7, 8) },
    new DttMember { DttMemberId = "M037", DttUserName = "member037", DttFullName = "Bùi Văn Minh", DttEmail = "minh.bv037@example.com", DttPassword = "Pass@1037", DttPhone = "0901234037", DttBirthday = new DateTime(2000, 2, 23) },
    new DttMember { DttMemberId = "M038", DttUserName = "member038", DttFullName = "Đặng Thị Nga", DttEmail = "nga.dt038@example.com", DttPassword = "Pass@1038", DttPhone = "0901234038", DttBirthday = new DateTime(1999, 8, 19) },
    new DttMember { DttMemberId = "M039", DttUserName = "member039", DttFullName = "Ngô Văn Phúc", DttEmail = "phuc.nv039@example.com", DttPassword = "Pass@1039", DttPhone = "0901234039", DttBirthday = new DateTime(2002, 10, 5) },
    new DttMember { DttMemberId = "M040", DttUserName = "member040", DttFullName = "Dương Thị Quỳnh", DttEmail = "quynh.dt040@example.com", DttPassword = "Pass@1040", DttPhone = "0901234040", DttBirthday = new DateTime(2001, 3, 12) },
    new DttMember { DttMemberId = "M041", DttUserName = "member041", DttFullName = "Nguyễn Văn Sơn", DttEmail = "son.nv041@example.com", DttPassword = "Pass@1041", DttPhone = "0901234041", DttBirthday = new DateTime(2000, 6, 25) },
    new DttMember { DttMemberId = "M042", DttUserName = "member042", DttFullName = "Trần Thị Tâm", DttEmail = "tam.tt042@example.com", DttPassword = "Pass@1042", DttPhone = "0901234042", DttBirthday = new DateTime(1999, 1, 9) },
    new DttMember { DttMemberId = "M043", DttUserName = "member043", DttFullName = "Lê Văn Tùng", DttEmail = "tung.lv043@example.com", DttPassword = "Pass@1043", DttPhone = "0901234043", DttBirthday = new DateTime(2001, 11, 17) },
    new DttMember { DttMemberId = "M044", DttUserName = "member044", DttFullName = "Phạm Thị Vinh", DttEmail = "vinh.pt044@example.com", DttPassword = "Pass@1044", DttPhone = "0901234044", DttBirthday = new DateTime(2002, 5, 30) },
    new DttMember { DttMemberId = "M045", DttUserName = "member045", DttFullName = "Hoàng Văn Xuân", DttEmail = "xuan.hv045@example.com", DttPassword = "Pass@1045", DttPhone = "0901234045", DttBirthday = new DateTime(1998, 9, 14) },
    new DttMember { DttMemberId = "M046", DttUserName = "member046", DttFullName = "Vũ Thị Ngọc", DttEmail = "ngoc.vt046@example.com", DttPassword = "Pass@1046", DttPhone = "0901234046", DttBirthday = new DateTime(2000, 2, 7) },
    new DttMember { DttMemberId = "M047", DttUserName = "member047", DttFullName = "Bùi Văn Thắng", DttEmail = "thang.bv047@example.com", DttPassword = "Pass@1047", DttPhone = "0901234047", DttBirthday = new DateTime(2001, 10, 21) },
    new DttMember { DttMemberId = "M048", DttUserName = "member048", DttFullName = "Đặng Thị Hạnh", DttEmail = "hanh.dt048@example.com", DttPassword = "Pass@1048", DttPhone = "0901234048", DttBirthday = new DateTime(1999, 4, 4) },
    new DttMember { DttMemberId = "M049", DttUserName = "member049", DttFullName = "Ngô Văn Toàn", DttEmail = "toan.nv049@example.com", DttPassword = "Pass@1049", DttPhone = "0901234049", DttBirthday = new DateTime(2002, 8, 29) },
    new DttMember { DttMemberId = "M050", DttUserName = "member050", DttFullName = "Dương Thị Dung", DttEmail = "dung.dt050@example.com", DttPassword = "Pass@1050", DttPhone = "0901234050", DttBirthday = new DateTime(2000, 12, 15) },
    new DttMember { DttMemberId = "M051", DttUserName = "member051", DttFullName = "Nguyễn Hữu Tài", DttEmail = "tai.nh051@example.com", DttPassword = "Pass@1051", DttPhone = "0901234051", DttBirthday = new DateTime(2001, 1, 10) },
    new DttMember { DttMemberId = "M052", DttUserName = "member052", DttFullName = "Trần Đình Trọng", DttEmail = "trong.td052@example.com", DttPassword = "Pass@1052", DttPhone = "0901234052", DttBirthday = new DateTime(1999, 5, 23) },
    new DttMember { DttMemberId = "M053", DttUserName = "member053", DttFullName = "Lê Gia Bảo", DttEmail = "bao.lg053@example.com", DttPassword = "Pass@1053", DttPhone = "0901234053", DttBirthday = new DateTime(2000, 9, 4) },
    new DttMember { DttMemberId = "M054", DttUserName = "member054", DttFullName = "Phạm Minh Tâm", DttEmail = "tam.pm054@example.com", DttPassword = "Pass@1054", DttPhone = "0901234054", DttBirthday = new DateTime(2002, 3, 19) },
    new DttMember { DttMemberId = "M055", DttUserName = "member055", DttFullName = "Hoàng Thanh Bình", DttEmail = "binh.ht055@example.com", DttPassword = "Pass@1055", DttPhone = "0901234055", DttBirthday = new DateTime(1998, 11, 28) },
    new DttMember { DttMemberId = "M056", DttUserName = "member056", DttFullName = "Vũ Xuân Trường", DttEmail = "truong.vx056@example.com", DttPassword = "Pass@1056", DttPhone = "0901234056", DttBirthday = new DateTime(2001, 7, 13) },
    new DttMember { DttMemberId = "M057", DttUserName = "member057", DttFullName = "Bùi Ngọc Ánh", DttEmail = "anh.bn057@example.com", DttPassword = "Pass@1057", DttPhone = "0901234057", DttBirthday = new DateTime(1999, 2, 16) },
    new DttMember { DttMemberId = "M058", DttUserName = "member058", DttFullName = "Đặng Quang Huy", DttEmail = "huy.dq058@example.com", DttPassword = "Pass@1058", DttPhone = "0901234058", DttBirthday = new DateTime(2002, 6, 8) },
    new DttMember { DttMemberId = "M059", DttUserName = "member059", DttFullName = "Ngô Thị Thu", DttEmail = "thu.nt059@example.com", DttPassword = "Pass@1059", DttPhone = "0901234059", DttBirthday = new DateTime(2000, 10, 22) },
    new DttMember { DttMemberId = "M060", DttUserName = "member060", DttFullName = "Dương Văn Quyết", DttEmail = "quyet.dv060@example.com", DttPassword = "Pass@1060", DttPhone = "0901234060", DttBirthday = new DateTime(2001, 4, 30) },
    new DttMember { DttMemberId = "M061", DttUserName = "member061", DttFullName = "Lý Văn Sáng", DttEmail = "sang.lv061@example.com", DttPassword = "Pass@1061", DttPhone = "0901234061", DttBirthday = new DateTime(2000, 8, 15) },
    new DttMember { DttMemberId = "M062", DttUserName = "member062", DttFullName = "Phan Thị Mỹ", DttEmail = "my.pt062@example.com", DttPassword = "Pass@1062", DttPhone = "0901234062", DttBirthday = new DateTime(1999, 12, 1) },
    new DttMember { DttMemberId = "M063", DttUserName = "member063", DttFullName = "Vương Văn Kiên", DttEmail = "kien.vv063@example.com", DttPassword = "Pass@1063", DttPhone = "0901234063", DttBirthday = new DateTime(2002, 1, 24) },
    new DttMember { DttMemberId = "M064", DttUserName = "member064", DttFullName = "Đinh Thị Hồng", DttEmail = "hong.dt064@example.com", DttPassword = "Pass@1064", DttPhone = "0901234064", DttBirthday = new DateTime(2001, 5, 9) },
    new DttMember { DttMemberId = "M065", DttUserName = "member065", DttFullName = "Tạ Văn Cường", DttEmail = "cuong.tv065@example.com", DttPassword = "Pass@1065", DttPhone = "0901234065", DttBirthday = new DateTime(1998, 10, 18) },
    new DttMember { DttMemberId = "M066", DttUserName = "member066", DttFullName = "Trịnh Thị Lệ", DttEmail = "le.tt066@example.com", DttPassword = "Pass@1066", DttPhone = "0901234066", DttBirthday = new DateTime(2000, 3, 27) },
    new DttMember { DttMemberId = "M067", DttUserName = "member067", DttFullName = "Mai Văn Phước", DttEmail = "phuoc.mv067@example.com", DttPassword = "Pass@1067", DttPhone = "0901234067", DttBirthday = new DateTime(1999, 7, 11) },
    new DttMember { DttMemberId = "M068", DttUserName = "member068", DttFullName = "Lương Thị Sương", DttEmail = "suong.lt068@example.com", DttPassword = "Pass@1068", DttPhone = "0901234068", DttBirthday = new DateTime(2002, 11, 2) },
    new DttMember { DttMemberId = "M069", DttUserName = "member069", DttFullName = "Cao Văn Thuận", DttEmail = "thuan.cv069@example.com", DttPassword = "Pass@1069", DttPhone = "0901234069", DttBirthday = new DateTime(2001, 2, 20) },
    new DttMember { DttMemberId = "M070", DttUserName = "member070", DttFullName = "Phùng Thị Hoa", DttEmail = "hoa.pt070@example.com", DttPassword = "Pass@1070", DttPhone = "0901234070", DttBirthday = new DateTime(2000, 6, 14) },
    new DttMember { DttMemberId = "M071", DttUserName = "member071", DttFullName = "Hà Văn Giang", DttEmail = "giang.hv071@example.com", DttPassword = "Pass@1071", DttPhone = "0901234071", DttBirthday = new DateTime(1999, 9, 29) },
    new DttMember { DttMemberId = "M072", DttUserName = "member072", DttFullName = "Kiều Thị Loan", DttEmail = "loan.kt072@example.com", DttPassword = "Pass@1072", DttPhone = "0901234072", DttBirthday = new DateTime(2002, 4, 7) },
    new DttMember { DttMemberId = "M073", DttUserName = "member073", DttFullName = "Mạc Văn Đạt", DttEmail = "dat.mv073@example.com", DttPassword = "Pass@1073", DttPhone = "0901234073", DttBirthday = new DateTime(2001, 12, 18) },
    new DttMember { DttMemberId = "M074", DttUserName = "member074", DttFullName = "Tăng Thị Hiền", DttEmail = "hien.tt074@example.com", DttPassword = "Pass@1074", DttPhone = "0901234074", DttBirthday = new DateTime(1998, 5, 25) },
    new DttMember { DttMemberId = "M075", DttUserName = "member075", DttFullName = "Giang Văn Khiêm", DttEmail = "khiem.gv075@example.com", DttPassword = "Pass@1075", DttPhone = "0901234075", DttBirthday = new DateTime(2000, 10, 3) },
    new DttMember { DttMemberId = "M076", DttUserName = "member076", DttFullName = "Thạch Thị Nga", DttEmail = "nga.tt076@example.com", DttPassword = "Pass@1076", DttPhone = "0901234076", DttBirthday = new DateTime(1999, 1, 12) },
    new DttMember { DttMemberId = "M077", DttUserName = "member077", DttFullName = "Bạch Văn Phúc", DttEmail = "phuc.bv077@example.com", DttPassword = "Pass@1077", DttPhone = "0901234077", DttBirthday = new DateTime(2002, 7, 21) },
    new DttMember { DttMemberId = "M078", DttUserName = "member078", DttFullName = "Vi Thị Hạnh", DttEmail = "hanh.vt078@example.com", DttPassword = "Pass@1078", DttPhone = "0901234078", DttBirthday = new DateTime(2001, 3, 6) },
    new DttMember { DttMemberId = "M079", DttUserName = "member079", DttFullName = "Nghiêm Văn Toản", DttEmail = "toan.nv079@example.com", DttPassword = "Pass@1079", DttPhone = "0901234079", DttBirthday = new DateTime(2000, 11, 19) },
    new DttMember { DttMemberId = "M080", DttUserName = "member080", DttFullName = "Thiều Thị Dung", DttEmail = "dung.tt080@example.com", DttPassword = "Pass@1080", DttPhone = "0901234080", DttBirthday = new DateTime(1999, 6, 28) },
    new DttMember { DttMemberId = "M081", DttUserName = "member081", DttFullName = "Sái Văn Đạo", DttEmail = "dao.sv081@example.com", DttPassword = "Pass@1081", DttPhone = "0901234081", DttBirthday = new DateTime(2002, 2, 11) },
    new DttMember { DttMemberId = "M082", DttUserName = "member082", DttFullName = "Âu Thị Bích", DttEmail = "bich.at082@example.com", DttPassword = "Pass@1082", DttPhone = "0901234082", DttBirthday = new DateTime(2001, 8, 5) },
    new DttMember { DttMemberId = "M083", DttUserName = "member083", DttFullName = "Viên Văn Thắng", DttEmail = "thang.vv083@example.com", DttPassword = "Pass@1083", DttPhone = "0901234083", DttBirthday = new DateTime(1998, 12, 17) },
    new DttMember { DttMemberId = "M084", DttUserName = "member084", DttFullName = "Sầm Thị Tuyết", DttEmail = "tuyet.st084@example.com", DttPassword = "Pass@1084", DttPhone = "0901234084", DttBirthday = new DateTime(2000, 4, 26) },
    new DttMember { DttMemberId = "M085", DttUserName = "member085", DttFullName = "Nông Văn Lộc", DttEmail = "loc.nv085@example.com", DttPassword = "Pass@1085", DttPhone = "0901234085", DttBirthday = new DateTime(1999, 10, 9) },
    new DttMember { DttMemberId = "M086", DttUserName = "member086", DttFullName = "Lò Thị Mai", DttEmail = "mai.lt086@example.com", DttPassword = "Pass@1086", DttPhone = "0901234086", DttBirthday = new DateTime(2002, 5, 22) },
    new DttMember { DttMemberId = "M087", DttUserName = "member087", DttFullName = "Cầm Văn Phong", DttEmail = "phong.cv087@example.com", DttPassword = "Pass@1087", DttPhone = "0901234087", DttBirthday = new DateTime(2001, 1, 31) },
    new DttMember { DttMemberId = "M088", DttUserName = "member088", DttFullName = "Quách Thị Oanh", DttEmail = "oanh.qt088@example.com", DttPassword = "Pass@1088", DttPhone = "0901234088", DttBirthday = new DateTime(2000, 7, 16) },
    new DttMember { DttMemberId = "M089", DttUserName = "member089", DttFullName = "Khuất Văn Quân", DttEmail = "quan.kv089@example.com", DttPassword = "Pass@1089", DttPhone = "0901234089", DttBirthday = new DateTime(1999, 3, 8) },
    new DttMember { DttMemberId = "M090", DttUserName = "member090", DttFullName = "Đậu Thị Quỳnh", DttEmail = "quynh.dt090@example.com", DttPassword = "Pass@1090", DttPhone = "0901234090", DttBirthday = new DateTime(2002, 9, 25) },
    new DttMember { DttMemberId = "M091", DttUserName = "member091", DttFullName = "Đồng Văn Kiên", DttEmail = "kien.dv091@example.com", DttPassword = "Pass@1091", DttPhone = "0901234091", DttBirthday = new DateTime(2001, 6, 12) },
    new DttMember { DttMemberId = "M092", DttUserName = "member092", DttFullName = "Phó Thị Thu", DttEmail = "thu.pt092@example.com", DttPassword = "Pass@1092", DttPhone = "0901234092", DttBirthday = new DateTime(1998, 11, 4) },
    new DttMember { DttMemberId = "M093", DttUserName = "member093", DttFullName = "Tôn Văn Hải", DttEmail = "hai.tv093@example.com", DttPassword = "Pass@1093", DttPhone = "0901234093", DttBirthday = new DateTime(2000, 2, 19) },
    new DttMember { DttMemberId = "M094", DttUserName = "member094", DttFullName = "Bế Thị Lan", DttEmail = "lan.bt094@example.com", DttPassword = "Pass@1094", DttPhone = "0901234094", DttBirthday = new DateTime(1999, 8, 30) },
    new DttMember { DttMemberId = "M095", DttUserName = "member095", DttFullName = "Giáp Văn Nam", DttEmail = "nam.gv095@example.com", DttPassword = "Pass@1095", DttPhone = "0901234095", DttBirthday = new DateTime(2002, 12, 11) },
    new DttMember { DttMemberId = "M096", DttUserName = "member096", DttFullName = "Mã Thị Phương", DttEmail = "phuong.mt096@example.com", DttPassword = "Pass@1096", DttPhone = "0901234096", DttBirthday = new DateTime(2001, 5, 17) },
    new DttMember { DttMemberId = "M097", DttUserName = "member097", DttFullName = "Ninh Văn Tuấn", DttEmail = "tuan.nv097@example.com", DttPassword = "Pass@1097", DttPhone = "0901234097", DttBirthday = new DateTime(2000, 9, 2) },
    new DttMember { DttMemberId = "M098", DttUserName = "member098", DttFullName = "Thang Thị Ngọc", DttEmail = "ngoc.tt098@example.com", DttPassword = "Pass@1098", DttPhone = "0901234098", DttBirthday = new DateTime(1999, 1, 26) },
    new DttMember { DttMemberId = "M099", DttUserName = "member099", DttFullName = "Ưng Văn Hùng", DttEmail = "hung.uv099@example.com", DttPassword = "Pass@1099", DttPhone = "0901234099", DttBirthday = new DateTime(2002, 6, 21) },
    new DttMember { DttMemberId = "M100", DttUserName = "member100", DttFullName = "Đàm Thị Linh", DttEmail = "linh.dt100@example.com", DttPassword = "Pass@1100", DttPhone = "0901234100", DttBirthday = new DateTime(2001, 10, 15) }
    };
        public IActionResult Index()
        {
            return View(_dttmembers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DttMember dttmember)
        {

            string msg = null;
            bool validate = true;
            if (dttmember.DttUserName.Length <3 || dttmember.DttUserName.Length>20)
            {
                msg = "<li>Tên đăng nhập phải có độ dài từ 3-20 ký tự </li>";
                validate = false;
            }
            string patternemail = @"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
            if(!Regex.IsMatch(dttmember.DttEmail, patternemail))
            {
                msg += "<li>Email không đúng định dạng</li>";
                validate = false;
            }
            if(dttmember.DttBirthday.AddYears(18) > DateTime.Now)
            {
                msg += "<li>Bạn chưa đủ 18 tuổi</li>";
                validate = false;
            }
            string patternphone = @"^0\d{9,12}$";
            if(!Regex.IsMatch(dttmember.DttPhone, patternphone))
            {
                msg += "<li>Số điện thoại không đúng định dạng</li>";
                validate = false;
            }

            if (validate)
            {
                dttmember.DttMemberId = "M" + (_dttmembers.Count + 1).ToString("D3");
                _dttmembers.Add(dttmember);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.msg = "<div class='alert alert-danger'>" + msg + "</div>";
                return View(dttmember);
            }
        }
    }
}
