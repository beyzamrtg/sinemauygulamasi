using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_rezervasyon
{
    public class rezervasyon:musteri
    {
        
        public string MusteriAdsoyad { get; set; }
        public int BiletAdeti { get; set; }
        public int KoltukNo { get; set; }
        public Seans seans { get; set; }
        
    }
}
