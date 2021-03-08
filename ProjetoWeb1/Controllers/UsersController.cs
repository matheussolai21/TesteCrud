using ProjetoWeb1.Models;
using ProjetoWeb1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace ProjetoWeb1.Controllers
{
    public class UsersController : Controller
    {
       public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();

        }

        public ActionResult DeleteUsers()
        {
            return View();
        }
      [HttpPost]
        public ActionResult Create(Users usuario)
        {
            var service = new UserService(); 
            
            service.AddUsers(usuario);
            return View("Login");

        }
        [HttpPost]
        public ActionResult Login(Users usuario)
        {
            var service = new UserService();
            var validate = service.ValidateLogin(usuario);
            

            if (validate)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login","Users");
            }
           
        }
        [HttpPost]
        public ActionResult DeleteUsers(Users usuario)
        {
            var service = new UserService();
            
            service.DeleteUsersService(usuario);
            return View("DeleteUsers");
        }
    }
}