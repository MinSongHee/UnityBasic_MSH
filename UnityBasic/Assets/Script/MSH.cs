using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSH : MonoBehaviour
{
    //�� �̸� �˸�
    private string Name = "MSH";
    //�� ����
    private int Age = 30;
    //�� Ű
    private float Height = 156.3f;
    //�� MBTI
    private string MBTI = "INFP";

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(Name, Age, Height, MBTI);
    }

    public void SelfIntroduction()
    {
        Debug.Log("���� �̸��� " + Name + " �Դϴ�.");
        Debug.Log($"�� ���̴� {Age}�� �Դϴ�.");
        Debug.Log($"�� Ű�� {Height}cm �Դϴ�.");
        Debug.Log("�� MBTI�� " + MBTI + " �Դϴ�.");
    }

    public void SelfIntroduction(string _Name, int _Age, float _Height, string _MBTI)
    {
        Debug.Log("���� �̸��� " + _Name + " �Դϴ�.");
        Debug.Log($"�� ���̴� {_Age}�� �Դϴ�.");
        Debug.Log($"�� Ű�� {_Height}cm �Դϴ�.");
        Debug.Log("�� MBTI�� " + _MBTI + " �Դϴ�.");
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
