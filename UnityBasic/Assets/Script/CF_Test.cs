using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CF_Test : MonoBehaviour
{
    List<string> List = new List<string>();

    // Start is called before the first frame update
    //호범님의 꿀팁 가져오기
    /*void Start()
    {
        List.Add("ddd");
    }*/

    private List<string> SSRCharacterList;
    private void Start() // 리스트 초기화
    {
        List.Add("ddd");
        SSRCharacterList = new List<string>();
        SSRCharacterList.Add("레드후드");
        SSRCharacterList.Add("홍련");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
