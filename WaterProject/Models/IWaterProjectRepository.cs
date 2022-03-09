using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface IWaterProjectRepository
    {
        IQueryable<Project> Projects { get; }

        public void SaveProject(Project p);
        public void CreateProject(Project p);
        public void DeleteProject(Project p);
    }
}
