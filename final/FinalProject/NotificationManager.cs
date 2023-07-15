using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    class NotificationManager
    {
        private List<User> users;

        public NotificationManager()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public void SendNotification(string message)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"Sending notification to user: {user.UserName}");
                Console.WriteLine($"Message: {message}");
                Console.WriteLine();
            }
        }
    }
}
