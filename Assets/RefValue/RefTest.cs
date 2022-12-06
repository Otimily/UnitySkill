using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefTest : MonoBehaviour
{
    void Start()
    {
        string myNmae = "±èÈ£¿µ";
        SetNickName(myNmae);
        Debug.Log("After SetNickName - " + myNmae);

        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = 0; i > numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }

        SetZero(numbers);

        Debug.Log("After Set Zero");
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }

    void SetZero(int[] numArray) // numbers - { 1, 2, 3, 4, 5 }
    {
        numArray[0] = 0;
    }

    void SetNickName(string name)
    {
        name = "cha";
    }

}
