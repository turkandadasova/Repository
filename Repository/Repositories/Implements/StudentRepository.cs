using Repository.Helpers;
using Repository.Models;
using Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Implements
{
    class StudentRepository : IStudentRepository
    {
        public bool Create(STUDENTS data)
        {
            return SqlHelper.Exec($"INSERT INTO STUDENTS VALUES (N'{data.Name}',N'{data.Surname}','{data.Code}','{data.Age}'");

        }

        bool IStudentRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<STUDENTS> GetAll()
        {
            List<STUDENTS> list = new();
            var dt = SqlHelper.Read("SELECT * FROM STUDENTS");
            foreach(DataRow item in dt.Rows)
            {
                list.Add(new STUDENTS
                {
                    Id = Convert.ToInt32(item[0]),
                    Name = item[1].ToString(),
                    Surname = item[2].ToString(),
                    Code = item[5].ToString(),
                    Age = Convert.ToInt32(item[3]),
                });
            }
            return list;
        }

        public STUDENTS? GetById(int id )
        {
            var dt = SqlHelper.Read("SELECT * FROM STUDENTS WHERE Id = " + id);
            if (dt.Rows.Count>0)
            {
                return new STUDENTS
                {
                    Id = Convert.ToInt32(dt.Rows[0]),
                    Name = dt.Rows[1].ToString(),
                    Surname = dt.Rows[2].ToString(),
                    Code = dt.Rows[5].ToString(),
                    Age = Convert.ToInt32(dt.Rows[3]),
                };
            }
            return null;    
        }

        bool IStudentRepository.Update(int id, STUDENTS data)
        {
            throw new NotImplementedException();
        }
    }
}
