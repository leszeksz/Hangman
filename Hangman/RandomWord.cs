using System;
using System.IO;

namespace Hangman {
    public class RandomWord : IWordable {
        public string Word() {
            return Words()[Position()].ToUpper();
        }

        private int Position() {
            return (new Random()).Next(Words().Length);
        }

        private string[] Words(){
            return RawWords().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }

        private string RawWords() {
            return File.ReadAllText("countries_and_capitals.txt").Split(' ')[2].TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}