using UnityEngine;

public class Monster : MonoBehaviour
{
    private bool isStop = false;
    public float hp = 500;
    [SerializeField] private Transform hpBar;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.localScale = new Vector3((hp / 500f) * 0.3f, 0.1f, 0);

        if (!isStop)
            transform.Translate(-0.01f, 0, 0);

        if (hp <= 0)
        {
            InGameManager.instance.KillMonster(this);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "stoptrigger")
            isStop = true;
    }

    public void Hit(float damage)
    {
        hp -= damage;
    }
}
