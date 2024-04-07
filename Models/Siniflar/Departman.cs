﻿using CRMTicariOtomasyon.Models.Siniflar;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMTicariOtomasyon.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int Departmanid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmanAd { get; set; }

        public ICollection<Personel> Personels { get; set; }

    }
}
