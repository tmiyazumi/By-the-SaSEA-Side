using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material skyToChange;
    // Start is called before the first frame update
    
    public void loadSkybox()
    {
        RenderSettings.skybox = skyToChange;
        DynamicGI.UpdateEnvironment();
    }
}
