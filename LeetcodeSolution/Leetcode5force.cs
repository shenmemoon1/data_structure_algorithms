public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) {
            return "";
        }
        string ans = "";
        int max = 0;
        int len = s.Length;
        for (int i = 0; i < len; i++) {
            for (int j = i + 1; j <= len; j++) {
                string test = s.Substring(i, j - i); // Adjust substring end index
                if (IsPalindrome(test) && test.Length > max) { // Fix method name and condition
                    ans = test;
                    max = ans.Length;
                }
            }
        }
        return ans;
    }

    // Fix method name and parameter name
    public bool IsPalindrome(string text){
        int len = text.Length; // Add missing variable declaration
        int m = len / 2; // Fix variable name
        for(int i = 0; i < m; i++){
            if (text[i] != text[len - i - 1]) { // Fix indexing and comparison
                return false;
            }
        }
        return true;
    }
}
