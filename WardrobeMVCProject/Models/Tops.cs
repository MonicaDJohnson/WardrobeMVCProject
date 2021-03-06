﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeMVCProject.Models
{
    [MetadataType(typeof(Topsmetedata))]
    public partial class Tops
    {

    }

    public class Topsmetedata
    {
        public int TopsID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        public string Photo { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    }
}