using Login_Form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Login_Form.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult Check(UserModel model)
        {
            if (model.Username == null || model.Password == null)
            {
                return RedirectToAction("Index");
            }
            var user = GetUsers().Where(u => u.Username.Equals(model.Username))
                                 .Where(u => u.Password.Equals(model.Password))
                                 .FirstOrDefault();
            if (user != null)
            {
                model = user;
                model.IsLogged = true;
            }
            return View(model);
        }
        public List<UserModel> GetUsers()
        {
            return new List<UserModel>
            {
                new UserModel() { Username="Vladik", Password="007", IsAdmin=false },
                new UserModel() { Username="Admin", Password="228", IsAdmin=true }
            };
        }
    }
}
