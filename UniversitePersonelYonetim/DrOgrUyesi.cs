using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelYonetim
{
    // Dr. Öğretim Üyesi sınıfı, akademik personelden türetiliyor
    public class DrOgrUyesi : AkademikPersonel
    {
        private decimal sabitMaas = 130000;
        private decimal dersSaatUcreti = 1000;

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
            return $"Dr. Öğr. Üyesi {Ad} {Soyad}";
        }
    }
}

