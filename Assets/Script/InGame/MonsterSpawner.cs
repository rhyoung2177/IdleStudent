using System;
using UnityEngine;
using UniRx;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] private Monster dummyMonster;

    // Start is called before the first frame update
    void Start()
    {
        SpawnMonster();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMonster()
    {
        Observable.Timer(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(2)).Subscribe(x =>
        {
            Instantiate(dummyMonster, transform);
            InGameManager.instance.SpawnMonster(dummyMonster);
        });
    }
}
