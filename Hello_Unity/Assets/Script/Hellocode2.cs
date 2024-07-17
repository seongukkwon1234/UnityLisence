using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellocode2 : MonoBehaviour
{
   
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);                  //������ �����ϰ� ��ٷ� �Լ��� ����Ѵ�
        Debug.Log("(2,2)���� (5,6)������ �Ÿ� " + distance.ToString());
    }

    float GetDistance(float x1, float y1, float x2, float y2) //�� �� ������ �Ÿ��� ����ϴ� �Լ�[�Լ� �̸�: GetDistance][�Լ� ���� ���� �� : float]
    {
        float width = x2 - x1;                    //�Ÿ� ���� ����
        float height = y2 - y1;

        float distance = width * width + height * height;      //w,h �� �������� distance ���� �־��ش�. 
        distance = Mathf.Sqrt(distance);                     //��Ʈ�� �����ش�

        return distance;                                //�Լ��� ��ȯ ���� ���� ���ش�
    }
}
