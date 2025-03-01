using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class score_manager : MonoBehaviour
{
    public static score_manager instance;
    public TMP_Text score_text;
    public TMP_Text gameOverText;
    //public GameObject restartButton;
    int score = 0;
   // public static bool gameMaster = true;  // gameMaster cause memory leak and crash idk why.

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score_text.text = score + " Points";
        gameOverText.gameObject.SetActive(false);
        //restartButton.SetActive(false);
       // gameMaster = true;
    }

    public void AddPoints()
    {
        //if (!gameMaster) return;
        score++;
        score_text.text = score + " Points";
    }

    public void OnRobotDestroyed()
    {
        //gameMaster = false;
        //CleanUp();
        score_text.gameObject.SetActive(false);
        gameOverText.text = "You Lost\nScore: " + score;
        gameOverText.gameObject.SetActive(true);
       // restartButton.SetActive(true);
    }


    /*private void CleanUp()
    {
        if (score_manager.gameMaster == false)
        {
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("Boxes");
            foreach (GameObject box in boxes)
            {
                Destroy(box);
            }

        }
    }*/
}
