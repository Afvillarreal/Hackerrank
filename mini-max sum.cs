 static void miniMaxSum(int[] arr) {
         
         int min = arr[0];
         int max = arr[0];         
         long sum = arr[0]; 

        
        for(int i=1;i<arr.Count();i++){

            sum +=arr[i];

            if (arr[i]<min){
                min= arr[i];
            }
            if (arr[i]>max){
                max= arr[i];
            }
        }
        Console.WriteLine((sum -max)+" "+(sum - min));
                  
}
