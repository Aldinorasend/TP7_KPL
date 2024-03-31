using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_KELOMPOK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa dataMahasiswa = new DataMahasiswa();
            dataMahasiswa.ReadJSON();

            KuliahMahasiswa_1302223146 kuliahMahasiswa = new KuliahMahasiswa_1302223146();
=======
            Console.ReadLine();

            KuliahMahasiswa_1302223071 kuliahMahasiswa = new KuliahMahasiswa_1302223071();
>>>>>>> 5e1b6f2442f5a66c0a34d2374d99ab50127e8aee
            kuliahMahasiswa.ReadJson();

            Console.ReadLine();
        }
    }
    }
}