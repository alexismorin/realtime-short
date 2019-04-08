using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesOnGameStart : MonoBehaviour {

    public string[] scenesToLoad;

    void Start () {
        foreach (string sceneName in scenesToLoad) {
            SceneManager.LoadScene (sceneName, LoadSceneMode.Additive);
        }
    }

}