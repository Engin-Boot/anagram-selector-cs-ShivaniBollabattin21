using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            char[] char_word1 = word1.ToLower().ToCharArray();
            char[] char_word2 = word2.ToLower().ToCharArray();
            Array.Sort(char_word1);
            Array.Sort(char_word2);
            string new_word1 = new string(char_word1);
            string new_word2 = new string(char_word2);
            if(new_word1 == new_word2)
            {
                return true;
            }
            return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            List<string> anagramList = new List<string>();
            for(int i=0;i<candidates.Count;i++)
            {
                if(WordPairIsAnagram(word,candidates[i]))
                {
                    anagramList.Add(candidates[i]);
                }
            }
            return anagramList;
        }
    }
}
