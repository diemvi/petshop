using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data
{
    public class ChiTietHoaDon
    {

        public int ID { get; set; }
        public int MaHoaDon { get; set; }
        public virtual HoaDon MaHD { get; set; }
        [Required]
        [Display(Name = "Sản Phẩm")]
        public int MaSP { get; set; }
        public virtual SanPham IDsp { get; set; }
        public int SoLuong { get; set; }
    }
}