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
        DepartmentRepo repo;
        public DepartmentService(DepartmentRepo repo)
        {
            this.repo = repo;
        }

        public Object Get()
        {
            repo.Get();

            return new object();
        }

        public Object Get(int id)
        {
            repo.Get(id);

            return new object();
        }

        public Object Create()
        {
            repo.Create();

            return new object();
        }

        public bool Delete()
        {
            return false;
        }
    }
}
