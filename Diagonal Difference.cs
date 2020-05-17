public static int diagonalDifference(List<List<int>> arr)
    {
        int sum = 0;
        int rest = 0;

        for (int i = 0; i<arr.Count();i++){
                int index= arr.Count()-i-1;
                Console.WriteLine(arr[i][index]);
                sum = sum +arr[i][i];
                rest = rest +arr[i][index];
        }
       int total = (sum-rest);       
    
       return Math.Abs(total);
    }
