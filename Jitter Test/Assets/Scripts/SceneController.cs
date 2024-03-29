using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        if (Application.platform == RuntimePlatform.Android) {
            Application.targetFrameRate = 60;
        } else {
            Application.targetFrameRate = -1;
        }
    }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}