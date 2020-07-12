using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

public class ground : MonoBehaviour
   
{
    public List<GameObject> prefab = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;


    // Start is called before the first frame update
    void Start()
    {
        prefab.Add(Prefab1);
        prefab.Add(Prefab2);
        prefab.Add(Prefab3);
       // prefab.Add(Prefab4);
        genrate_terrain(); 
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z + 300 < GameObject.Find("player").transform.position.z)
        {
            Delete();
            Debug.Log("tile 5 shd be deleted");

        }
    }

    private void Delete()
    {
      if(GameObject.FindWithTag("tile").transform.position.z < GameObject.Find("player").transform.position.z)
        Debug.Log("distroyer is here");
        Destroy(GameObject.FindWithTag("tile"));
        
        

    }

    private void genrate_terrain()
    {
        GameObject go;
        Vector3 v;
        for ( float i= -13; i<13; i++)
        {

            go = getObject();
            v = getlocation(i*20 +(this.transform.position.z));
            Instantiate(go, v, Quaternion.Euler(0, 0, 0));
            go = getObject();
           
        }

    }

    public GameObject getObject()
    {
        return prefab[Random.Range(0,3)];

        
    }

    private Vector3 getlocation(float i)
    {
        Vector3 v1 = new Vector3();
        v1.Set(Random.Range(-50, 50), .8f, i);
        

        return v1;
    }
}
