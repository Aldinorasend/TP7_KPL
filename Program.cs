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

            KuliahMahasiswa_1302223045 kuliahMahasiswa = new KuliahMahasiswa_1302223045();
            kuliahMahasiswa.ReadJson();

            Console.ReadLine();
        }
    }
}