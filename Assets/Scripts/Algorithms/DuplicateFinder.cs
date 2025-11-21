using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 
/// </summary>
public class DuplicateFinder : MonoBehaviour
{
    void OnEnable()
    {
        var list1 = new List<int>(){ -9, -9, -5, 1, 1, 1, 2, 2,  3, 4,  5  };

        var results1 = FindDuplicates(list1);
        Debug.Log(string.Join(", ", results1));
    }

    List<int> FindDuplicates(List<int> numbersList)
    {
        var uniqueNumbers = new List<int>();
        var duplicateNumbers = new List<int>();
        foreach (int number in numbersList)
        {
            //if(number < 0) continue;

            if(!uniqueNumbers.Contains(number))
            {
                uniqueNumbers.Add(number);
            }
            else
            {
                if(!duplicateNumbers.Contains(number))
                {
                    duplicateNumbers.Add(number);
                }
            }
        }

        return duplicateNumbers;
    }
}