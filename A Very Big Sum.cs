static long aVeryBigSum(long[] ar) {
    
        long total=0;
        foreach (long num in ar){
            total= total + num;           
        }

        Console.WriteLine(total);
        return total;
    }