﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApplication.Models
{
    public class MainViewModel
    {
        public List<Cinema> Cinemas { get; set; }
        public List<Movy>Movies { get; set; }
    }
}