using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Compare.Dnn.DNNModule_new.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string TermekNeve { get; set; }
        public string Sku { get; set; }
        public string Ar { get; set; }
        public string MaximalisVideofelbontas { get; set; }
        public string MaximalisKepkockasebesseg { get; set; }
        public string TervezettLefedettseg { get; set; }
        public string LatoszogFokban { get; set; }
        public string GpsPozicioNaplozas { get; set; }
        public string Hangfelvetel { get; set; }
        public string Nyelvek { get; set; }
        public string NappaliEszakaiMod { get; set; }
        public string VideoreszletKivalasztasa { get; set; }
        public string Tanusitvany { get; set; }
        public string MemoriakartiyaTipusa { get; set; }
        public string ObjektivekSzama { get; set; }
        public string MukodesHomerseklet { get; set; }
        public string Garancia { get; set; }
    }
}