using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 screenTwo = new Vector3(5, -2, 0);

    public Vector3 screenThree = new Vector3(5, -2, 0);
    private Vector3 startPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;

    private float elapsedTime2;

    public bool begin = false;

    public bool begin2 = false;

    [SerializeField]
    private AnimationCurve curve;

    void Start()
    {
        startPosition = transform.position;    
    }

    // Update is called once per frame
    public void Update()
    {
        if(begin == true)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / desiredDuration;
    
            transform.position = Vector3.Lerp(startPosition, screenTwo, curve.Evaluate(percentageComplete));
        }

        if(begin2 == true)
        {
            elapsedTime2 += Time.deltaTime;
            float percentageComplete = elapsedTime2 / desiredDuration;
    
            transform.position = Vector3.Lerp(screenTwo, screenThree, curve.Evaluate(percentageComplete));
        }
    }

}

