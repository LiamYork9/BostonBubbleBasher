using UnityEngine;

public class MoveOverTime : MonoBehaviour
{
    public float speed = 1;
    public Vector3 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.x += speed *Time.deltaTime;
        gameObject.transform.position = pos;
    }
}
