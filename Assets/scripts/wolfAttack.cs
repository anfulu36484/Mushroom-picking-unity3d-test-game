using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class wolfAttack : MonoBehaviour {


    public GameObject fpsController;


    public static event EventHandler FoxIsDead;

    void OnTriggerEnter(Collider other)
    {
     

        if (other.gameObject.name == fpsController.name || other.gameObject.name == "TailedFox")
        {
            GameObject.Find("TailedFox").GetComponent<Animator>().SetBool("isDie", true);
            FoxIsDead(this, null);
        }
    }

    // Use this for initialization
    void Start () {
    

	}

   



    // Update is called once per frame
    void Update () {
		
	}
}
