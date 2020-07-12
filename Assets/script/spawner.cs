using System.Collections;
using System.Collections.Generic;
using UnityEditor.Android;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
 
    public GameObject mid;
    public GameObject end;
    public GameObject floore;
    public GameObject go;
    public Transform player;
    public Vector3 v1;
    public Vector3 v2 ;


    // Update is called once per frame
   // public List<GameObject> tile_floore = new List<GameObject>() ;

    private void Start()
    {

        

    }
    void Update()
    {
        if (player.transform.position.z == mid.transform.position.z)
        {

            go = Instantiate(floore, (player.position + v1), Quaternion.Euler(0, 90, 0)); 
            mid.transform.position = mid.transform.position + v2;
           // tile_floore.Add(go);
           
            
        }
       
    }
  
   
}
