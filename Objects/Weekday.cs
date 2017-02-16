using System.Collections.Generic;
using System;

namespace WeekdayCalc
{
    public class Weekday
    {
        private string _date;
        private int _parsedFullYear;
        private int _parsedLastTwoYear;
        private int _parsedDay;
        private int _parsedMonth;
        private int _remainderYear;
        private int _dayPlusYear;
        private int _afterMonthValue;
        public static Dictionary<int, int> monthKey = new Dictionary<int, int>()
        {
            {01, 1}, {02, 4}, {03, 4}, {04, 0}, {05, 2}, {06, 5}, {07, 0}, {08, 3}, {09, 6}, {10, 1}, {11, 4}, {12, 6}
        };
        public Weekday(string date)
        {
            _date = date;

            string spliceFullYear = date.Substring(6,4);
            _parsedFullYear = int.Parse(spliceFullYear);

            string spliceHalfYear = date.Substring(8,2);
            _parsedLastTwoYear = int.Parse(spliceHalfYear);

            string spliceDay = date.Substring(3,2);
            _parsedDay = int.Parse(spliceDay);

            string spliceMonth = date.Substring(0,2);
            _parsedMonth = int.Parse(spliceMonth);

            _remainderYear = _parsedLastTwoYear % 4;
            _dayPlusYear = _parsedLastTwoYear/4 + _parsedDay;
            _afterMonthValue = _dayPlusYear + monthKey[_parsedMonth];
        }

        public void LeapYearTest()
        {
            if (_parsedFullYear % 400 == 0)
            {
                _afterMonthValue += 1;
            }
            else if(_parsedFullYear % 100 == 0)
            {
                _afterMonthValue += 0;
            }
            else if (_parsedFullYear % 4 == 0)
            {
                _afterMonthValue += 1;
            }
            else
            {
                _afterMonthValue += 0;
            }
        }

        public int GetParsedYear()
        {
            return _parsedLastTwoYear;
        }

        public int GetDividedYear()
        {
            return _parsedLastTwoYear/4;
        }

        public int GetRemainder()
        {
            return _remainderYear;
        }

        public int GetDayPlusYear()
        {
            return _dayPlusYear;
        }

        public int GetAfterMonthValue()
        {
            LeapYearTest();
            return _afterMonthValue;
        }
    }

}
