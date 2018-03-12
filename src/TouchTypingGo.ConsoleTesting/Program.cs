using System;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course("AS45A", "Curso Teste", DateTime.MaxValue, Guid.NewGuid());

            Console.WriteLine(course.ToString());

            Console.WriteLine(course.IsValid());

            if (!course.ValidationResult.IsValid)
            {
                foreach (var error in course.ValidationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}
