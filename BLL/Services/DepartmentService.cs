using AutoMapper;
using BLL.DTOs;
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
        DepartmentRepo repo;
        Mapper mapper;
        public DepartmentService(DepartmentRepo repo)
        {
            this.repo = repo;
            mapper = MapperConfig.GetMapper();
        }

        public List<DepartmentDTO> GetById()
        {
            var data = repo.Get();

            var res = mapper.Map<List<DepartmentDTO>>(data);
            return res;
        }

        public DepartmentDTO GetById(int id)
        {
            var data = repo.GetById(id);

            return mapper.Map<DepartmentDTO>(data);
        }

        

    }
}
