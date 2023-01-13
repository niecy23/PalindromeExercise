using System;
using System.Linq;
namespace PalindromeExercise
{
	public class WordSmith
	{
		//Method to determine if a word is a palindrome.
		public bool IsAPalindrome(string word)
		{
			char[] newArray = word.ToCharArray();
			Array.Reverse(newArray);
			var arrayReversed = new string(newArray);

			if (arrayReversed.ToLower() == word.ToLower())
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}
}
