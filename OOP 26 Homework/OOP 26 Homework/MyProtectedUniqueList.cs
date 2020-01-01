using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_26_Homework
{
    public class MyProtectedUniqueList
    {
        private List<string> words = new List<string>();
        private string secretWord;

        public MyProtectedUniqueList(string secretWord)
        {
            this.secretWord = secretWord;
        }

        public void Add(string word)
        {
            if (word == "" || word is null)
                throw new ArgumentNullException();
            if (words.Contains(word) == true)
                throw new InvalidOperationException();
            words.Add(word);
        }

        public void Remove(string word)
        {
            if (word == "" || word is null)
                throw new ArgumentNullException();
            if (words.Contains(word) == false)
                throw new ArgumentException();
            words.Remove(word);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= words.Capacity)
                throw new ArgumentOutOfRangeException();
            words.RemoveAt(index);
        }

        public void Clear(string keycode)
        {
            if (keycode != secretWord)
                throw new AccessViolationException();
            words.Clear();
        }

        public void Sort(string keycode)
        {
            if (keycode != secretWord)
                throw new AccessViolationException();
            words.Sort();
        }

        public int ListCount()
        {
            return words.Capacity;
        }

        public override string ToString()
        {
            string listString = "Protected String List:";
            words.ForEach(w => listString += $"\n{w}");
            return listString;
        }
    }
}
