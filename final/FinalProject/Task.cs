using System;

namespace TaskManagementSystem
{
    class Task
    {
        public string TaskID { get; private set; }
        public string TaskName { get; private set; }
        public string Description { get; private set; }
        public DateTime Deadline { get; private set; }
        public int Priority { get; private set; }
        public string Status { get; private set; }

        public Task(string taskID, string taskName, string description, DateTime deadline, int priority, string status)
        {
            TaskID = taskID;
            TaskName = taskName;
            Description = description;
            Deadline = deadline;
            Priority = priority;
            Status = status;
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }

        public string GetTaskInfo()
        {
            string taskInfo = $"Task ID: {TaskID}\n" +
                              $"Task Name: {TaskName}\n" +
                              $"Description: {Description}\n" +
                              $"Deadline: {Deadline}\n" +
                              $"Priority: {Priority}\n" +
                              $"Status: {Status}\n";

            return taskInfo;
        }

        internal void UpdatePriority(int newPriority)
        {
            throw new NotImplementedException();
        }

        internal void UpdateDeadline(DateTime newDeadline)
        {
            throw new NotImplementedException();
        }
    }
}
