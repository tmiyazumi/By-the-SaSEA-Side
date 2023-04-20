using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Tele : MonoBehaviour
{
    public Transform user;
    public Transform teleLoc;

    // Update is called once per frame
    public void teloporting()
    {
        user.transform.position = teleLoc.transform.position;
    }
}
