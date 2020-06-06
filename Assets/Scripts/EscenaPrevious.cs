using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaPrevious : MonoBehaviour
{
    private int nextSceneToLoad;
    // Start is called before the first frame update



    public void onClickCamara()
    {

        //nextSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(0);
    }

    /*public void onClickWeb()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex - 2;
        SceneManager.LoadScene(nextSceneToLoad);
    }

    public void onClickStorage()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex - 3;
        SceneManager.LoadScene(nextSceneToLoad);
    }

    public void onClickStorage()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex - 3;
        SceneManager.LoadScene(nextSceneToLoad);
    }*/
}
