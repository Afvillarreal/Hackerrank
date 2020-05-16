static void staircase(int n) {
        
       for (int y = n-1; y>=0; y--)
       {
           
           for (int x = 0; x<n; x++)
           {
               if (x>=y){
                   Console.Write("#");
               }
               if (x<y){
                   Console.Write(" ");
               }
           }
           Console.WriteLine("");
       }

    }
