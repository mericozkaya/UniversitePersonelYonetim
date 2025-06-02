using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelYonetim
{
    // Teknik personel sınıfı, idari personelden türetiliyor
    public class TeknikPersonel : IdariPersonel
    {
        private decimal sabitMaas = 96000;

        public override decimal MaasHesapla()
        {
            return sabitMaas;
        }

        public override void ZamYap()
        {
            // Haziran zammı: %30 sabit maaş
            sabitMaas *= 1.30m;
        }

        public override string ToString()
        {
            return $"Teknik Personel {Ad} {Soyad}";
        }
    }
}

