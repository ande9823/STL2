using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    // Variables to hold the previous scene's name and the main menu scene's name
    private string currentSceneName;
    public GameObject arFilters;
    private bool filtersIsON = false;

    private void Start()
    {
        // Set the previous scene's name to the main menu scene
        currentSceneName = SceneManager.GetActiveScene().name.ToString();
    }

    private void Update()
    {
        switch (currentSceneName) {
            case "ARPage":
                if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                    GoToScene("VictimPage");
                } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                    GoToScene("SuspectPage");
                } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
                    GoToScene("MapPage");
                } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                    //GoToScene("FilterPage");
                    if (!filtersIsON) {
                        arFilters.SetActive(true);
                        filtersIsON = true;
                    } else if (filtersIsON) {
                        arFilters.SetActive(false);
                        filtersIsON = false;
                    }
                }
                break;
            case "VictimPage":
                if (Input.GetKeyDown(KeyCode.RightArrow)) {
                    GoToScene("ARPage");
                }
                break;
            case "SuspectPage":
                if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                    GoToScene("ARPage");
                }
                break;
            case "MapPage":
                if (Input.GetKeyDown(KeyCode.DownArrow)) {
                    GoToScene("ARPage");
                }
                break;
            case "FilterPage":
                if (Input.GetKeyDown(KeyCode.UpArrow)) {
                    GoToScene("ARPage");
                }
                break;
        }
    }

    // Function to change scenes and update the previous scene name
    void GoToScene(string sceneName)
    {
        // Set the current scene to the new scene
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        currentSceneName = SceneManager.GetActiveScene().name.ToString();
    }
}