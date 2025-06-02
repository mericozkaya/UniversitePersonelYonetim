using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelYonetim
{
    // İdari personeller bu sınıftan türeyecek
    public abstract class IdariPersonel : Personel, IZamYap
    {
        // Zam işlemi idari türdeki herkeste farklı uygulanabilir
        public abstract void ZamYap();
    }
}

