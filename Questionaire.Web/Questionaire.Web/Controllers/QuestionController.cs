using Microsoft.AspNetCore.Mvc;
using Questionaire.Web.Data;
using Questionaire.Web.Data.Stubs;
using Questionaire.Web.Models;
using System;
using System.Diagnostics;

namespace Questionaire.Web.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ILogger<QuestionController> _logger;
        public QuestionController(ILogger<QuestionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Random random = new Random();
            var model = new QuestionViewModel
            {
                inputQuestions = Stub.Questions.OrderBy(data => random.Next()).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(QuestionViewModel model)
        {
            if(!ModelState.IsValid)
                return View("Index", model);

            var resultModel = GetResultViewModel(model.inputQuestions);
            return View("Result", resultModel);
        }

        private ResultViewModel GetResultViewModel(List<Question> questions)
        {
            var model = new ResultViewModel();

            model.TotalAns = questions.Where(data => !string.IsNullOrEmpty(data.Answer)).Count();
            model.CountAnsA = questions.Where(data => data.Answer == "A").Count();
            model.CountAnsB = questions.Where(data => data.Answer == "B").Count();
            model.CountAnsC = questions.Where(data => data.Answer == "C").Count();

            if (model.CountAnsA > model.CountAnsB &&
                    model.CountAnsA > model.CountAnsC)
                model.Result = "Empathy You are emphatic. You see yourself in someone else’s situation before doing\r\ndecisions. You tend to listen to other’s voices";

            else if (model.CountAnsB > model.CountAnsA &&
                     model.CountAnsB > model.CountAnsC)
                model.Result = "Self-Awareness You are conscious of your own character, feelings, motives, and desires.\r\nThe process can be painful but it leads to greater self-awareness.\r\n";

            else if (model.CountAnsC > model.CountAnsA &&
                     model.CountAnsC > model.CountAnsB)
                model.Result = "Self-Management You manage yourself well; You take responsibility for your own behavior\r\nand well-being.";
            
            else 
                model.Result = "Self-Awareness You are conscious of your own character, feelings, motives, and desires.\r\nThe process can be painful but it leads to greater self-awareness.\r\n";

            return model;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}