﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTelefonSatısOtomasyon.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int Urunİd { get; set; }
        public string UrunAd {  get; set; }
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat {  get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum {  get; set; }
        public string UrunGorsel {  get; set; }
    }
}