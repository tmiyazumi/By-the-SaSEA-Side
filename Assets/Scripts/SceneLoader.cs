using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        Scene islandScene = SceneManager.GetSceneByName("MainIslandScene");
        SceneManager.LoadScene(1, LoadSceneMode.Additive);

        SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainIslandScene"));
    }
}
