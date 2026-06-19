using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class inventorytests : MonoBehaviour
{
    [Header("DISABLE THIS ITEM WHEN BUILDING FOR PRODUCTION")]
    public GameObject player;
    public PlayerControls testsController;
    private InputAction addItem;
    private InputAction removeitem;
    private playerInventory pinv;
    private System.Random random;
    void Awake()
    {
        testsController = new PlayerControls();
    }

    void Start()
    {
        pinv = player.GetComponent<playerInventory>();
        random = new System.Random();
    }

    private void OnEnable()
    {
        addItem = testsController.tests.additem;
        addItem.Enable();

        removeitem = testsController.tests.removeitem;
        removeitem.Enable();
    }

    private void OnDisable()
    {
        addItem.Disable();
        removeitem.Disable();
    }
    void Update()
    {
        if (addItem.WasPressedThisFrame())
        {
            //do addding an item schinigans
            pinv.addItem("hello", 1);
        }

        if (removeitem.WasPressedThisFrame())
        {
            //do remove item stuff
            pinv.removeItem("hello", 1);
        }
    }
}
