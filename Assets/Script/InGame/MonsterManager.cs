using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    private bool isStop = false;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStop)
            transform.Translate(-0.01f, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "stoptrigger")
            isStop = true;
    }
}
