using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbFirst
{

    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }
    class Program
    {
        static void Main(string[] args)
        {

            var dbContext = new PlutoDbContext();
            var courses = dbContext.Courses;

            foreach (var course in courses)
            {
                Console.WriteLine(course.Title + ',' + course.Level);
            }

            Console.ReadKey();
        }
    }
}
