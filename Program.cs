namespace Assignment_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "bully";
            string word2 = "lulb";

            string word3 = "staff";
            
            Console.WriteLine($"1:{word1}  2:{word2}");
            Console.WriteLine(IsAnagram(word1, word2));

            Console.WriteLine($"1:{word1}  2:{word3}");
            Console.WriteLine(IsAnagram(word1, word3));
        }
      
        public static bool IsAnagram(string word1, string word2)
        {
            Dictionary<char,int> tracker = new Dictionary<char,int>(); //keep track of the number of times each letter appears in string
            //key = char in string
            //value = # of times the char appears in string


            if ( word1.Length != word2.Length ) 
            {
                return false;
            }


            for ( int i = 0;  i < word1.Length; i++ )
            {
                char c = word1[i]; //current letter

                if (tracker.ContainsKey(c)) //if letter already in charCount, 

                    tracker[c]++;            // ++ its (count)
                else 
                    tracker[c] = 1;         //if it has not appeared, count = 1
            }

            for(int i = 0; i < word2.Length; i++ )
            {
                char c = word2[i]; //

                if (!tracker.ContainsKey(c)) //if letter is missing
                    return false;

                tracker[c]--;   //subtract from count

                if (tracker[c] == 0)  // If the count becomes zero, remove the char from the chaCount
                    tracker.Remove(c);

            }

            return tracker.Count == 0; //should equal 0 for the strings to be anagram

        }
    }
}
