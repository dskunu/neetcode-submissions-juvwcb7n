public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0){
            return new List<List<string>>();
        }

        List<List<string>> lstResult = new List<List<string>>();
        Dictionary<string, List<string>> sortedStrs = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            char[] characters = strs[i].ToCharArray();
            Array.Sort(characters);
            string sortedstring = new string(characters);
            if(sortedStrs.ContainsKey(sortedstring)){
                sortedStrs[sortedstring].Add(strs[i]);
            }
            else{
                sortedStrs.Add(sortedstring, new List<string> {strs[i]} );
            }
        }
        return sortedStrs.Values.ToList();

         
    }
}
