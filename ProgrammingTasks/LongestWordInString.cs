using System;

namespace ProgrammingTasks
{
    class LongestWordInString
    {
      //main method
      public static void Main()
      {
          //given string for finding the longest word
          string line = "Hello world this is a sample string";

          //splitting the string into words based on spaces
          string[] words = line.Split(new[] { " " }, StringSplitOptions.None);//splitting the string into words

           string word = "";//variable to store the longest word
           int ctr = 0; 

           // Looping through each word in the words array
           foreach (String s in words){
              // Checking if the length of the current word is greater than the stored maximum length
              if (s.Length > ctr)
              {
                word = s; // If the current word's length is greater, update the 'word' variable
                ctr = s.Length; // Update the maximum length counter
              }
            }
            Console.WriteLine(word); // Displaying the word with the maximum length
      }
    }
}