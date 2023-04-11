using DAL.Interfaces;
using DAL.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProjectRepo : Repo, IRepo<Project, int, bool>
    {
        
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> Get()
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Project obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Project obj)
        {
            throw new NotImplementedException();
        }
    }
}
