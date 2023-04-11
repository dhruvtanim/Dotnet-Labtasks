using BLL.DTOs;
using DAL;
using DAL.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectServices
    {
        public static List<ProjectDTO> Get()
        {
            var data = DataAccessFactory.ProjectData().Get();
            return Convert(data.ToList());
        }
        public static ProjectDTO Get(int id)
        {
            var data = DataAccessFactory.ProjectData().Get(id);
            return Convert(data);
        }
        public static bool Create(ProjectDTO employee)
        {
            var data = Convert(employee);
            return DataAccessFactory.ProjectData().Insert(data);
        }
        public static bool Update(ProjectDTO employee)
        {
            var data = Convert(employee);
            return DataAccessFactory.ProjectData().Update(data);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ProjectData().Delete(id);
        }

        //Convertion Methods
        static  ProjectDTO Convert(Project employee)
        {
            return new ProjectDTO()
            {
                Id = employee.Id,
             
            };
        }

        static Project Convert(ProjectDTO employee)
        {
            return new Project()
            {
                Id = employee.Id,
               
            };
        }

        static List<ProjectDTO> Convert(List<Project> projects)
        {
            var data = new List<ProjectDTO>();
            foreach (var project in projects)
            {
                data.Add(Convert(project));
            }
            return data;
        }
    }
}
