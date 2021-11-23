using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    #region Input
    private ApplicationControls controls;

    // Awake is called before the first frame update and before Start
    private void Awake()
    {
        controls = new ApplicationControls();

        controls.General.ExitApplication.performed += ctx => ExitApplication();
        controls.General.ReloadActiveScene.performed += ctx => ReloadActiveScene();
        controls.General.NextScene.performed += ctx => NextScene();
        controls.General.PreviousScene.performed += ctx => PreviousScene();
    }

    private void OnEnable()
    {
        controls.General.Enable();
    }

    private void OnDisable()
    {
        controls.General.Disable();
    }
    #endregion

    private void ExitApplication()
    {
        Application.Quit();
    }

    private void ReloadActiveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void NextScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(index > 1 ? 1 : index);
    }

    private void PreviousScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(index < 0 ? 0 : index);
    }
}
