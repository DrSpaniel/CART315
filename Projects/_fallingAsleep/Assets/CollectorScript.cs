using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    public float xLoc, yLoc, speed;

    void Start()
    {
        xLoc = 0;
        yLoc = 0;
        speed = 0.1f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Left!");
            xLoc -= speed;
        }
        if (Input.GetKey(KeyCode.X))
        {
            Debug.Log("Right!");
            xLoc += speed;
        }
        transform.position = new Vector3(xLoc, yLoc, 0); // Remove "this"
    }

    // Remove the OnCollisionEnter2D method entirely!
}