using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL7_KELOMPOK_4
{
    internal class KuliahMahasiswa_1302223045
    {
        public void ReadJson()
        {
            string jsonData = File.ReadAllText(@"C:\Users\xaver\source\repos\TPMODUL7_KELOMPOK_4\tp7_2_1302223138.json");
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