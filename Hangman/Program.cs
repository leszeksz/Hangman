using System;

namespace Hangman {
    public class Hangman {
        public static void Main(string[] args) {
            var wordGenerator = new RandomWord();
            var word = wordGenerator.Word();
            var game = new Game(word);
            var width = Math.Min(81, Console.WindowWidth);
            
            char key = Console.ReadKey(true).KeyChar;
                game.GuessLetter(Char.ToUpper(key));
                
                Console.Write(key);
                Console.Write(word);

        }
    }
}