using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{

    float screnWidth, screenHeight;

    private void Start()
    {
        screnWidth = Screen.width;
        screenHeight = Screen.height;
    }

    public void LoadFirstQ()
    {
        SceneManager.LoadScene("1");
    }
    public void LoadSecondQ()
    {
        SceneManager.LoadScene("2");
    }
    public void LoadThirdQ()
    {
        SceneManager.LoadScene("3");
    }
    public void LoadFourthQ()
    {
        SceneManager.LoadScene("4");
    }
    private void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
