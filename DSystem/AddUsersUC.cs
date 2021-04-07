using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSystem
{
    class AddUsersUC
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static string error = "Username does not exist!";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(AddUsersUC user1, AddUsersUC user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.UserName != user2.UserName)
            {
                error = "Username does not exist!";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "Username and password does not match!";
                return false;
            }

            return true;
        }
    }
}
