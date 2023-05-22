using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SplashScreenAsynSceneLoader : MonoBehaviour
{
    #region PUBLIC_MEMBERS
    public float loadingDelay;
    public GameObject splashScreen;
    public GameObject mainMenu;
    #endregion //PUBLIC_MEMBERS


    #region MONOBEHAVIOUR_METHODS
    void Start()
    {
        StartCoroutine(LoadNextSceneAfter(loadingDelay));
    }
    #endregion //MONOBEHAVIOUR_METHODS


    #region PRIVATE_METHODS
    private IEnumerator LoadNextSceneAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        // UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
        mainMenu.SetActive(true);
        splashScreen.SetActive(false);
    }
    #endregion //PRIVATE_METHODS
}

