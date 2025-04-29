using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_vocabulary
{
    internal class WordIDAO : IWord
    {
        string connString = "Data Source=YANGLAPTOP\\YANGSQLSERVER;Initial Catalog=Vocabulary";
        public bool addWord(Word newWord)
        {
            throw new NotImplementedException();
        }

        public bool deleteWord(string id)
        {
            throw new NotImplementedException();
        }

        public void getAllWord()
        {
            throw new NotImplementedException();
        }
    }
}
