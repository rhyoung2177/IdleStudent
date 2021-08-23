using System;
using UnityEngine;
using UniRx;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject dummyMonster;

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
        Observable.Timer(TimeSpan.FromSeconds(3), Scheduler.MainThreadIgnoreTimeScale).Subscribe(x =>
        {
            Instantiate(dummyMonster, transform);
        });
    }
}
