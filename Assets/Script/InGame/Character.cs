using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class Character : MonoBehaviour
{
    public float atk = 150f;
    public float def;
    public float atkSpeed;
    public float critical;


    // Start is called before the first frame update
    void Start()
    {
        var animator = GetComponent<Animator>();
        animator.SetBool("Idle", false);
        animator.Play("Run");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack(Monster monster)
    {
        Observable.Timer(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(1)).Subscribe(x =>
        {
            Debug.Log($"Monster Hit : {atk}");
            monster.Hit(atk);
        });
    }
}
