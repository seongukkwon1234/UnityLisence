using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellocode2 : MonoBehaviour
{
   
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);                  //변수를 선언하고 곧바로 함수를 사용한다
        Debug.Log("(2,2)에서 (5,6)까지의 거리 " + distance.ToString());
    }

    float GetDistance(float x1, float y1, float x2, float y2) //두 점 사이의 거리를 계산하는 함수[함수 이름: GetDistance][함수 리턴 변수 형 : float]
    {
        float width = x2 - x1;                    //거리 값을 뺀다
        float height = y2 - y1;

        float distance = width * width + height * height;      //w,h 의 제곱값을 distance 값에 넣어준다. 
        distance = Mathf.Sqrt(distance);                     //루트를 씌어준다

        return distance;                                //함수의 반환 값을 선언 해준다
    }
}
