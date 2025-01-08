namespace MyLibrary
{
    public class Math
    {
        public static string SecondsToTime(int userSeconds)
        {
            int hours  = 0;
            int minutes = 0;
            int seconds = 0;

            if (userSeconds < 0) throw new ArgumentOutOfRangeException("El valor ha de ser positiu!");
            else 
            {
                while (userSeconds >= 60) 
                {
                    if (userSeconds >= 60) userSeconds -= 60;

                    minutes++;

                    if(minutes >= 60)
                    {
                        minutes -=60;
                        hours++;
                    }
                }

                seconds = userSeconds; 
            }
            return $"{hours} hora {minutes} minuts {seconds} segons";
        }
    }
}
