using Microsoft.AspNetCore.Mvc;
using QuizManagerPractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizManagerPractice.Controllers
{
    public class UserLogin : Controller
    {        
        [HttpPost]
        public ActionResult Login(UserLogin userName)
        {
            // To acces data using LINQ
            //MvcQuizContext quizContext = new MvcQuizContext();
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        var q = quizContext.tblUsers.Where(m => m.UserName == user.UserName && m.Password == user.Password).ToList();
            //        if (q.Count > 0)
            //        {
            //            return RedirectToAction("MyAccount");
            //        }
            //        else
            //        {
            //            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}
            return View();
        }
    }
}
