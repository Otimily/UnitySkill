using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCoroutine : MonoBehaviour
{

    Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
        StartCoroutine("StartDance");

        StopCoroutine("StartDance");

        // �����ϸ� ť�� ����� 2�� �þ��
        // 2�� �ִٰ�
        // ť�� ����� �ٽ� 1�� �ǰ�
        // 4�� �����ٰ�
        // ť�� ���� ����� 3�� �ǰ�
        // 3�� �ִٰ�
        // ť�� ��ü ����� 4�� �ǰ�

        //��ž���ڸ�ƾ�� ����ϸ� �ؿ��ִ� ������ ������� �ʴ´�.

        if (anim != null)
            StartCoroutine(StartDance());
             

    }

    IEnumerator StartDance()
    {
        //�̷��� �ϸ� �ִϸ��̼��� ���� �� 2�ʽ��� ��2 �ִϸ��̼��� ���۵ǰ� �ϴ� ������ �ϴ� ���̴�.
        //ü���� ����� �� �������� ���� ������ ü���� ����� ���ϵ��� �� �� ���� ���̴�.

        anim.Play("Dance1");
        //transform.localScale = new Vector3(2, 2, 2);

        //2���� ����
        yield return new WaitForSeconds(2);

        // �ڸ�ƾ�� ��� �Ʒ����� ����ȴ�.

        anim.Play("Dance2");
        //transform.localScale = new Vector3(1, 1, 1);

        yield return new WaitForSeconds(4);

        anim.Play("Dance3");
        //transform.localScale = new Vector3(3, 1, 1);

        yield return new WaitForSeconds(3);

        anim.Play("Dance4");
        //transform.localScale = new Vector3(4, 4, 4);

    }
}
