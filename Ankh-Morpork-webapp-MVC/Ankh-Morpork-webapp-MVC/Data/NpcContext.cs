﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Ankh_Morpork_webapp_MVC.Data.Resources;

namespace Ankh_Morpork_webapp_MVC.Models
{
    public class NpcContext:DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public DbSet<Beggar> Beggars { get; set; }
        public DbSet<Fool> Fools { get; set; }
        public DbSet<Thief> Thieves { get; set; }
        public NpcContext():base("name=DbNpcConnection")
        {
        }
    }
}