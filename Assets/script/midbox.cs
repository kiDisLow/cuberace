using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midbox : MonoBehaviour
{
    public GameObject mid;
    public GameObject floore;
    public GameObject end;
   public  GameObject player;
    public Vector3 V1;
    public Vector3 v2;

    public void OnTriggerEnter(Collider colider)
    {

        if (colider.gameObject == player)
        {
           Instantiate(floore, (end.transform.position + V1), Quaternion.Euler(0, 90, 0));
            mid.transform.position = mid.transform.position + v2;
            end.transform.position = end.transform.position + v2;
            
        }
        

       
    }
}
