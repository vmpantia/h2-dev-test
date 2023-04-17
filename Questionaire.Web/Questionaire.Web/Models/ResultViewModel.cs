using Questionaire.Web.Data;

namespace Questionaire.Web.Models
{
    public class ResultViewModel
    {
        public int CountAnsA { get; set; }
        public int CountAnsB { get; set; }
        public int CountAnsC { get; set; }
        public int TotalAns { get; set; }
        public string Result { get; set; }
    }
}
