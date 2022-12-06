using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaCoroutine : MonoBehaviour
{
    Image backImg;

    void Start()
    {
        backImg = GetComponent<Image>();

        //color
        //0~1
        // rgb - alpha
        Color newColor = new Color(219, 177, 255, 255);

        //color32
        //0~255
        // rgba - alpha
        Color32 newColor32 = new Color32(219,177,255,255);

        //backImg.color = newColor32;

        //StartCoroutine("FadeOut");
    }

    

    private void Update()
    {
        // 255 -> 0
        // 255 -> 254 -> 253.. 서서히 그라데이션으로 알파값이 줄어들게 하는 것을 배울 것이다.
        //backgroundImg.color = new Color32(219, 177, 255 , 0);

        //float alpha = backgroundImg.color.a - 0.01f;
        //backgroundImg.color = new Color(backgroundImg.color.r, backgroundImg.color.g, backgroundImg.color.b, alpha);


    }

    public void OnClick()
    {
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {

        //bool true  false
        while (backImg.color.a >= 0)
        {
            float alpha = backImg.color.a - 0.0001f;
            backImg.color = new Color(backImg.color.r, backImg.color.g, backImg.color.b, alpha);

            yield return null;

        }


    }
}
