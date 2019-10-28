using ejHome.SpecFlow.Support.BaseStep;
using ejHome.SpecFlow.Support.SpoPattern;
using System;
using System.Collections.Generic;

namespace ejHome.SpecFlow.Support.Model
{
    public class Users
    {
        internal string username { get; set; }
        internal string password { get; set; }

        public Users(string _username, string _password)
        {
            username = _username;
            password = _password;
        }

        public static Users easyjetUser()
        {
            Random random = new Random();
            List<Users> ejUser = new List<Users>
            {
                new Users("User1@test.com", "P@ssword1!"),
                new Users("User2@test.com", "P@ssword1!"),
                new Users("User3@test.com", "P@ssword1!"),
                new Users("User4@test.com", "P@ssword1!"),
                new Users("User5@test.com", "P@ssword1!")
            };
            int index = random.Next(ejUser.Count);
            return ejUser[index];
        }

        public static void loginUserSuccessfully(string username, string password)
        {
            Act.browserInstance.Manage().Cookies.DeleteAllCookies();
            SpoLogin.Username.value = username;
            SpoLogin.Password.value = password;
            SpoLogin.SignIn.Click();
        }
        public static void loginUserSuccessfully(Users user)
        {
            loginUserSuccessfully(user.username, user.password);
        }
    }
}
