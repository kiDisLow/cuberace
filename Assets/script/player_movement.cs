using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class player_movement : MonoBehaviour

{

    public Rigidbody player;
    public GameObject flyer1;
    public GameObject flyer2; 
    public GameObject flyer3;
    public float minvelocity;
    public float maxvelocity;
    public float movesensitivity;
    public Vector3 v2;
    
    public float t1=1;
    

    public List<GameObject> flyer = new List<GameObject>(); 
    

    // Start is called before the first frame update
    void Start()
    {
        player.useGravity = true;
      
       
        


    }

    // Update is called once per frame
    void Update()
    {
      

        t1 = t1 - Time.deltaTime;
        if(t1 < 0)
        { 
           // Getflyer();
            t1 = .45f;
        }

        if (player.velocity.z < minvelocity)
        {

            player.AddForce(0, 0, 20);
        }
        

        if (Input.GetKey("a"))
        {
            player.AddForce(-1*movesensitivity, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            player.AddForce(movesensitivity, 0, 0);
        }

        if (player.velocity.z > maxvelocity)
        {
            player.AddForce(0, 0, -20);
        }
    }

   public void Getflyer()
    {
        
        GameObject go;
        go = flyer[Random.Range(0, 3)];
        Vector3 v = player.transform.position + v2;
        Instantiate(go, v, Quaternion.Euler(10, 45, 20));
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.Equals(flyer1)  )
            {
           Debug.Log("we have detected colision");
        }
    }
}
