using Newtonsoft.Json;
using System;
using System.IO;

namespace TPMODUL7_KELOMPOK_4
{
    internal class DataMahasiswa
    {
        public void ReadJSON()
        {
            string jsonData = File.ReadAllText(@"D:\Ai\TPMODUL7_KELOMPOK_4\TPMODUL7_KELOMPOK_4\tp7_1_1302223071.json");
            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonData);

            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
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
}
