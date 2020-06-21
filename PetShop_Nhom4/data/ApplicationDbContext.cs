using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace data
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public IDbSet<SanPham> SanPhams { get; set; }
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<HoaDon> HoaDon { get; set; }
        public IDbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}
