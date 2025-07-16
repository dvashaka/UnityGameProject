using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOut : MonoBehaviour
{
    public float fallLimit = -10f;

    void Update()
    {
        if (transform.position.y < fallLimit)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
