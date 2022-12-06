using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null; // 값이 null 상태이다.

    public int Score;

    private void Awake()
    {
        Instance = this;
    }
}
