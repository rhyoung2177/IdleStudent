using UnityEngine;

public class OutGameManager : MonoBehaviour
{
    public float Coin = 0f;
    public float Jewel = 0f;
    public static OutGameManager instance;

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
}
