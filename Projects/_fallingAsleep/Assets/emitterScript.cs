using System.Collections;
using UnityEngine;

public class emitterScript : MonoBehaviour
{
    public GameObject circle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Drop());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Drop(){
        //stuff todo
        float chance = Random.Range(0,100);
        if (chance < 50){
            //do something good
        }
        else{
            //bad!!!!
        }

        Debug.Log("drop!");
        float rX = Random.Range(-6f, 6f);
        Vector3 loc = new Vector3(rX, 6, 0);
        Instantiate(circle, loc, transform.rotation);
        float next = Random.Range(0.25f, 1.5f);

        yield return new WaitForSeconds(next);

        StartCoroutine(routine:Drop());
    }
}
