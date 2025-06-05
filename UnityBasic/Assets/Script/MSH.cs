using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSH : MonoBehaviour
{
    //내 이름 알림
    private string Name = "MSH";
    //내 나이
    private int Age = 30;
    //내 키
    private float Height = 156.3f;
    //내 MBTI
    private string MBTI = "INFP";

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(Name, Age, Height, MBTI);
    }

    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은 " + Name + " 입니다.");
        Debug.Log($"제 나이는 {Age}살 입니다.");
        Debug.Log($"제 키는 {Height}cm 입니다.");
        Debug.Log("제 MBTI는 " + MBTI + " 입니다.");
    }

    public void SelfIntroduction(string _Name, int _Age, float _Height, string _MBTI)
    {
        Debug.Log("저의 이름은 " + _Name + " 입니다.");
        Debug.Log($"제 나이는 {_Age}살 입니다.");
        Debug.Log($"제 키는 {_Height}cm 입니다.");
        Debug.Log("제 MBTI는 " + _MBTI + " 입니다.");
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
