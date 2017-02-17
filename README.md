# Weekday Calculator

## By Lawrence Eby, Grinil Khanna, and Derek Villars


## Description

A basic C# weekday calculator.

## Specs

1. User inputs a year, and we analyze the last two digits of the year.
    * __Input:__ 02/16/2017
    * __Output:__ 17
- Divide this number by 4.
    * __Input:__ 17 (17 / 4)
    * __Output:__ 4
- Save the remainder of this initial equation into a variable (for later).
    * __Input:__ 17
    * __Output:__ 1
- Add the day of the month with the initial divided number
    * __Input:__ (Day: 16) (year: 17)
    * __Output:__ 20
- Add this output to the key month's value (See Figure 1)
    * __Input:__ 20
    * __Output:__ 24
- Subtract 1 if the year is a leap year and the month is Jan. or Feb.
    * __Input:__ 24
    * __Output:__ 24
- Add century code (if year is not in Figure 2 add or subtract 400 until its found, See Figure 2)
    * __Input:__ 24
    * __Output:__ 30
- Add the last two digits of the year to the total
    * __Input:__ 30
    * __Output:__ 47
- Divide by 7 and take the remainder, which is the day of the week (0 is Saturday; see Figure 3).
    * __Input:__ 47
    * __Ouput:__ 5

## Known Bugs
Years in the zero century do not return a correct value.

Figure 1

|Jan|Feb|Mar|Apr|May|June|July|Aug|Sept|Oct|Nov|Dec|
|---|---|---|---|---|----|----|---|----|---|---|---|
| 1 | 4 | 4 | 0 | 2 | 5  | 0  | 3 | 6  | 1 | 4 | 6 |

Figure 2

|1700s|1800s|1900s|2000s|
|-----|-----|-----|-----|
|  4  |  2  |  0  |  6  |

Figure 3

|Sun|Mon|Tue|Wed|Thr|Fri|Sat|
|---|---|---|---|---|---|---|
| 1 | 2 | 3 | 4 | 5 | 6 | 0 |
