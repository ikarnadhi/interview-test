using UnityEngine;
using System;
using System.Globalization;

public class AgeFinder : MonoBehaviour
{
    public string oldDate = "dd-mm-yyyy";

    void OnEnable()
    {
        var deltaTime = GetDeltatime(oldDate);

        Debug.Log(FormatDeltaTime(deltaTime));
        Debug.Log(CountLeapYears(oldDate, deltaTime));
    }

    int GetDeltatime(string targetDate)
    {
        string format = "dd-MM-yyyy";
        
        if (!DateTime.TryParseExact(targetDate, format, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out DateTime parsedDate))
        {
            Debug.LogWarning($"Unable to parse date:{targetDate}");
            return -1;
        }

        var currentDate = DateTime.Now;
        var deltaTime = currentDate - parsedDate;

        return (int)deltaTime.TotalSeconds;
    }

    string FormatDeltaTime(int deltaTime)
    {
        int totalDays = deltaTime / 86400; // 1 day = 24 hours x 60 minutes x 60 seconds = 86400

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int months = remainingDays / 30;
        int days = remainingDays % 30;

        return $"{years} tahun, {months} bulan, {days} hari";
    }

    int CountLeapYears(string targetDate, int deltaTime)
    {
        string format = "dd-MM-yyyy";
        
        if (!DateTime.TryParseExact(targetDate, format, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out DateTime parsedDate))
        {
            Debug.LogWarning($"Unable to parse date:{targetDate}");
            return -1;
        }

        int totalDays = deltaTime / 86400; // 1 day = 24 hours x 60 minutes x 60 seconds = 86400

        int years = totalDays / 365;
        var tempDate = parsedDate;
        var leapCount = 0;

        for(int i = 0; i < years; i++)
        {
            tempDate = tempDate.AddYears(1);
            if(DateTime.IsLeapYear(tempDate.Year))
            {
                leapCount++;
            }
        }

        return leapCount;
    }
}
