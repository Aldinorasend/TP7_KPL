using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_KELOMPOK_4
{
    internal class KuliahMahasiswa_1302220108
    {
        public void ReadJson()
        {
            string jsonData = File.ReadAllText(@"D:\Telkom University\Semester 4\Konstruksi Perangkat Lunak\Minggu 7\TPMODUL7_KELOMPOK_4\tp7_2_1302220108.json");
            CourseList kuliah = JsonConvert.DeserializeObject<CourseList>(jsonData);

            foreach (var course in kuliah.courses)
            {
                Console.WriteLine($"Code: {course.code}, Name: {course.name}");
            }
        }
    }

    public class CourseList
    {
        public List<Courses> courses { get; set; }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}