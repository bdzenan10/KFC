using KFC.Modals;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace KFC.Data
{
    public class TokenDatabaseController
    {
        static Object locker = new Object();
        SQLiteConnection database;

        public TokenDatabaseController()
        {

            database = DependencyService.Get<SQLlite>().GetConnection();
            database.CreateTable<Token>();
        }

        public Token GetToken()
        {

            if (database.Table<Token>().Count() == 0)
            {
                return null;
            }
            else
            {
                return database.Table<Token>().First();
            }
        }

        public int SaveToken(Token token)
        {
            lock (locker)
            {

                if (token.Id != 0)
                {
                    database.Update(token);
                    return token.Id;
                }
                else
                {
                    return database.Insert(token);
                }
            }
        }

        public int DeleteToken(int id)
        {
            lock (locker)
            {
                return database.Delete<Token>(id);
            }
        }
    }
}

