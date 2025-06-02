using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelYonetim
{
    // Memur sınıfı, idari personelden türetiliyor
    public class Memur : IdariPersonel
    {
        private decimal sabitMaas = 90000;

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
            return $"Memur {Ad} {Soyad}";
        }
    }
}

