
using UnityEngine;

using UnityEngine.UI;
public class gamemanager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject playbutton;
    public GameObject GameOver;
    public player player;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void play() 
    {
        score = 0;
        scoreText.text = score.ToString();

        playbutton.SetActive(false);
        GameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void gameover()
    {
        GameOver.SetActive(true);
        playbutton.SetActive(true);
        Pause();
    }

    public void increasesore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
