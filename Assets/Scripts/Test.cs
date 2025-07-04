using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Hello, World를 Console 창에 출력한다.
        // Debug.Log("Hello, World!");

        // int age; // 변수를 선언한다 int는 박스고 age는 박스안에 물건이다.
        // age = 30; // 변수에 값을 부여한다 "대입" 이라고 한다. 즉 "대입연산" 이다.
        // Debug.Log(age); // console 창에 변수를 츨력한다.

        // 변수에 변수를 대임한다
        // float height1 = 160.5f;
        // float height2;
        // height2 = height1; // height1을 height2에 대입한다.
        // Debug.Log(height2); // height2를 console 창에 출력한다.

        // 문자열  console창에 출력.
        // string name;
        // name = "Sera";
        // Debug.Log(name);

        // 변수와 연산
        // int answer;
        // answer = 1 + 2;
        // Debug.Log(answer);

        // 연산 예시
        // int answer;

        // answer = 3 - 4;
        // Debug.Log(answer);

        // answer = 5 * 6;
        // Debug.Log(answer);

        // answer = 8 / 4;
        // Debug.Log(answer);

        // 변수와 변수의 연산
        // int n1 = 8;
        // int n2 = 9;
        // int answer;
        // answer = n1 + n2;
        // Debug.Log(answer);

        // 연산 편리화
        // answer = answer + 5;  ==  answer += 5; (변수명 += 증가하고 싶은 값;)
        // int answer = 10;
        // answer += 5;
        // Debug.Log(answer);

        // 변수의 값을 1만큼 늘릴 때 쓰는 증가 연산자 (변수명++;)
        // int answer = 10;
        // answer++;
        // Debug.Log(answer);

        // 문자열과 문자열의 연결
        // string str1 = "heppy";
        // string str2 = " birthday";
        // string message;
        // message = str1 + str2;
        // Debug.Log(message);

        // str1 += str2;
        // Debug.Log(str1);

        // 문자열과 숫자의 연결
        // string str = "heppy ";
        // int num = 123;
        // string message = str + num; // 문자열과 숫자를 연결하면 num은 문자열로 취급
        // Debug.Log(message);

        // 제어문 사용하기
        // int herbNum = 1;
        // if (herbNum == 1)
        // {
        //     Debug.Log("체력 50% 회복");
        // }

        // if ~ else 문으로 조건 분기하기
        // int hp = 0;
        //if (hp >= 100)
        // {
        //     Debug.Log("Attack");
        // }
        // else
        // {
        //     Debug.Log("Defence");
        // }

        // 조건이 2개 이상 일 때 else if 사용
        // int hp = 180;
        // if (hp <= 50)
        // {
        //     Debug.Log("Run!");
        // }
        // else if (hp >= 200)
        // {
        //     Debug.Log("Attack");
        // }
        // else
        // {
        //     Debug.Log("Defence");
        // }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
