using ProjetoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//ProjetoWeb1.Models.Model1;

namespace ProjetoWeb1.Services
{
    public class UserService
    {
        public void AddUsers(Users usuario)
        {
            ProjetoContext dbContext = new ProjetoContext();
            dbContext.Users.Add(usuario);
            dbContext.SaveChanges();
            
        }
        public bool ValidateLogin(Users usuario)
        {
            using (var dbContext = new ProjetoContext())
            {
                var IsValidate = dbContext.Users.Where(x => x.Nome == usuario.Nome && x.senha == usuario.senha).Any();

                if (IsValidate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool DeleteUsersService(Users usuario)
        {
            ProjetoContext dbContext = new ProjetoContext();
            var isValidateUser = dbContext.Users.Where(x => x.Id == usuario.Id).Any();

            if (isValidateUser)
            {
                var user = dbContext.Users.Where(x => x.Id == usuario.Id).FirstOrDefault(); 
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
                return true;
            }
               else
            {
                return false;
            }
           
        }

    }
}