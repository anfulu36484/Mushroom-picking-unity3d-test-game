using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MushroomsManager : MonoBehaviour
{
    private Text _counter;

    private Text text;

    private int countMax = 20;
    private int count;

    void Awake()
    {
        MushroomDestroy.DestruyMusroom += MushroomDestroy_DestruyMusroom;
        text = GameObject.Find("TextCountOfMushrums").GetComponent<Text>();
    }

    private void MushroomDestroy_DestruyMusroom(object sender, System.EventArgs e)
    {
        count++;

    }

    public static event EventHandler MushroomsCollected;

    // Use this for initialization
    void Start ()
	{
	     

	}
	



	// Update is called once per frame
	void Update ()
	{
	    if (count == countMax)
	    {
	        MushroomsCollected(this, null);
	    }
	    text.text = count + " / " + countMax;
	}
}
