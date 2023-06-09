using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerPlayers : MonoBehaviour
{
    public float speedPlayer;

    public bool playerOne;

    public float yMin;

    public float yMax;

    private bool isPause;
  
    public GameObject pauseMenu;

    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPause)
        {
            if (playerOne == true)
            {
                MoovePlayerOne();
            }
            else
            {
                MoovePlayerTwor();

            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PauseGame();
        }
    }

    private void PauseGame()
    {
       
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            Cursor.visible = false;
        }
        else
        {          
            isPause = true;
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            Cursor.visible = true;
        }
          
    }
    public void CallMenu()
    {

        SceneManager.LoadScene(scene);

    }
    private void MoovePlayerOne()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speedPlayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speedPlayer * Time.deltaTime);
        }

    }
    private void MoovePlayerTwor()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));


        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speedPlayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speedPlayer * Time.deltaTime);
        }
    }
    public void ScaleObjectPlayer(float value)
    {
        if (transform.localScale.y <= 1F) return;

        Vector3 currentScale = transform.localScale;

        transform.localScale = transform.localScale = new Vector3(currentScale.x, currentScale.y -  value, currentScale.z);

        yMax += 0.25F;
        yMin -= 0.25F;

    }
}