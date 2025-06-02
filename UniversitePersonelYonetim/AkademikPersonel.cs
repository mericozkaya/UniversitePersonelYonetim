using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelYonetim
{
    // Akademik personeller burdan türeyecek
    public abstract class AkademikPersonel : Personel, IZamYap
    {
        public int DersSaati { get; set; }

        // Zam yapma işlemi her akademik türde farklı olacak
        public abstract void ZamYap();
    }

}
