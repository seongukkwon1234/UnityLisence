using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("첫 함수 호출");
        Debug.Log("오브젝트 이름 확인 : " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("매 프레임 생성");
    }
}
