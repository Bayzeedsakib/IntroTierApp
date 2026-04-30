using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DepartmentRepo
    {
        StudentMsBsp26Context db;
        public DepartmentRepo(StudentMsBsp26Context db)
        {
            this.db = db;
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public Object Get(int id)
        {
            return new object();
        }

        public Object Create()
        {
            return new object();
        }
    }
}
