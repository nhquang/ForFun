		//https://leetcode.com/problems/jewels-and-stones/


    public int NumJewelsInStones(string J, string S) {
        int count = 0;
        for(int i = 0; i < S.Length; i++){
            for(int j = 0; j < J.Length; j++){
                if(S[i] == J[j]) count++;
            }
        }
        return count;
    }