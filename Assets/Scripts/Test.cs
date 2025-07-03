using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Hello, World를 Console 창에 출력한다.
        // Debug.Log("Hello, World!");

        // int age; // 변수를 선언한다 int는 박스고 age는 박스안에 물건이다.
        // age = 30; // 변수에 값을 부여한다 "대입" 이라고 한다.
        // Debug.Log(age); // console 창에 변수를 츨력한다.

        // 변수에 변수를 대임한다
        float height1 = 160.5f;
        float height2;
        height2 = height1; // height1을 height2에 대입한다.
        Debug.Log(height2); // height2를 console 창에 출력한다.
    }

    // Update is called once per frame
    void Update()
    {

    }
}
