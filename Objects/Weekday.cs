using System.Collections.Generic;
using System;

namespace WeekdayCalc
{
    public class Weekday
    {
        private string _date;
        private int _parsedYear;

        public Weekday(string date)
        {
            _date = date;
            string spliceDate = _date.Substring(8);
            _parsedYear = int.Parse(spliceDate);
        }

        public int GetParsedYear()
        {
            return _parsedYear;
        }
    }

}
