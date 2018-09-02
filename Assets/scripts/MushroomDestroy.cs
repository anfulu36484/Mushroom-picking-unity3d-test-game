using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject TargetObject;

    /*void OnCollisionEnter(Collision otherObj)
    {
        
        if (otherObj.gameObject.name ==TargetObject.name)
        {
            Destroy(gameObject);
        }
    }*/

    public static event EventHandler DestruyMusroom;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == TargetObject.name)
        {
            Destroy(gameObject);
            DestruyMusroom(this, null);
        }
        //Destroy(transform.gameObject);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
