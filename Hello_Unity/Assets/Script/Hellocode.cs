using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellocode : MonoBehaviour
{   
       public string CharacterName = "라라";             //문자열 변수 선언(string)
       public char bloodtype = 'A';                      //문자 변수 선언(char)
       public int age = 17;                              //정수 변수 선언(int)
       public float height = 160.8f;                     //실수 변수 선언(float)
       public bool isFemale = true;                      //참 거짓을 판별하는 변수 선언(bool)
    void Start()
    {   
        Debug.Log("케릭터 이름 : " + CharacterName);        //케릭터 이름 : 라라
        Debug.Log("혈액형 : " +  bloodtype);             //혈액형 : A
        Debug.Log("나이 : "+ age.ToString());              //Debug.Log("나이 : "+ age ); 와 같은 동작을 하지만 형 변환을 해주는 것이 좋다
        Debug.Log("키 : "+  height.ToString());            //Debug.Log("키 : " + height ); 와 같은 동작을 하지만 형을 변환을 해주는 것이 좋다
        Debug.Log("여성인가? : " + isFemale.ToString());  //Debug.Log("여성인가? : " + isFemale ); 와 같은 동작을 하지만 형을 변환을 해주는 것이 좋다
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
