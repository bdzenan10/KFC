using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Modals
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int iId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        
        public float potroseno;

        public User() { }
        public static IList<Order> orders { get; set; }
        public static IList<int> bonus { get; set; }
        public User(string Username, string Password)
        {
            
            this.Username = Username;
            this.Password = Password;
            
            orders = new List<Order>();
            bonus = new List<int>();
            this.potroseno = 0;
        }

        public bool Check()
        {
            try
            {
                if (!this.Username.Equals("") && !this.Password.Equals(""))
                {
                    return true;
                }
                else
                {


                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
