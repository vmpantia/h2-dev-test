using System.ComponentModel.DataAnnotations;

namespace Questionaire.Web.Data
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; }

        [Required]
        public string Answer { get; set; }

        public List<Choice> Choices { get; set; }
    }
}
