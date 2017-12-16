using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour {

    public bool go;

    public GameObject perspCamera;
    public GameObject orthoCamera;


    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void go_()
    {
        go = true;
    }

    public void switch_orthoCamera()
    {
        perspCamera.SetActive(false);
        orthoCamera.SetActive(true);
    }
    public void switch_perspCamera()
    {
        perspCamera.SetActive(true);
        orthoCamera.SetActive(false);
    }
}
