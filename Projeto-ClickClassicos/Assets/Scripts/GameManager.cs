using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public ControllerPlayers player;
    public Ball ball;

    public int scorePlayerOne;
    public int scorePlayerTwo;

    public int scoreMachineOne;
    public int scoreMachineTwo;

    public Text TextPlayerWin;

    public Text textScore;

    public AudioSource soundGoal;

    public Transform screenWin;

    public Transform pauseMenu;

    void Start()
    {
        CleanScore();
        Cursor.visible = false;
        ball = GameObject.FindObjectOfType<Ball>();
    }

    void Update()
    {
        PlayerWin();
    }
    private void PlayerWin()
    {

        if (scorePlayerTwo == 30)
        {
            TextPlayerWin.text = "Jogador um ganhou!";
            screenWin.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        if (scorePlayerOne == 30)
        {
            TextPlayerWin.text = "Jogador dois ganhou!";
            screenWin.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
   
    public void UpSocorePlayerOne()
    {
        scorePlayerOne += 1;
        scoreMachineOne += 1;
        UpdateScore();
    }
    public void UpSocorePlayerTwor()
    {
        scorePlayerTwo += 1;
        scoreMachineTwo += 1;
        UpdateScore();
    }

    public void UpdateScore() 
    {
        textScore.text = scorePlayerTwo + " X " +  scorePlayerOne;
        soundGoal.Play();
    }
    
    public void ResumeGame()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    private void CleanScore()
    {
        scorePlayerOne = 0;
        scorePlayerTwo = 0;
        textScore.text = scorePlayerOne + " X " + scorePlayerTwo;

    }

    public void UpDifficulty()
    {
        if (scorePlayerOne >= 5 || scorePlayerTwo >= 5)
        {



            if (scoreMachineOne >= 5) 
            {
                FindObjectsOfType<ControllerPlayers>().First(player => player.playerOne).ScaleObjectPlayer(0.25F);
                scoreMachineOne = 0;
                ball.MooveBall(10F + Random.Range(0, 2));


            }


            if (scoreMachineTwo>= 5) 
            {
                FindObjectsOfType<ControllerPlayers>().First(player => !player.playerOne).ScaleObjectPlayer(0.25F);
                scoreMachineTwo = 0;
                ball.MooveBall(10F + Random.Range(0, 2));

            }

        }
    }    
}


