using System.Collections.Generic;

namespace TD1cli
{
    public class Date
    {
        // Return ['day', 'hour', 'minute', 'second']
        public static List<int> second_to_date(int seconds)
        {
            List<int> result = new List<int>();
            result.Add(seconds / 86400);
            result.Add(seconds / 3600 % 24);
            result.Add(seconds / 60 % 60);
            result.Add(seconds % 60);
            return result;
        }
    }
}