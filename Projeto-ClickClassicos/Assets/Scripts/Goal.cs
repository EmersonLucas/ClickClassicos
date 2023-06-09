using UnityEngine;

public class Goal : MonoBehaviour
{

    public bool goalPlayerOne;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (goalPlayerOne) 
        {
            FindAnyObjectByType<GameManager>().UpSocorePlayerOne();
            collision.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            FindAnyObjectByType<GameManager>().UpSocorePlayerTwor();
            collision.gameObject.transform.position = Vector2.zero;

        }
        
        FindAnyObjectByType<GameManager>().UpDifficulty();

    }

}
