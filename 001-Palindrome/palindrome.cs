using System;

public class palindrome
{
   public static string result = "";
   public static int count = 0;
    public static void Main(string[] args)
    {
        string palindrome = makePalindrome("kjjjhjjj",2);
        Console.WriteLine ("result> " + palindrome);
    }
    
    public static string makePalindrome(string word, int max){
       
       
        if(isPalindrome(word))
        {
            return "palindrome";
        }
        else
        {
            
            int ini = 0, end = word.Length - 1;
            while(ini <= end)
            {
                if(count <= max)
                {
                    Console.WriteLine("count> " + count);
                    if(word[ini] != word[end])
                    {
                        Console.WriteLine("word[ini] != word[end]");
                        Console.WriteLine(word[ini] +"!=" + word[end]);
                        string newWord = word.Remove(ini,1);
                        count +=1;
                        Console.WriteLine("newWord> " + newWord);
                         
                        if(isPalindrome(newWord))
                        {
                            result += "" + word[ini].ToString();
                            return result;
                        }
                        else
                        {
                            result += "" + word[ini].ToString();
                            return makePalindrome(newWord, max-1);
                        }
                    }   
                }
                ini++;
                end--;
            }
            return "not possible";
            
        }
    }
    
    public static bool isPalindrome(string word){
        int i = 0;
        int j = word.Length-1;
        
        while(i <= j){
            if(word[i] != word[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}