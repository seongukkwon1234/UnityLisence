using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecode : MonoBehaviour
{
    public int Hp = 10;           //ü�� ����
    public float Distance = 0;
   

    void Start()
    {
        ObjectMove(3, 3.5f);
        ObjectMove(3, 3.5f);
        ObjectMove(3, 3.5f);
    }
    void ObjectMove(int _Hp, float _MoveDistance)
    {
        Hp = Hp - _Hp;                             //�Լ� ���� �Ҷ� �μ��� �޾ƿ� Hp�� ����
        Distance = Distance + _MoveDistance;       //�Լ� �����Ҷ� �μ��� �޾ƿ� �Ÿ��� ���Ѵ�

        Debug.Log("���� ü�� : " + Hp); 
        Debug.Log("�̵� �Ÿ� : " + Distance);
    }
   
}
