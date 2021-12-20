using System.Collections.Generic;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_webapp_MVC.Data.IRepository;

namespace Ankh_Morpork_webapp_MVC.Data.Repository
{
    public class AssassinRepo:INpcRepo
    {
        private readonly SingletonDbContext _context;
        public AssassinRepo(SingletonDbContext context) => _context = context;
        public IEnumerable<INPC> GetNpcForGuild() => _context.Assassins;
    }
}