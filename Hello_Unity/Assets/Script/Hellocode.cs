using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellocode : MonoBehaviour
{   
       public string CharacterName = "���";             //���ڿ� ���� ����(string)
       public char bloodtype = 'A';                      //���� ���� ����(char)
       public int age = 17;                              //���� ���� ����(int)
       public float height = 160.8f;                     //�Ǽ� ���� ����(float)
       public bool isFemale = true;                      //�� ������ �Ǻ��ϴ� ���� ����(bool)
    void Start()
    {   
        Debug.Log("�ɸ��� �̸� : " + CharacterName);        //�ɸ��� �̸� : ���
        Debug.Log("������ : " +  bloodtype);             //������ : A
        Debug.Log("���� : "+ age.ToString());              //Debug.Log("���� : "+ age ); �� ���� ������ ������ �� ��ȯ�� ���ִ� ���� ����
        Debug.Log("Ű : "+  height.ToString());            //Debug.Log("Ű : " + height ); �� ���� ������ ������ ���� ��ȯ�� ���ִ� ���� ����
        Debug.Log("�����ΰ�? : " + isFemale.ToString());  //Debug.Log("�����ΰ�? : " + isFemale ); �� ���� ������ ������ ���� ��ȯ�� ���ִ� ���� ����
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
