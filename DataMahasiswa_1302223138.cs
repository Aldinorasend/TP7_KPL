using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_KELOMPOK_4
{
    internal class DataMahasiswa
    {
        public void ReadJSON()
        {
            string jsonData = File.ReadAllText(@" C:\Users\xaver\source\repos\TPMODUL7_KELOMPOK_4\tp7_1_1302223138.json");
            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonData);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }


    }
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
}