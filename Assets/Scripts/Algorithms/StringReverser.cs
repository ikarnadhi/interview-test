using UnityEngine;

/// <summary>
/// 
/// </summary>
public class StringReverser : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    private string reversedResult = string.Empty;

    void OnEnable()
    {
        var reverse1 = ReverseString("ISAI KARNADHI");
        var reverse2 = ReverseString("MAXXIMA");
        Debug.Log(reverse1 + "\n" + reverse2);
    }

    string ReverseString(string inputString)
    {
        if(string.IsNullOrEmpty(inputString))
            return string.Empty;

        var lastString = inputString[inputString.Length - 1];
        var shorterString = inputString.Remove(inputString.Length - 1);

        return lastString + ReverseString(shorterString);
    }
}
