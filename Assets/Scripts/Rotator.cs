using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float degreesPerSecond = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(degreesPerSecond * Time.deltaTime, 0, 0);
    }
}