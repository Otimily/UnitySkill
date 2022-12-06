using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueTest : MonoBehaviour
{


    void Start()
    {
        int x = 10;

        //PlusNum(x);
        //Debug.Log("after PlusNum x - : " + x);

        DoubleNum(ref x);
        Debug.Log("after DoubleNum x - " + x);

    }

    void PlusNum(int num) // 10
    {
        num += 1;
        Debug.Log("PlusNum - num : " + num); // 11
    }

    void MinusNum(int num) // 10
    {
        num -= 1;
        Debug.Log("MinusNum - num : " + num); // 9

    }

    void DoubleNum(ref int num) // 10
    {
        num *= 1;
        Debug.Log("DoubleNum - num : " + num); // 20

    }

}
