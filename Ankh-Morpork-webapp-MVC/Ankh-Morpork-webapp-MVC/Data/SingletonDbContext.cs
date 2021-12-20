using Ankh_Morpork_webapp_MVC.Models;
using System.Data.Entity;

namespace Ankh_Morpork_webapp_MVC.Data
{
    public class SingletonDbContext:DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public DbSet<Beggar> Beggars { get; set; }
        public DbSet<Fool> Fools { get; set; }
        public DbSet<Thief> Thieves { get; set; }

        private static SingletonDbContext _context;

        private SingletonDbContext() : base("name=DbNpcConnection")
        {
        }
        public static SingletonDbContext GetInstance()
        {
            if (_context == null)
                _context = new SingletonDbContext();
            return _context;
        }
    }
}