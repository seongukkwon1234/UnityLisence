using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ù �Լ� ȣ��");
        Debug.Log("������Ʈ �̸� Ȯ�� : " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("�� ������ ����");
    }
}
