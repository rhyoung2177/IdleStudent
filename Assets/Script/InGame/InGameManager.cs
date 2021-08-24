using System;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : MonoBehaviour
{
    [SerializeField] private Character character;
    private List<Monster> monsterList = new List<Monster>();

    public static InGameManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 몬스터가 스포너에서 생성됐을 때
    public void SpawnMonster(Monster monster)
    {
        Debug.Log("SpawnMonster");
        monsterList.Add(monster);
    }

    // 몬스터가 트리거 내에 진입했을 때
    public void InTriggerMonster(Monster monster)
    {
        Debug.Log("InTriggerMonster");
        character.Attack(monster);
    }

    // 몬스터 처치 시
    public void KillMonster(Monster monster)
    {
        Debug.Log("KillMonster");
        if (monsterList.Contains(monster))
        {
            monsterList.Remove(monster);
        }
    }
}
