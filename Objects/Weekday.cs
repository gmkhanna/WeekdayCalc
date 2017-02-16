using System.Collections.Generic;
using System;

namespace WeekdayCalc
{
    public class Weekday
    {
        private string _date;
        private int _parsedFullYear;
        private int _parsedLastTwoYear;
        private int _century;
        private int _parsedDay;
        private int _parsedMonth;
        private int _remainderYear;
        private int _dayPlusYear;
        private int _afterMonthValue;
        private int _afterCenturyValue;
        private int _afterAddedYearDigits;
        private int _finalNumber;
        private Dictionary<int, int> _monthKey = new Dictionary<int, int>()
        {
            {01, 1}, {02, 4}, {03, 4}, {04, 0}, {05, 2}, {06, 5}, {07, 0}, {08, 3}, {09, 6}, {10, 1}, {11, 4}, {12, 6}
        };

        private Dictionary<int, int> _centuryKeys = new Dictionary<int, int>()
        {
            {0, 6}, {100, 4}, {200, 2}, {300, 0}
        };

        private Dictionary<int, string> _dayKeys = new Dictionary<int, string>()
        {
            {1, "Sunday"}, {2, "Monday"}, {3, "Tuesday"}, {4, "Wednesday"}, {5, "Thursday"}, {6, "Friday"}, {0, "Saturday"}
        };

        public Weekday(string date)
        {
            _date = date;

            string spliceFullYear = date.Substring(6,4);
            _parsedFullYear = int.Parse(spliceFullYear);

            string spliceHalfYear = date.Substring(8,2);
            _parsedLastTwoYear = int.Parse(spliceHalfYear);

            string spliceHalfFirstTwoYear = date.Substring(6,2);
            _century = int.Parse(spliceHalfFirstTwoYear) * 100;

            string spliceDay = date.Substring(3,2);
            _parsedDay = int.Parse(spliceDay);

            string spliceMonth = date.Substring(0,2);
            _parsedMonth = int.Parse(spliceMonth);

            _remainderYear = _parsedLastTwoYear % 4;
            _dayPlusYear = _parsedLastTwoYear/4 + _parsedDay;
            _afterMonthValue = _dayPlusYear + _monthKey[_parsedMonth];

            LeapYearTest();
            CenturyTest();

            _afterAddedYearDigits = GetAfterCenturyValue() + _parsedLastTwoYear;
            _finalNumber = _afterAddedYearDigits % 7;
        }

        public void CenturyTest()
        {
            int centuryKey = Math.Abs(_century % 400);

            foreach(KeyValuePair<int, int> entry in _centuryKeys)
            {
                if(centuryKey == entry.Key)
                {
                    _afterCenturyValue = _afterMonthValue + entry.Value;
                }
            }
        }

        public void LeapYearTest()
        {
            if(_parsedMonth == 01 || _parsedMonth == 02)
            {
                if (_parsedFullYear % 400 == 0)
                {
                    _afterMonthValue -= 1;
                }
                else if(_parsedFullYear % 100 == 0)
                {
                    _afterMonthValue -= 0;
                }
                else if (_parsedFullYear % 4 == 0)
                {
                    _afterMonthValue -= 1;
                }
                else
                {
                    _afterMonthValue -= 0;
                }
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
            return _afterMonthValue;
        }

        public int GetAfterAddedYearDigits()
        {
            return _afterAddedYearDigits;
        }

        public int GetAfterCenturyValue()
        {
            return _afterCenturyValue;
        }

        public string GetWeekDay()
        {
            string result = "";

            foreach(KeyValuePair<int, string> entry in _dayKeys)
            {
                if(_finalNumber == entry.Key)
                {
                    result = entry.Value;
                    break;
                }
                else
                {
                }
            }

            return result;
        }
    }

}
