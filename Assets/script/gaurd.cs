using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaurd : MonoBehaviour
{
    // Start is called before the first frame update
   // public Transform placeholder;
    public float speed;
    public float min, max;
    bool neednewpoint = true;
    Vector3 nextwaypoint;

    private void Update()
    {
        if (neednewpoint == true)
        {
            Debug.Log("calling function movement");
            nextwaypoint=genratenewpoint();
            StartCoroutine (walking(nextwaypoint));
            neednewpoint = false;

        }
        if (transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }

   

    IEnumerator walking(Vector3 waypoints)
    {
        while (transform.position != waypoints)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints, speed*Time.deltaTime);
            // yield return new WaitForSeconds(Time.deltaTime);
            Debug.Log("moving");
            yield return new WaitForSeconds(Time.deltaTime);
        }
        neednewpoint = true;
        yield return null; 
    }

    private Vector3 genratenewpoint()
    {
        Vector3 v1= transform.position + new Vector3(Random.Range(min, max), 0f, Random.Range(min, max));
        Debug.Log(v1);
        return   v1;
    }
    
}
