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

        public Department GetById(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Create(Department d)
        {
            db.Departments.Add(d);

            return db.SaveChanges() > 0;
        }

        public bool Update(Department d)
        {
            var exobj = GetById(d.Id);
            db.Entry(exobj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;
        }
    }
}
