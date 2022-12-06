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

        // 시작하면 큐브 사이즈가 2로 늘어나고
        // 2초 있다가
        // 큐브 사이즈가 다시 1이 되고
        // 4초 쉬었다가
        // 큐브 가로 사이즈만 3이 되고
        // 3초 있다가
        // 큐브 전체 사이즈가 4가 되고

        //스탑올코르틴을 사용하면 밑에있는 모든것이 실행되지 않는다.

        if (anim != null)
            StartCoroutine(StartDance());
             

    }

    IEnumerator StartDance()
    {
        //이렇게 하면 애니메이션이 끝난 뒤 2초쉬고 댄스2 애니메이션이 시작되고 하는 동작을 하는 것이다.
        //체력을 사용할 때 데미지르 받을 때마다 체력의 모양이 변하도록 할 수 있을 것이다.

        anim.Play("Dance1");
        //transform.localScale = new Vector3(2, 2, 2);

        //2초후 실행
        yield return new WaitForSeconds(2);

        // 코르틴을 계속 아래가지 실행된다.

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
