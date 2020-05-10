static long repeatedString(string s, long n) {
            
        long whole = n / s.Count();
        long remainder = (n % s.Count());
        long found = 0;

        foreach(char ch in  s){
            if (ch =='a'){
                found++;
            }
            }
         long total = whole*found;
           if (remainder==0){
               return total;
           }
           else{
               for (int i=0; i<remainder; i++){
                   if (s[i] =='a'){
                       total++;
                   }
               }
           }                      
            return total;
                        
 }
