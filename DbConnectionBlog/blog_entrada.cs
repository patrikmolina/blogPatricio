namespace DbConnectionBlog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class blog_entrada
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string titulo { get; set; }

        [Required]
        [StringLength(255)]
        public string contenido { get; set; }

        [Required]
        [StringLength(255)]
        public string imagen { get; set; }

        [Required]
        [StringLength(255)]
        public string categoria { get; set; }

        //public DateTime fecha_creacion { get; set; }
    }
}
