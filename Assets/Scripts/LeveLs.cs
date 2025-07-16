using UnityEngine;
using UnityEngine.SceneManagement;

public class LeveLs : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
