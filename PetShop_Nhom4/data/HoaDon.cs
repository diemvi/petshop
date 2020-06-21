using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace data
{
    public class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new List<ChiTietHoaDon>();
        }
        [Key]
        public int MaHoaDon { get; set; }
        public IList<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public double TongTien { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayLap { get; set; }
        [Required]
        public string MaKH { get; set; }
        public virtual ApplicationUser ID_KH { get; set; }

    }
}
