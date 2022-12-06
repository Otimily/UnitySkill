using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    public static int Score; // 앱이 끝날 때까지

    public static int Num;
    static Person p;

    void Start()
    {
        Score = 0;
        p = new Person("cha", 26);

    }

    static void TestFunc()
    {
        Score = 10;
        Debug.Log(Score);

        Num = 10;
        p = new Person("cha", 26);
        Debug.Log(Num);
    }
}
