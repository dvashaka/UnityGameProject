using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{

    public void OnStartClick()
    {
        SceneManager.LoadScene("LeveLs");
    }

    public void OnLevel1Click()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnBackClick()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void OnTutorialClick()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game is exiting...");
    }
}