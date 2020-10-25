	//https://leetcode.com/problems/maximum-number-of-balloons/
	
	
	public int MaxNumberOfBalloons(string text) {
        
        var balloons = new Dictionary<char,int>();
        for(int i = 0; i < text.Length; i++){
            if(text[i] == 'b' || text[i] == 'a' || text[i] == 'l' || text[i] == 'o' || text[i] == 'n'){
                if(balloons.ContainsKey(text[i])) balloons[text[i]]++;
                else balloons.Add(text[i], 1);
            }
        }
        
        if(balloons.Count < 5) return 0;
        int lowest = balloons.ElementAt(0).Value;
        
        foreach(var letter in balloons){
            int temp = 0;
            if(letter.Key == 'l' || letter.Key == 'o'){
                temp = letter.Value / 2;
                if(temp < lowest) lowest = temp;
            }
            else
                if(letter.Value < lowest) lowest = letter.Value;
        }
        
        return lowest;
    }