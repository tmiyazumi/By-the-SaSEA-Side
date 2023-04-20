using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial_Teleportation : MonoBehaviour
{
    public Transform user;
    public Transform teleLoc;

    // Update is called once per frame
    public void teloport()
    {
        user.transform.position = teleLoc.transform.position;
    }
}