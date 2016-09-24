using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.BusinessLogic
{
    public class Tools
    {
        public bool LetterInAWord(char letter, string word)
        {
            return word.Contains(letter);
        }
    }
}
