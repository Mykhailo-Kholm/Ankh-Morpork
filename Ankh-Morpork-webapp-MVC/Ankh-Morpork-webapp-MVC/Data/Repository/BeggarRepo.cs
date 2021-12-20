using Ankh_Morpork_game.Abstract;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using System.Collections.Generic;

namespace Ankh_Morpork_webapp_MVC.Data.Repository
{
    public class BeggarRepo:INpcRepo
    {
        private readonly SingletonDbContext _context;
        public BeggarRepo(SingletonDbContext context) =>_context = context;
        public IEnumerable<INPC> GetNpcForGuild() => _context.Beggars;
    }
}