﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ankh_Morpork_webapp_MVC.Data.IRepository;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Data.Repository
{
    public class ThiefRepo:INpcRepo<Thief>
    {
        private readonly SingletonDbContext _context;
        public ThiefRepo(SingletonDbContext context) => _context = context;
        public IEnumerable<Thief> GetNpcForGuild() => _context.Thieves;
    }
}