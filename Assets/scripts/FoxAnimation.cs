using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
    }





    // Update is called once per frame
    void Update () {
   
            if (Input.GetKey(KeyCode.RightArrow)
                || Input.GetKey(KeyCode.LeftArrow)
                || Input.GetKey(KeyCode.UpArrow)
                || Input.GetKey(KeyCode.DownArrow) 
                )
            {
                if (!Input.GetKey(KeyCode.Space))
                {
                    GetComponent<Animator>().SetBool("isRun", true);
                }
            }

            if (!(Input.GetKey(KeyCode.RightArrow)
                  || Input.GetKey(KeyCode.LeftArrow)
                  || Input.GetKey(KeyCode.UpArrow)
                  || Input.GetKey(KeyCode.DownArrow)))
            {
                GetComponent<Animator>().SetBool("isRun", false);
            }
        

    }
}
