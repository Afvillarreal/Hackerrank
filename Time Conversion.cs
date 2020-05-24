 static string timeConversion(string s) {
        
        string total= "";
        bool pm = false;
        bool am = false;

        string start = s.Split(':')[0];
        string middle = s.Split(':')[1];
        string final = s.Split(':')[2];
       
        int hour = Convert.ToInt16(start);
        int minute = Convert.ToInt16(middle);
        
        for (int i=0;i<s.Length;i++){
            var moment = s.Substring(i,1);

            if (moment == "P"){
                pm=true;
                break;
            }
            if (moment == "A"){
                am=true;
                break;
            }                     
        }

        if (pm){
            final= final.Split("PM".ToCharArray())[0];
            if (hour != 12){
                hour += 12;
            }            
            start = Convert.ToString(hour);
            total =start+":"+middle+":"+final;
            return total;
        }

        else{

            if (hour==12){
                start="00";
            }

            final= final.Split("AM".ToCharArray())[0];
            total = start+":"+middle+":"+final;

            return total;
        }       
        
    }