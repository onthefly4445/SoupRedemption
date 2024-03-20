using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableObject : MonoBehaviour
{
    public string objectName;
    public Vector2 nameTagSize;
    public string sceneToLoad = "";

    public void changeScence() {
        if (sceneToLoad != "") {
            SceneManager.LoadSceneAsync(sceneToLoad); 
        }
    }

}