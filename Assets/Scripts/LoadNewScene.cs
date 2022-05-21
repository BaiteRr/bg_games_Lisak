using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNewScene : MonoBehaviour
{
    private void Update()
    {
        if (DestrpyPlayer.isDestroy)
        {
            StartCoroutine(newScene());
            DestrpyPlayer.isDestroy = false;
        }
    }

    IEnumerator newScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game1");
    }
}
