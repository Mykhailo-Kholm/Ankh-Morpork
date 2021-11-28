﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ankh_Morpork_game.Models;

namespace Ankh_Morpork_game.Abstract
{
    public interface INPC
    {
        protected Guid Id { get; set; }
        string Name { get; set; }
        string Speech { get; set; }
    }
}