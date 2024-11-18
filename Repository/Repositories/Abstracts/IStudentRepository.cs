using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Abstracts
{
     interface IStudentRepository
    {
        List<STUDENTS> GetAll();
        STUDENTS? GetById(int id);
        bool Create(STUDENTS data);
        bool Delete(int id);
        bool Update(int id,STUDENTS data);

    }
}
