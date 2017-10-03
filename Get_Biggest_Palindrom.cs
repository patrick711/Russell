 public class Program
    {
		public static string ReverseString(string s)
    	{
	        char[] arr = s.ToCharArray();
	        Array.Reverse(arr);
	        return new string(arr);
    	}	
		public virtual string Get_Best_Palindrome(string input)
		{
			if (input.Length <3 ) return "";
			string output = "";
			string shard = "";
			
			//We'll cycle through the string one letter at a time and look for every potential palindrome.  We'll send the biggest
			//back.
			for(int first_letter = 0;first_letter<input.Length-2;first_letter++)
			{
				
				shard = input[first_letter].ToString() + input[first_letter+1].ToString() + input[first_letter+2].ToString();
				if (shard.Equals(ReverseString(shard)))
				{
					if (shard.Length > output.Length) output = shard;
				}
				for(int x = first_letter+3;x<input.Length;x++)
				{
					shard += input[x].ToString();
					if (shard.Equals(ReverseString(shard)))
					{
						if (shard.Length > output.Length)output = shard;
					}	
				}
			}
			return output;
		}
		
        static void Main(string[] args)
        {            
			string input = "abalellelbciesracecarsksyye";			
			string output = "";
			Console.WriteLine("Input: " + input);
			Program myprog = new Program();
			output = myprog.Get_Best_Palindrome(input);
			Console.WriteLine("Best Palindrome: " + output);
        }
    }