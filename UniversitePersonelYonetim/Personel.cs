using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelYonetim
{
        // Tüm personellerin ortak özellikleri burda olacak
        public abstract class Personel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }

            // herkesin maaşı var ama nasıl hesaplanacağı farklı
            public abstract decimal MaasHesapla();

            public override string ToString()
            {
                return $"{Ad} {Soyad}";
            }
        }

}
