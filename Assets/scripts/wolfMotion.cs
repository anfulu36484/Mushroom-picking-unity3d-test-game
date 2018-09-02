using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfMotion : MonoBehaviour
{

    public Transform FpsController;

	// Use this for initialization
	void Start () {
		
        
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Vector3.Distance(transform.position, FpsController.position) < 50
	        & Vector3.Distance(transform.position, FpsController.position) >0.5
	        & Mathf.Abs(transform.position.y- FpsController.position.y)<7)
	    {
	        transform.position = Vector3.MoveTowards(transform.position, FpsController.position, Time.deltaTime * 5);
	        transform.LookAt(FpsController);
	    }
	}
}
