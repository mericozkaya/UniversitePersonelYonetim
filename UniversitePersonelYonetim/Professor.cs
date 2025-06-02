using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelYonetim
{
    // Profesör sınıfı, akademik personelden türetiliyor
    public class Professor : AkademikPersonel
    {
        private decimal sabitMaas = 200000;
        private decimal dersSaatUcreti = 3000;

        public override decimal MaasHesapla()
        {
            return sabitMaas + (DersSaati * dersSaatUcreti);
        }

        public override void ZamYap()
        {
            // Haziran zammı: %20 sabit maaş + %50 ders saati ücreti
            sabitMaas *= 1.20m;
            dersSaatUcreti *= 1.50m;
        }

        public override string ToString()
        {
            return $"Prof. Dr. {Ad} {Soyad}";
        }
    }
}

