using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecode : MonoBehaviour
{
    public int Hp = 10;           //체력 선언
    public float Distance = 0;
   

    void Start()
    {
        ObjectMove(3, 3.5f);
        ObjectMove(3, 3.5f);
        ObjectMove(3, 3.5f);
    }
    void ObjectMove(int _Hp, float _MoveDistance)
    {
        Hp = Hp - _Hp;                             //함수 동작 할때 인수로 받아온 Hp를 뺀다
        Distance = Distance + _MoveDistance;       //함수 동작할때 인수로 받아온 거리를 더한다

        Debug.Log("남은 체력 : " + Hp); 
        Debug.Log("이동 거리 : " + Distance);
    }
   
}
