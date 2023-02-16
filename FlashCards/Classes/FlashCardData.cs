using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Classes
{
    public struct FlashCardData
    {
        public int ID;
        public string Question { get; set; }
        public string Answer { get; set; }

        public List<string> Filters;

        public FlashCardData(int id, string question, string answer, List<string> filters)
        {
            ID = id;
            Question = question;
            Answer = answer;
            Filters = filters;
        }
    }
}
