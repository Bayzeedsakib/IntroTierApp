using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService
    {
        DepartmentRepo DepartmentRepo;
        public DepartmentService(DepartmentRepo repo)
        {
            this.DepartmentRepo = repo;
        }

        public List<Department> Get()
        {
            return DepartmentRepo.Get();

            //return new object();
        }

        public Object Get(int id)
        {
            DepartmentRepo.Get(id);

            return new object();
        }

        public Object Create()
        {
            DepartmentRepo.Create();

            return new object();
        }

        public bool Delete()
        {
            return false;
        }
    }
}
