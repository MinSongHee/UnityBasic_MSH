using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    /*
    // 1. string.Empty
    // string 변수의 값을 초기화 합니다.
    string star;
    star = string.Empty;

    // 2. 별, 빈칸, 줄바꿈 추가하기
    // Debug.Log를 사용하여 콘솔창에 출력합니다
    star += "★"; // 별
    star += "　"; // 빈칸
    star += "\n"; // 줄바꿈
    
    // 3. Debug.Log("");
    // Debug.Log를 사용하여 콘솔창에 출력합니다
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
        //F5 : 디버깅 시작 종료
        //F9: 중단점(코드 확인할 부분 찍기)
        //F10: 한줄씩 코드 진행
        // 페이즈 1
        for (int i = 1; i < 6; i++)  //별을 찍는 것을 줄바꿈 반복
        {
            //1 번째 줄 j < 1
            //2 번째 줄 j < 2
            //3 번째 줄 j < 3
            //i 번째 줄 j < i
            for (int j = 0; j < i; j++)  //별을 그리는 것을 반복
            {
                star += "★";
            }
            star += "\n";
        }
        

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int k = 1; k < 6; k++)  //별을 찍는 것을 줄바꿈 반복
        {

            // 5 -> 4 -> 3 -> 2 까지 돈다 //4번 반복
            // 1( m > k : 1 > 1 )-> 거짓 False
            for (int m = 5; m > k; m--) 
            {
                star += "　"; // 빈칸
            }

            //별
            // l = 0 , k = 1
            // 0 : 0 < 1 -> 별
            // 1 : 1 < 1 -> 거짓
            for (int l = 0; l < k; l++)  //별을 그리는 것을 반복
            {
                star += "★"; //별 넣기
            }
            
            star += "\n"; //줄바꿈
        
        }


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        /*
        ★
        ★★
        ★★★
        ★★★★
        ★★★★★
        ★★★★
        ★★★
        ★★
        ★
        */
        // 페이즈 1이 끝난 다음 바로 페이즈 2를 출력한다 -> 페이즈 1 + 페이즈 2 인 것처럼 보이게
        // 페이즈 1
        for (int i = 1; i < 6; i++)  //별을 찍는 것을 줄바꿈 반복
        {
            //1 번째 줄 j < 1
            //2 번째 줄 j < 2
            //3 번째 줄 j < 3
            //i 번째 줄 j < i
            for (int j = 0; j < i; j++)  //별을 그리는 것을 반복
            {
                star += "★";
            }
            star += "\n"; // 줄바꿈
        }

        //페이즈 2 모양 좌우로 뒤집기
        for (int i = 4; i >= 1; i--)  //별을 찍는 것을 줄바꿈 반복
        {

            // 4 -> 3 -> 2 -> 1 까지 돈다 //4번 반복
            // 0( m > k : 0 >= 1 )-> 거짓 False
            /*
            ★★★★
            ★★★
            ★★
            ★
            */

            //별
            // l = 0 , k = 1
            // 0 : 0 < 1 -> 별
            // 1 : 1 < 1 -> 거짓
            for (int j = 0; j < i; j++)  //별을 그리는 것을 반복
            {
                star += "★"; // 별 더하기
            }
            star += "\n"; // 줄바꿈

        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5


        Debug.Log(star);
    }

    /*
    // Update is called once per frame
    void Update()
    {

    }
    */
}
