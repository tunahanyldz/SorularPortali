using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sorular.ViewModel
{
    public class YorumModel
    {
        public int YorumId { get; set; }
        public string YorumIcerik { get; set; }
        public int UyeId { get; set; }
        public int SoruId { get; set; }
        public string KullaniciAdi { get; set; }
        public string SoruBaslik { get; set; }
        public DateTime Tarih { get; set; }
    }
}