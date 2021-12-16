using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Data.Repository
{
    public class AssassinRepo:INpcRepo<Assassin>
    {
        private readonly SingletonDbContext _context;
        public AssassinRepo(SingletonDbContext context) => _context = context;
        public IEnumerable<Assassin> GetNpcForGuild() => _context.Assassins;
    }
}