using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace data
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Display(Name = "Thể loại")]
        [Required]
        [StringLength(100)]
        public string GenreName { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
        public Genre() { this.SanPhams = new HashSet<SanPham>(); }
    }
}