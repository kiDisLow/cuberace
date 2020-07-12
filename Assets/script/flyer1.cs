using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class flyer1 : MonoBehaviour
{
    public Rigidbody cube;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      player= GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {

      cube.MoveRotation(player.transform.rotation);
        
    }
}
