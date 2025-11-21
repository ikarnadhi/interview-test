using UnityEngine;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 
/// </summary>
public class PrimeSumTool : MonoBehaviour
{
    public int target = 0;

    void OnEnable()
    {
        var results = PrimesUpTo(target);
        Debug.Log(string.Join(", ", results));
    }

    List<int> PrimesUpTo(int target)
    {
        var primes = new List<int>();
        
        if(target < 2) return primes;

        for(int i = 0; i < target; i++)
        {
            if(IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes;
    }

    bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for(int i = 3; i < number; i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
