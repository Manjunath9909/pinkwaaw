using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public Rigidbody chestLid;
    public BoxCollider mainBoxCollider;
    public bool closed = true;
    public Vector3 lidOpenForce;

    public void Update()
    {
        if (Input.GetButtonDown("X"))
        {
            openChest();
        }
    }

    public void openChest()
    {
        if (closed)
        {
            chestLid.AddForce(lidOpenForce);
            closed = false;
            print("opening chest");
        }

        else
        {
            print("Chest is already open, fuck off");
        }
    }
}
