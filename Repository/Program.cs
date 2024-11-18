using Repository.Models;
using Repository.Repositories.Abstracts;
using Repository.Repositories.Implements;

namespace Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentRepository();
            repo.Create(new STUDENTS
            {
                Name = "Izafa",
                Surname = "Tagiyeva",
                Code = "0014",
                Age = 19

            }
            );
        }
    }
}
