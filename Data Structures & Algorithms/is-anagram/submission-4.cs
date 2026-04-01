public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char,int> dict_s = new Dictionary<char, int>();
        //Dictionary<char,int> dict_t = new Dictionary<char, int>();
        
        foreach(char s_char in s.ToCharArray()){
            if(dict_s.ContainsKey(s_char)){
                // Console.WriteLine("adding +1 to dict_s for char:" + s_char);
                dict_s[s_char] += 1;
            }
            else{
                dict_s.Add(s_char, 1);
            }
        }

        foreach(char t_char in t.ToCharArray()){
            if(dict_s.ContainsKey(t_char)){
                dict_s[t_char] -= 1;

                if(dict_s[t_char] < 0){
                    return false;
                }
            }
            else{
                return false;
            }
        }

        return true;

    }
}
