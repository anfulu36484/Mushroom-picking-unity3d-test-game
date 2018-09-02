using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameOverSwitch : MonoBehaviour
{
    public GameObject CanvasGameOver;
    public GameObject CanvasWin;

    // Use this for initialization

    void Awake()
    {
        CanvasWin.SetActive(false);
        CanvasGameOver.SetActive(false);
    }


    void Start () {
        wolfAttack.FoxIsDead += WolfAttack_FoxIsDead;
        MushroomsManager.MushroomsCollected += MushroomsManager_MushroomsCollected;
    }

    private bool Iswin = false;

    private void MushroomsManager_MushroomsCollected(object sender, System.EventArgs e)
    {
        FirstPersonController.Stop = true;
        CanvasWin.SetActive(true);
        Iswin = true;
    }

    private void WolfAttack_FoxIsDead(object sender, System.EventArgs e)
    {
        if (Iswin == false)
        {
            FirstPersonController.Stop = true;
            CanvasGameOver.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
