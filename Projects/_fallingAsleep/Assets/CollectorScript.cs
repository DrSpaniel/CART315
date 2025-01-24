using UnityEngine;

public class CollectorScript : MonoBehaviour
{

    public float xLoc, yLoc, speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xLoc = 0;
        yLoc = 0;
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)){
            Debug.Log("Left!");
            xLoc -= speed;
        }
        if (Input.GetKey(KeyCode.X)){
            Debug.Log("Right!");
            xLoc += speed;
        }
        this.transform.position = new Vector3(xLoc, yLoc, 0);
    }
    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "circle"){
            Destroy(other.gameObject);
        }

    }
}
