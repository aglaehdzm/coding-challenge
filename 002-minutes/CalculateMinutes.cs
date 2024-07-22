using System;

public class CalculateMinutes
{
    public static void Main(string[] args)
    {
        string date = "1:23am-1:08am";
        
        string [] hours = date.Split('-');
        string [] time1 = hours[0].Split(':');
        
        int hour1 = int.Parse(time1[0]);
        int minute1 = int.Parse(time1[1].Substring(0,2));
        string meridian1 = time1[1].Substring(2,2);
        
        Console.WriteLine (hour1);
        Console.WriteLine (minute1);
        Console.WriteLine (meridian1);
        
        Console.WriteLine ("----------");

        string [] time2 = hours[1].Split(':');
        
        int hour2 = int.Parse(time2[0]);
        int minute2 = int.Parse(time2[1].Substring(0,2));
        string meridian2 = time2[1].Substring(2,2);
        
        Console.WriteLine (hour2);
        Console.WriteLine (minute2);
        Console.WriteLine (meridian2);
        
        if(meridian1 == "pm" && hour1 != 12){
            hour1 += 12;
        }
        else if(meridian1 == "am" && hour1 == 12){
            hour1 = 0;
        }
        
        if(meridian2 == "pm" && hour2 != 12){
            hour2 += 12;
        }
        else if(meridian2 == "am" && hour2 == 12){
            hour2 = 24;
        }
        int totalHour= 0;
        
        if(hour1 == hour2){
            totalHour = 24 * 60;
        }
        else{
            totalHour = (hour2 - hour1) * 60;
        }
        
        int totalMinute = 0;
        if(minute1 > minute2){
            totalMinute = minute1-minute2;
        }
        else {
            totalMinute = minute2-minute1;
        }
        int total = totalHour - totalMinute;
        Console.WriteLine ("----------");
        Console.WriteLine (hour1);
        Console.WriteLine (hour2);
         Console.WriteLine ("----------");
        Console.WriteLine (totalHour);
        Console.WriteLine (totalMinute);
        Console.WriteLine (total);


    }
}