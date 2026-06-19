using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puppeteer : MonoBehaviour
{
    public Canvas inventoryCanvas;
    public Canvas pauseCanvas;
    public Canvas playerStatusCanvas;

    public void Start()
    {
        inventoryCanvas.enabled = false;
        playerStatusCanvas.enabled = false;
        pauseCanvas.enabled = true;
    }

    public void playButtonClick()
    {
        pauseCanvas.enabled = false;
        playerStatusCanvas.enabled = true;
        inventoryCanvas.enabled = false;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void exitButtonClick()
    {

    }

    public void inventoryCloseButtonClick()
    {

    }
}
