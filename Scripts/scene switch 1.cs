using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch1 : MonoBehaviour
{
    public void opencamera()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
