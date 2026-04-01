public class Solution {
    public bool IsAnagram(string s, string t) {

        // edge cases
        if(s.Length != t.Length){
            return false;
        }


        // convert string s to chars
        char[] s_char = s.ToCharArray();
        char[] t_char = t.ToCharArray();

        Dictionary<char, int> s_dict = new Dictionary<char, int>();
        Dictionary<char, int> t_dict = new Dictionary<char, int>();

        // in dictionary store count of each char of s
        for(int i =0; i < s_char.Length; i++){
            if(s_dict.ContainsKey(s_char[i])){
                s_dict[s_char[i]] += 1;
            }
            else{
                s_dict.Add(s_char[i], 1);
            }
        }

        for(int i =0; i < t_char.Length; i++){
            if(t_dict.ContainsKey(t_char[i])){
                t_dict[t_char[i]] += 1;
            }
            else{
                t_dict.Add(t_char[i], 1);
            }
        }

        // do the same for string t

        
        // compare two dictionaries


        // s_dict loop, find contains key in t_dict, if found compare value
        foreach(var sdict in s_dict){
            if(t_dict.ContainsKey(sdict.Key)){
                if(t_dict[sdict.Key] != sdict.Value){
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
