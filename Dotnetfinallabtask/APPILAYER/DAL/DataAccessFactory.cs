using DAL.Interfaces;
using DAL.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Member, int, bool> MemberData()
        {
            return new MemberRepo();
        }

        public static IRepo<Project, int, bool> ProjectData()
        {
            return new ProjectRepo();
        }
    }
}
