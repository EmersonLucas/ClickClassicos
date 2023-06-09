using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseTetris : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CallMenu();
        }
    }

    public void CallMenu() 
    {
        SceneManager.LoadScene(0);
        
    } 
}
