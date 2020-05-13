static void plusMinus(int[] arr) {
        
        double zero = 0;
        double positive = 0;
        double negative = 0;

        foreach (int num in arr){
            
            if (num == 0){
                zero++;
            }
            if (num > 0 ) positive++;

            if (num < 0) negative++; 
        }
        
        Console.WriteLine(positive/arr.Count());
        Console.WriteLine(negative/arr.Count());
        Console.WriteLine(zero/arr.Count());
    }
