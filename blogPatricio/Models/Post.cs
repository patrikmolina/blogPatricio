﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blogPatricio
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Imagen { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}