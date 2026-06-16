using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerLook : MonoBehaviour
{
    public PlayerControls lookController;
    private InputAction look;
    private InputAction interact;
    public float mouseSense = 100f;
    public Transform playerBody;
    public LayerMask interactableLayerMask;
    public TextMeshProUGUI promptText;
    public Image promptImage;
    private float upDownRot = 0f;
    private void Awake()
    {
        lookController = new PlayerControls();
    }
    private void OnEnable()
    {
        look = lookController.movementAndInteractions.Look;
        look.Enable();

        interact = lookController.movementAndInteractions.Interact;
        interact.Enable();
    }

    private void OnDisable()
    {
        look.Disable();
        interact.Disable();
    }

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //promptImage.enabled = false;
    }

    void Update()
    {
        float mouseX = look.ReadValue<Vector2>().x * mouseSense * Time.deltaTime;
        float mouseY = look.ReadValue<Vector2>().y * mouseSense * Time.deltaTime;
        upDownRot -= mouseY;
        upDownRot = Math.Clamp(upDownRot, -90f, 90f);
        playerBody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(upDownRot, 0f, 0f);
    }

    // handling interaction detection here
    /*void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2.0f, interactableLayerMask))
        {
            //assuming item type for now
            handleItemDetection(hit);
            if (interact.IsPressed())
            {
                handleInteraction(hit);
            }
        }
        else
        {
            promptText.text = " ";
            promptImage.enabled = false;
        }
    }*/
}

/*    public void handleItemDetection(RaycastHit hit)
    {
        promptText.text = hit.transform.GetComponent<interactable>().prompt;
        promptImage.enabled = true;
    }

    public void handleInteraction(RaycastHit hit)
    {
        if (!hit.transform.GetComponent<interactable>().interactedWith)
        {
            //handle itemCollection
            if (hit.transform.GetComponent<interactable>().interactionType == 1)
            {
                hit.transform.GetComponent<interactable>().interactedWith = true;
                gameObject.GetComponentInParent<masterObjectMediator>().masterObject.GetComponent<managerScript>().collectItem(hit.transform.GetComponent<itemScript>());
            }
            else if (hit.transform.GetComponent<interactable>().interactionType == 2)
            {
                hit.transform.GetComponent<interactable>().interactedWith = true;
            }
        }
    }
}*/
