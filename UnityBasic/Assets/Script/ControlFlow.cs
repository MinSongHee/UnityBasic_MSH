using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    private void Awake()
    {
        count = 0;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Gacha()
    {

        int number = 0;

        while (number < 10)
        {


            number++;
        }

        /*
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); //1�̻� 100 �̸��� ������ ���� �޾ƿ��ڴ�.(1~100)

            Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

            // count 81

            if (8 <= count)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10) // 1~10 -> 10% �� Ȯ�� (1~10)
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 11~30
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾Ҵ�!");
            }

            count++;
        
        }
        */

        //���� Range ����ϱ�
        //Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        //Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        //������ 70% Ȯ���� 'ġġ'�� �̾Ҵ�!

        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); //1�̻� 100 �̸��� ������ ���� �޾ƿ��ڴ�.(1~100)

            Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

            // count 81

            if (8 <= count)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10) // 1~10 -> 10% �� Ȯ�� (1~10)
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 11~30
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'ġġ'�� �̾Ҵ�!");
            }

            count++;

        }
        
    }

    public int selectNumbe = 5;

    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        //int selectNumbe = 0;

        switch (selectNumbe) //0?
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        // �Ⱦ� ĳ�� : �̹� �̱⿡ Ȯ���� ����  �����Ǵ� ĳ����
                        // �������� Ư�� ĳ���͸� ��ǥ�ϰ� �̰� ����� �ý���
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 2:
                // ��ȫ �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'��ȫ �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            default:
                // �Ķ� �Ӹ� ���� ĳ���Ͱ� ���´�.
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ� ����'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }

}
