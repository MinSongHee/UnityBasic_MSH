using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CF_Test : MonoBehaviour
{
    List<string> List = new List<string>();

    // Start is called before the first frame update
    //ȣ������ ���� ��������
    /*void Start()
    {
        List.Add("ddd");
    }*/

    private List<string> SSRCharacterList;
    private void Start() // ����Ʈ �ʱ�ȭ
    {
        List.Add("ddd");
        SSRCharacterList = new List<string>();
        SSRCharacterList.Add("�����ĵ�");
        SSRCharacterList.Add("ȫ��");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
