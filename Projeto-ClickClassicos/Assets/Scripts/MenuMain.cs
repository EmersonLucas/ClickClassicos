using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{


  
    public void Exit()
    {
    #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
            Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
    #endif
    #if (UNITY_EDITOR)
            UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE)
        Application.Quit();
#elif (UNITY_WEBGL)
        Application.Quit();
        Application.OpenURL("clickclassicos.com");
#endif
    }

    public void Pong()
    {
        SceneManager.LoadScene("Pong");
    }
    public void Tetris()
    {
        SceneManager.LoadScene("Tetris");
    }
}
