
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Test : MonoBehaviour
{
    //컨트롤+k+d 는 줄 맞춤
    // Start is called before the first frame update
    /* 여러 줄을 주석처리할 때 사용 */




    /*
    void Start()
    {
        Debug.Log("나의 레벨은 " + playerLevel + "입니다.");
        Debug.Log($"나의 레벨은 {playerLevel}입니다.");
    }
    */

    /*
    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }
    */

    /*
    void Awake()
    {
        UnityEngine.Debug.Log("최초 한 번만 실행됩니다.");
    }

    void OnEnable()
    {
        UnityEngine.Debug.Log("활성화 될 때 실행됩니다.");
    }

    void Start()
    {
        UnityEngine.Debug.Log("한 번만 실행됩니다.");
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("매 프레임마다 여러번 실행됩니다.");

    }
    */
}

/*

public class Player
{
    private int playerLevel = 10;

    public int Level()
    {
        return playerLevel;
    }
}

public class Monster
{
    private int monsterLevel;

    public void SetLevel(int _playerLevel)
    {
        monsterLevel = _playerLevel;
    }
}

public class Game
{
    Player A;
    Monster B;

    void MonsterSpawn() // 몬스터
    {
        B.SetLevel(A.Level());
    }
}

*/