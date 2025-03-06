using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetQuestions()
        {
            var questions = new List<Question>
            {
                new Question { Id = 1, QuestionText = "What is a scoped service?", Answer = "A service that can be used per request." },
                new Question { Id = 2, QuestionText = "What does MVC stand for?", Answer = "Model View Controller" }
                new Question { Id = 3, QuestionText = "What is dependency injection?", Answer = "A technique for achieving Inversion of Control.", Hint = "It helps manage object lifetimes and dependencies." },
                new Question { Id = 4, QuestionText = "What is the purpose of middleware in ASP.NET Core?", Answer = "It processes requests and responses in a pipeline.", Hint = "Middleware runs in sequence to handle HTTP requests." }
            };
            return Ok(questions);
        }

    }
}
