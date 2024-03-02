using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch2 : MonoBehaviour
{
    public void opencamera()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
