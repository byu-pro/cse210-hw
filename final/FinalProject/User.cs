using System;

namespace TaskManagementSystem
{
    class User
    {
        public string UserID { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }

        public User(string userID, string userName, string email)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
        }

        public void UpdateEmail(string newEmail)
        {
            Email = newEmail;
        }

        public string GetUserInfo()
        {
            string userInfo = $"User ID: {UserID}\n" +
                              $"User Name: {UserName}\n" +
                              $"Email: {Email}\n";

            return userInfo;
        }
    }
}
