static int birthdayCakeCandles(int[] ar) {
        int mayor = 0;
        int count = 0;

        foreach(var i in ar){
            if (i>mayor){
                count=0;
                mayor = i;                
            }
            if (mayor==i){
                count++;
            }
        }
        return count;

    }
