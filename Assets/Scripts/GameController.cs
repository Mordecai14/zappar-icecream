using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public GameObject startButton;
    public GameObject spawner;
    public int score = 0;
    [SerializeField]
    private float timer;
    public bool isPlaying = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            scoreText.text = score.ToString();
        if (isPlaying & timer > 0)
        {
            timer -= Time.deltaTime;
            DisplayTime(timer);
        }
        else if (isPlaying & timer <= 0)
        {
            isPlaying = false;
            spawner.SetActive(false);
            //spawner2.SetActive(false);
            StartCoroutine(Finish());
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void StartGame()
    {
        isPlaying = true;
        startButton.SetActive(false);
        spawner.SetActive(true);
        timeText.text = "00:0" + timer.ToString();
    }
    public void Restart(){
        SceneManager.LoadScene(0);
    }

    private IEnumerator Finish()
    {
        yield return new WaitForSeconds(0.8f);
        print("finish");
    }
}
