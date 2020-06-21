using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace data
{
    public class SanPham
    {
        public class GenreAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                int genreID = int.Parse(value.ToString());
                var db = new ApplicationDbContext();
                if (db.Genres.Any(x => x.GenreID == genreID))
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult(ErrorMessage ?? "Genre khong ton tai");
            }
        }
        [Key]
        public int MaSP { get; set; }
        [Display(Name = "Tên sản phẩm")]

        [StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }


        [ForeignKey("GenresObj")]
        [Display(Name = "Loại sản phẩm")]
        [Genre]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public int GenreID { get; set; }

        public virtual Genre GenresObj { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Giá tiền")]
        [Range(5000, double.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:0}đ")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Số Lượng")]
        public int SoLuong { get; set; }
        public byte[] Picture { get; set; }

        [NotMapped]
        [Display(Name = "Hình ảnh")]
        public HttpPostedFileBase PictureUpload { get; set; }

        [Display(Name = "Review")]
        [StringLength(int.MaxValue, MinimumLength = 10)]
        public string Sumary { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }

        public ICollection<Comment> Comment { get; set; }
        public SanPham()
        {
            this.Date = DateTime.Now;
            this.ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
            this.Comment = new HashSet<Comment>();
        }
}
}
