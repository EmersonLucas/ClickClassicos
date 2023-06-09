using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public  Toggle musicOn;
    public  AudioSource Music;
    //public  AudioSource musicGame;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Awake()
    {


    }

    // Update is called once per frame
    void Update()
    {
       

        if (Holder.Instance.MusicOn)
        
        {
            if (!Music.isPlaying) 
            {
               Music.Play();
               Music.volume = 0.2F;
              
            }        
        }
        else
        {
            Music.Stop();
        }
    }

    public void ToggleValueChanged(Toggle change)
    {
        if (musicOn.isOn) Holder.Instance.MusicOn = true;
        else Holder.Instance.MusicOn = false;
    }
}
