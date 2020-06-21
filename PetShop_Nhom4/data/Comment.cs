
using System;
using System.ComponentModel.DataAnnotations;

namespace data
{
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now;          
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Đánh giá")]
        [RegularExpression("^[0-9]*$")]
        [Range(1, 5)]
        public string Rating { get; set; }
        [Required] public string Text { get; set; }
        [Required] public DateTime Date { get; set; }
        [Required]
        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
        [Required]
        public int MaSP { get; set; }

        public virtual SanPham IDSP { get; set; }

    }
}