﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto0404.Models
{
    public class Home
    {
        public IQueryable<Fabricante> fabricante;
        public IQueryable<Categorico> categorico;
    }
}