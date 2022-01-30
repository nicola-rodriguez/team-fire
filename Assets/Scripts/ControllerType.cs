using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerType : MonoBehaviour
{
    public void PlayMouseGame()
    {
        SceneManager.LoadScene("SandboxCoding");
    }

    public void PlayVRGame()
    {
        SceneManager.LoadScene("XRGameScene");
    }
}
