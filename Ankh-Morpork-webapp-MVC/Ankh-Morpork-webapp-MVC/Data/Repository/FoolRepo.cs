using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Data.Repository
{
    public class FoolRepo:INpcRepo
    {
        private readonly SingletonDbContext _context;
        public FoolRepo(SingletonDbContext context) => _context = context;
        public IEnumerable<INPC> GetNpcForGuild() => _context.Fools;
    }
}