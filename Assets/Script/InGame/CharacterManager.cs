using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{

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
}
