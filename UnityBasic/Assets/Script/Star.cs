using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    /*
    // 1. string.Empty
    // string ������ ���� �ʱ�ȭ �մϴ�.
    string star;
    star = string.Empty;

    // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    star += "��"; // ��
    star += "��"; // ��ĭ
    star += "\n"; // �ٹٲ�
    
    // 3. Debug.Log("");
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    Debug.Log(star);
    */

    // Start is called before the first frame update
    
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
        //F5 : ����� ���� ����
        //F9: �ߴ���(�ڵ� Ȯ���� �κ� ���)
        //F10: ���پ� �ڵ� ����
        // ������ 1
        for (int i = 1; i < 6; i++)  //���� ��� ���� �ٹٲ� �ݺ�
        {
            //1 ��° �� j < 1
            //2 ��° �� j < 2
            //3 ��° �� j < 3
            //i ��° �� j < i
            for (int j = 0; j < i; j++)  //���� �׸��� ���� �ݺ�
            {
                star += "��";
            }
            star += "\n";
        }
        

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2
        for (int k = 1; k < 6; k++)  //���� ��� ���� �ٹٲ� �ݺ�
        {

            // 5 -> 4 -> 3 -> 2 ���� ���� //4�� �ݺ�
            // 1( m > k : 1 > 1 )-> ���� False
            for (int m = 5; m > k; m--) 
            {
                star += "��"; // ��ĭ
            }

            //��
            // l = 0 , k = 1
            // 0 : 0 < 1 -> ��
            // 1 : 1 < 1 -> ����
            for (int l = 0; l < k; l++)  //���� �׸��� ���� �ݺ�
            {
                star += "��"; //�� �ֱ�
            }
            
            star += "\n"; //�ٹٲ�
        
        }


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3
        /*
        ��
        �ڡ�
        �ڡڡ�
        �ڡڡڡ�
        �ڡڡڡڡ�
        �ڡڡڡ�
        �ڡڡ�
        �ڡ�
        ��
        */
        // ������ 1�� ���� ���� �ٷ� ������ 2�� ����Ѵ� -> ������ 1 + ������ 2 �� ��ó�� ���̰�
        // ������ 1
        for (int i = 1; i < 6; i++)  //���� ��� ���� �ٹٲ� �ݺ�
        {
            //1 ��° �� j < 1
            //2 ��° �� j < 2
            //3 ��° �� j < 3
            //i ��° �� j < i
            for (int j = 0; j < i; j++)  //���� �׸��� ���� �ݺ�
            {
                star += "��";
            }
            star += "\n"; // �ٹٲ�
        }

        //������ 2 ��� �¿�� ������
        for (int i = 4; i >= 1; i--)  //���� ��� ���� �ٹٲ� �ݺ�
        {

            // 4 -> 3 -> 2 -> 1 ���� ���� //4�� �ݺ�
            // 0( m > k : 0 >= 1 )-> ���� False
            /*
            �ڡڡڡ�
            �ڡڡ�
            �ڡ�
            ��
            */

            //��
            // l = 0 , k = 1
            // 0 : 0 < 1 -> ��
            // 1 : 1 < 1 -> ����
            for (int j = 0; j < i; j++)  //���� �׸��� ���� �ݺ�
            {
                star += "��"; // �� ���ϱ�
            }
            star += "\n"; // �ٹٲ�

        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5


        Debug.Log(star);
    }

    /*
    // Update is called once per frame
    void Update()
    {

    }
    */
}
