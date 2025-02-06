using UnityEngine;

public class CircleBehavior : MonoBehaviour
{
    public AudioClip destructionSound; // Assign in Inspector
    public float destroyYThreshold = -1f; // Adjust to control when to destroy

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // Cache the main camera
    }

    void Update()
    {
        // Destroy the circle if it moves below the camera's view
        if (transform.position.y < mainCamera.ViewportToWorldPoint(Vector3.zero).y + destroyYThreshold)
        {
            Destroy(gameObject);
        }
    }

    // Existing collision code (optional)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collector"))
        {
            AudioSource.PlayClipAtPoint(destructionSound, transform.position);
            Destroy(gameObject);
        }
    }
}