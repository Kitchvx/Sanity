using UnityEngine;

public class bgScroll : MonoBehaviour
{
    [Range(-4f,4f)]
    public float Speed = 4f; // tells the transform how fast to move the background
    private Vector3 StartPos; // sets the start position

    void Start()
    {
        StartPos = transform.position; // defines the start position
    }

    void Update()
    {
        transform.Translate(translation:Vector3.left*Speed*Time.deltaTime); // This will scroll the background to the left at the specified speed
        if (transform.position.x < 10.23f) // when the image reaches this position on the x axis it will reset
        {
            transform.position = StartPos;
        }
    }
}

