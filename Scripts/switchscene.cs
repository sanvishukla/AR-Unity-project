using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    public void opencamera()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
