using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    class Project
    {
        public string ProjectID { get; private set; }
        public string ProjectName { get; private set; }
        public List<Task> Tasks { get; private set; }

        public Project(string projectID, string projectName)
        {
            ProjectID = projectID;
            ProjectName = projectName;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }

        public string GetProjectInfo()
        {
            string projectInfo = $"Project ID: {ProjectID}\n" +
                                 $"Project Name: {ProjectName}\n" +
                                 $"Number of Tasks: {Tasks.Count}\n";

            return projectInfo;
        }
    }
}
