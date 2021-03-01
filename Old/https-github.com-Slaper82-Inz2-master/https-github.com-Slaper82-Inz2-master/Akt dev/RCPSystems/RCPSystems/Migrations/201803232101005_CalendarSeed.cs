namespace RCPSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarSeed : DbMigration
    {
        public override void Up()
        {
            Sql(@"DECLARE @StartDate DATE = '20170101', @NumberOfYears INT = 5;


                SET DATEFIRST 7;
                SET DATEFORMAT mdy;
                SET LANGUAGE US_ENGLISH;


                DECLARE @CutoffDate DATE = DATEADD(YEAR, @NumberOfYears, @StartDate);


                CREATE TABLE #dim
                (
                  [date]       DATE PRIMARY KEY, 
                  [day]        AS DATEPART(DAY,      [date]),
                  [month]      AS DATEPART(MONTH,    [date]),
                  FirstOfMonth AS CONVERT(DATE, DATEADD(MONTH, DATEDIFF(MONTH, 0, [date]), 0)),
                  [MonthName]  AS DATENAME(MONTH,    [date]),
                  [week]       AS DATEPART(WEEK,     [date]),
                  [ISOweek]    AS DATEPART(ISO_WEEK, [date]),
                  [DayOfWeek]  AS DATEPART(WEEKDAY,  [date]),
                  [quarter]    AS DATEPART(QUARTER,  [date]),
                  [year]       AS DATEPART(YEAR,     [date]),
                  FirstOfYear  AS CONVERT(DATE, DATEADD(YEAR,  DATEDIFF(YEAR,  0, [date]), 0)),
                  Style112     AS CONVERT(CHAR(8),   [date], 112),
                  Style101     AS CONVERT(CHAR(10),  [date], 101)
                );

                INSERT #dim([date]) 
                SELECT d
                FROM
                (
                  SELECT d = DATEADD(DAY, rn - 1, @StartDate)
                  FROM 
                  (
                    SELECT TOP (DATEDIFF(DAY, @StartDate, @CutoffDate)) 
                      rn = ROW_NUMBER() OVER (ORDER BY s1.[object_id])
                    FROM sys.all_objects AS s1
                    CROSS JOIN sys.all_objects AS s2
                    ORDER BY s1.[object_id]
                  ) AS x
                ) AS y;

                INSERT dbo.Calendar WITH (TABLOCKX)
                SELECT
                  DateKey       = CONVERT(INT, Style112),
                  [Date]        = [date],
                  [Day]         = CONVERT(TINYINT, [day]),
                  DaySuffix     = CONVERT(CHAR(2), CASE WHEN [day] / 10 = 1 THEN 'th' ELSE 
                                  CASE RIGHT([day], 1) WHEN '1' THEN 'st' WHEN '2' THEN 'nd' 
	                              WHEN '3' THEN 'rd' ELSE 'th' END END),
                  [Weekday]     = CONVERT(TINYINT, [DayOfWeek]),
                  [WeekDayName] = CONVERT(VARCHAR(10), DATENAME(WEEKDAY, [date])),
                  [IsWeekend]   = CONVERT(BIT, CASE WHEN [DayOfWeek] IN (1,7) THEN 1 ELSE 0 END),
                  [IsHoliday]   = CONVERT(BIT, 0),
                  HolidayText   = CONVERT(VARCHAR(64), NULL),
                  [DOWInMonth]  = CONVERT(TINYINT, ROW_NUMBER() OVER 
                                  (PARTITION BY FirstOfMonth, [DayOfWeek] ORDER BY [date])),
                  [DayOfYear]   = CONVERT(SMALLINT, DATEPART(DAYOFYEAR, [date])),
                  WeekOfMonth   = CONVERT(TINYINT, DENSE_RANK() OVER 
                                  (PARTITION BY [year], [month] ORDER BY [week])),
                  WeekOfYear    = CONVERT(TINYINT, [week]),
                  ISOWeekOfYear = CONVERT(TINYINT, ISOWeek),
                  [Month]       = CONVERT(TINYINT, [month]),
                  [MonthName]   = CONVERT(VARCHAR(10), [MonthName]),
                  [Quarter]     = CONVERT(TINYINT, [quarter]),
                  QuarterName   = CONVERT(VARCHAR(6), CASE [quarter] WHEN 1 THEN 'First' 
                                  WHEN 2 THEN 'Second' WHEN 3 THEN 'Third' WHEN 4 THEN 'Fourth' END), 
                  [Year]        = [year],
                  MMYYYY        = CONVERT(CHAR(6), LEFT(Style101, 2)    + LEFT(Style112, 4)),
                  MonthYear     = CONVERT(CHAR(7), LEFT([MonthName], 3) + LEFT(Style112, 4)),
                  FirstDayOfMonth     = FirstOfMonth,
                  LastDayOfMonth      = MAX([date]) OVER (PARTITION BY [year], [month]),
                  FirstDayOfQuarter   = MIN([date]) OVER (PARTITION BY [year], [quarter]),
                  LastDayOfQuarter    = MAX([date]) OVER (PARTITION BY [year], [quarter]),
                  FirstDayOfYear      = FirstOfYear,
                  LastDayOfYear       = MAX([date]) OVER (PARTITION BY [year]),
                  FirstDayOfNextMonth = DATEADD(MONTH, 1, FirstOfMonth),
                  FirstDayOfNextYear  = DATEADD(YEAR,  1, FirstOfYear)
                FROM #dim
                OPTION (MAXDOP 1);

                select * from #dim");
        }
        
        public override void Down()
        {
        }
    }
}
