using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    public class LanguageKnowledge
    {
        public int KnowledgeL { get; set; }
        public string Language { get; set; }

        public LanguageKnowledge(int knowledgeL, string language)
        {
            KnowledgeL = knowledgeL;
            Language = language;
        }
    }
}
