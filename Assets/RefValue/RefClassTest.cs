using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefClassTest : MonoBehaviour
{
    void Start()
    {
        StaticTest.Score = 100;

        Person cha = new Person("�达", 26);
        Debug.Log("�̸� : " + cha.Name);
        Debug.Log("���� : " + cha.age); //26
        Debug.Log("�������� : " + cha.money);

        AddAge(cha);
        Debug.Log("���� agter AddAge : " + cha.age); //26

        SallayDay(cha);
        Debug.Log("�������� SallayDay AddAge : " + cha.money); //0

    }

    void AddAge(Person p) // p.age = 26
    {
        p.age++; // p.age = 26
    }

    void SallayDay(Person p) // p.money = 0
    {
        p.money += 100; // p.money
    }
}

public class Person
{
    public string Name;
    public int age;
    public int money;

    public Person(string Name, int age)
    {
        this.Name = Name;
        this.age = age;
        money = 0;
    }
}