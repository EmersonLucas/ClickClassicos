using UnityEngine;
using UnityEngine.UI;

public class Holder : MonoBehaviour
{
  
    public static Holder Instance;
    public bool MusicOn;
    private void Awake()
    {
        
        DontDestroyOnLoad(this);
        if (Instance == null)
        {
            Camera.main.GetComponent<AudioSource>().Play();   
            MusicOn = true;
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        GameObject.Find("Canvas").transform.Find("Menu Configs").Find("Toggle Musica").GetComponent<Toggle>().isOn = MusicOn;

    }


}
