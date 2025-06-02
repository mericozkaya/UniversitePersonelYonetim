using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelYonetim
{
    // Araştırma görevlisi sınıfı, akademik personelden türetiliyor
    public class ArasGor : AkademikPersonel
    {
        private decimal sabitMaas = 100000;

        public override decimal MaasHesapla()
        {
            // Araş. gör. sadece sabit maaş alır
            return sabitMaas;
        }

        public override void ZamYap()
        {
            // Sadece sabit maaş üzerinden %20 zam yapılır
            sabitMaas *= 1.20m;
        }

        public override string ToString()
        {
            return $"Arş. Gör. {Ad} {Soyad}";
        }
    }
}

