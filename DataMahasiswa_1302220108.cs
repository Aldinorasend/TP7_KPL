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
            string jsonData = File.ReadAllText(@"D:\Telkom University\Semester 4\Konstruksi Perangkat Lunak\Minggu 7\TPMODUL7_KELOMPOK_4\tp7_1_1302220108.json");
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