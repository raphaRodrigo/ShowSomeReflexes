using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{
    float titleSec;
    float seconds;
    float sortPosition;
    float arcadeReactionTime;

    int titleColor;
    int sortColor;
    int colorRoulette;
    int hits;
    int score;

    bool mode1;
    bool mode2;
    bool about;
    bool canRoulette;
    bool rightColor;
    bool start;
    bool playSound;

    Ray ray;
    RaycastHit2D hit;

    Color color1;
    Color color2;
    Color color3;
    Color color4;

    SoundManager soundManager;

    public GameObject titleScreenText;
    public GameObject howToPlayText;
    public GameObject aboutText;
    public GameObject pickAColor;
    public GameObject pickedColor;
    public GameObject gameOverText;

    public TextMesh scoreText;
    public TextMesh highScoreText;
    public TextMesh soundText;


    void Start()
    {
        soundManager = (SoundManager)FindObjectOfType(typeof(SoundManager));
        
        GetComponent<SpriteRenderer>().enabled = false;
        transform.position = new Vector3(0, 0, 2.45f);
        score = 0;
        GetComponent<BoxCollider2D>().enabled = true;
        titleScreenText.SetActive(true);
        howToPlayText.SetActive(false);
        aboutText.SetActive(false);
        pickAColor.SetActive(false);
        pickedColor.SetActive(false);
        scoreText.GetComponent<MeshRenderer>().enabled = false;
        gameOverText.SetActive(false);
        mode1 = false;
        mode2 = false;
        about = false;
        rightColor = false;
        canRoulette = true;
        start = false;
        playSound = false;
        soundManager.you = true;

        /*MainColor();

        canScore = false;
        if (canScore)
        {
            GetComponent<SpriteRenderer>().color = color1;
        }*/
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction, 3);

        Title();

        seconds += Time.deltaTime;

        if (!canRoulette)
        {
            if (playSound)
            {
                soundManager.GetReady();
                playSound = false;
            }
            GetComponent<SpriteRenderer>().enabled = true;
            pickAColor.SetActive(false);
            pickedColor.SetActive(true);

            sortPosition = Random.Range(0, 73);

            if (seconds > 1.1f)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                transform.position = new Vector3(0, 3, 2.45f);
                if (sortPosition == 1)
                {
                    transform.position = new Vector3(5, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 2)
                {
                    transform.position = new Vector3(4, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 3)
                {
                    transform.position = new Vector3(3, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 4)
                {
                    transform.position = new Vector3(2, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 5)
                {
                    transform.position = new Vector3(1, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 6)
                {
                    transform.position = new Vector3(0, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 7)
                {
                    transform.position = new Vector3(-1, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 8)
                {
                    transform.position = new Vector3(-2, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 9)
                {
                    transform.position = new Vector3(-3, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 10)
                {
                    transform.position = new Vector3(-4, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 11)
                {
                    transform.position = new Vector3(-5, 3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 12)
                {
                    transform.position = new Vector3(5, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 13)
                {
                    transform.position = new Vector3(4, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 14)
                {
                    transform.position = new Vector3(3, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 15)
                {
                    transform.position = new Vector3(2, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 16)
                {
                    transform.position = new Vector3(1, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 17)
                {
                    transform.position = new Vector3(0, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 18)
                {
                    transform.position = new Vector3(-1, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 19)
                {
                    transform.position = new Vector3(-2, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 20)
                {
                    transform.position = new Vector3(-3, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 21)
                {
                    transform.position = new Vector3(-4, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 22)
                {
                    transform.position = new Vector3(-5, 2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 23)
                {
                    transform.position = new Vector3(5, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 24)
                {
                    transform.position = new Vector3(4, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 25)
                {
                    transform.position = new Vector3(3, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 26)
                {
                    transform.position = new Vector3(2, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 27)
                {
                    transform.position = new Vector3(1, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 28)
                {
                    transform.position = new Vector3(0, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 29)
                {
                    transform.position = new Vector3(-1, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 30)
                {
                    transform.position = new Vector3(-2, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 31)
                {
                    transform.position = new Vector3(-3, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 32)
                {
                    transform.position = new Vector3(-4, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 33)
                {
                    transform.position = new Vector3(-5, 1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 34)
                {
                    transform.position = new Vector3(5, 0, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 35)
                {
                    transform.position = new Vector3(4, 0, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 36)
                {
                    transform.position = new Vector3(3, 0, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 37)
                {
                    transform.position = new Vector3(-3, 0, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 38)
                {
                    transform.position = new Vector3(-4, 0, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 39)
                {
                    transform.position = new Vector3(-5, 0, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 40)
                {
                    transform.position = new Vector3(5, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 41)
                {
                    transform.position = new Vector3(4, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 42)
                {
                    transform.position = new Vector3(3, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 43)
                {
                    transform.position = new Vector3(2, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 44)
                {
                    transform.position = new Vector3(1, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 45)
                {
                    transform.position = new Vector3(0, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 46)
                {
                    transform.position = new Vector3(-1, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 47)
                {
                    transform.position = new Vector3(-2, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 48)
                {
                    transform.position = new Vector3(-3, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 49)
                {
                    transform.position = new Vector3(-4, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 50)
                {
                    transform.position = new Vector3(-5, -1, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 51)
                {
                    transform.position = new Vector3(5, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 52)
                {
                    transform.position = new Vector3(4, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 53)
                {
                    transform.position = new Vector3(3, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 54)
                {
                    transform.position = new Vector3(2, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 55)
                {
                    transform.position = new Vector3(1, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 56)
                {
                    transform.position = new Vector3(0, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 57)
                {
                    transform.position = new Vector3(-1, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 58)
                {
                    transform.position = new Vector3(-2, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 59)
                {
                    transform.position = new Vector3(-3, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 60)
                {
                    transform.position = new Vector3(-4, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 61)
                {
                    transform.position = new Vector3(-5, -2, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 62)
                {
                    transform.position = new Vector3(5, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 63)
                {
                    transform.position = new Vector3(4, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 64)
                {
                    transform.position = new Vector3(3, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 65)
                {
                    transform.position = new Vector3(2, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 66)
                {
                    transform.position = new Vector3(1, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 67)
                {
                    transform.position = new Vector3(0, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 68)
                {
                    transform.position = new Vector3(-1, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 69)
                {
                    transform.position = new Vector3(-2, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 70)
                {
                    transform.position = new Vector3(-3, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 71)
                {
                    transform.position = new Vector3(-4, -3, 2.45f);
                    SortColor();
                }

                else if (sortPosition == 72)
                {
                    transform.position = new Vector3(-5, -3, 2.45f);
                    SortColor();
                }
                //===========================================================

                start = true;
                hits = 0;
                seconds = 0;
                DifficultyLevels();
            }
            //===============================================================

            if (start)
            {
                scoreText.GetComponent<MeshRenderer>().enabled = true;
                scoreText.text = "SCORE\n" + score;
                pickedColor.SetActive(false);
            }

            //===============================================================
            if (start && Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "Player" && rightColor && GetComponent<SpriteRenderer>().color == color1)
            {
                playSound = true;
                score++;
                hits++;
                arcadeReactionTime = 3;
            }

            else if ((start && Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "Player" && !rightColor && GetComponent<SpriteRenderer>().color != color1) || (start && rightColor && GetComponent<SpriteRenderer>().color == color1 && seconds > arcadeReactionTime) || hits > 1)
            {
                soundManager.YouLose();
                gameOverText.SetActive(true);
                GetComponent<BoxCollider2D>().enabled = false;
            }

            if (score > 0)
            {
                if (playSound)
                {
                    soundManager.Yeah();
                    playSound = false;
                }
            }

            if (score > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", score);
                PlayerPrefs.Save();
            }
            
            //===============================================================

            if (start && seconds > .02f)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            else if (start && seconds == 0)
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        //===============================================================
        if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "restart")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            transform.position = new Vector3(0, 0, 2.45f);
            score = 0;
            GetComponent<BoxCollider2D>().enabled = true;
            titleScreenText.SetActive(true);
            howToPlayText.SetActive(false);
            aboutText.SetActive(false);
            pickAColor.SetActive(false);
            pickedColor.SetActive(false);
            scoreText.GetComponent<MeshRenderer>().enabled = false;
            gameOverText.SetActive(false);
            mode1 = false;
            mode2 = false;
            about = false;
            rightColor = false;
            canRoulette = true;
            start = false;
            playSound = false;
            soundManager.you = true;
        }
    }

    void Title()
    {
        highScoreText.text = "HIGH SCORE:" + PlayerPrefs.GetInt("highScore").ToString();

        if (!mode1 && !mode2 && !about)
        {
            titleColor = Random.Range(0, 5);
            titleSec += Time.deltaTime;
            if (titleSec > .5f)
            {
                if (titleColor == 1)
                {
                    titleScreenText.GetComponentInChildren<TextMesh>().color = Color.red;
                }
                if (titleColor == 2)
                {
                    titleScreenText.GetComponentInChildren<TextMesh>().color = Color.green;
                }
                if (titleColor == 3)
                {
                    titleScreenText.GetComponentInChildren<TextMesh>().color = Color.blue;
                }
                if (titleColor == 4)
                {
                    titleScreenText.GetComponentInChildren<TextMesh>().color = Color.yellow;
                }
                titleSec = 0;
            }
        }

        if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "mode1")
        {
            mode1 = true;
            playSound = true;
        }

        if (mode1)
        {
            if (playSound)
            {
                soundManager.LetsGo();
                playSound = false;
            }
            titleScreenText.SetActive(false);
            pickAColor.SetActive(true);
            ColorRoulette();
        }

        if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "mode2")
        {
            mode2 = true;
            titleScreenText.SetActive(false);
            howToPlayText.SetActive(true);
        }

        if (mode2)
        {
            titleScreenText.SetActive(false);
            howToPlayText.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "about")
        {
            about = true;
        }

        if (about)
        {
            titleScreenText.SetActive(false);
            aboutText.SetActive(true);
        }

        if (soundManager.audioSource.enabled)
        {
            if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "sound")
            {
                soundManager.audioSource.enabled = false;
                soundText.text = "SOUND OFF";
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "sound")
            {
                soundManager.audioSource.enabled = true;
                soundText.text = "SOUND ON";
            }
        }
    }

    void ColorRoulette()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        if (canRoulette)
        {
            colorRoulette = Random.Range(0, 5);
            //================================================================
            if (colorRoulette == 1)
            {
                GetComponent<SpriteRenderer>().color = Color.red;
                if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "Player")
                {
                    rightColor = true;
                    canRoulette = false;
                    playSound = true;
                    color1 = Color.red;
                    color2 = Color.green;
                    color3 = Color.blue;
                    color4 = Color.yellow;
                    seconds = 0;
                }
            }
            else if (colorRoulette == 2)
            {
                GetComponent<SpriteRenderer>().color = Color.green;
                if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "Player")
                {
                    rightColor = true;
                    canRoulette = false;
                    playSound = true;
                    color1 = Color.green;
                    color2 = Color.red;
                    color3 = Color.blue;
                    color4 = Color.yellow;
                    seconds = 0;
                }
            }
            else if (colorRoulette == 3)
            {
                GetComponent<SpriteRenderer>().color = Color.blue;
                if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "Player")
                {
                    rightColor = true;
                    canRoulette = false;
                    playSound = true;
                    color1 = Color.blue;
                    color2 = Color.green;
                    color3 = Color.red;
                    color4 = Color.yellow;
                    seconds = 0;
                }
            }
            else if (colorRoulette == 4)
            {
                GetComponent<SpriteRenderer>().color = Color.yellow;
                if (Input.GetMouseButtonDown(0) && hit.collider != null && hit.collider.tag == "Player")
                {
                    rightColor = true;
                    canRoulette = false;
                    playSound = true;
                    color1 = Color.yellow;
                    color2 = Color.green;
                    color3 = Color.blue;
                    color4 = Color.red;
                    seconds = 0;
                }
            }
        }
    }

    void SortColor()
    {
        if (!canRoulette)
        {
            sortColor = Random.Range(0, 9);

            if (sortColor == 1 || sortColor == 2 || sortColor == 3 || sortColor == 4 || sortColor == 5)
            {
                GetComponent<SpriteRenderer>().color = color1;
                rightColor = true;
            }

            else if (sortColor == 6)
            {
                GetComponent<SpriteRenderer>().color = color2;
                rightColor = false;
            }

            else if (sortColor == 7)
            {
                GetComponent<SpriteRenderer>().color = color3;
                rightColor = false;
            }

            else if (sortColor == 8)
            {
                GetComponent<SpriteRenderer>().color = color4;
                rightColor = false;
            }
        }
    }

    void DifficultyLevels()
    {
        arcadeReactionTime = 1f;
        if (score > 10)
        {
            arcadeReactionTime = .95f;
        }
        if (score > 20)
        {
            arcadeReactionTime = .9f;
        }
        if (score > 30)
        {
            arcadeReactionTime = .85f;
        }
        if (score > 40)
        {
            arcadeReactionTime = .8f;
        }
        if (score > 50)
        {
            arcadeReactionTime = .75f;
        }
        if (score > 60)
        {
            arcadeReactionTime = .7f;
        }
        if (score > 70)
        {
            arcadeReactionTime = .65f;
        }
        if (score > 80)
        {
            arcadeReactionTime = .6f;
        }
        if (score > 90)
        {
            arcadeReactionTime = .55f;
        }
        if (score > 100)
        {
            arcadeReactionTime = .5f;
        }
    }

}
