using System;

public class Solution {
    /* MinSteps  recieves two strings that must be equal in length.
       conducts operations to make the second string an anagram 
       of the first, with the minimum number of steps.
       string s : first string
       string t : second string must become anagram of s
       
       speical cases identified, s == t
       returns number of steps
    */
    public int MinSteps(string s, string t) {
       //this will tell us how many manipulations we need
       int count = 0;

       //create an array with all 0's for each letter from a-z
       int[]frequency = new int[26];

       //fill the array
       for (int i = 0; i < 26; i++){
          frequency[i] = 0;
          //Console.WriteLine(frequency[i]);
       }
       //Console.WriteLine("End of freq");
      
       //Go through first string.. each letter increment frequency for that letter
       for (int i = 0; i < s.Length; i++){
       frequency[s[i] - 'a']++;
       //Console.WriteLine(s[i] - 'a');
       }
       //Console.WriteLine("End of s");
      
       //now go through second string and decrement each letter 
       for (int i = 0; i < t.Length; i++){
          frequency[t[i] - 'a']--;
          //Console.WriteLine(t[i] -'a');
          //Console.WriteLine(frequency[i]);
          
          //if an index is negative - thats one manipulation we need
          if (frequency[t[i] - 'a'] < 0)
          count++;
       }
       return count;
     }//end MinSteps

}//end Solution

public class MMM{

    static public void Main(String[] args){
         string s = "leetcode";
         string t = "practice";
         Solution c = new Solution();
         int count = c.MinSteps(s,t);
         Console.WriteLine(count);
         
         
    }//end main
}

