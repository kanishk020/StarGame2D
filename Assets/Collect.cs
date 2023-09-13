
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collect : MonoBehaviour
{
  public GameObject winText;
  public GameObject scoreText;
  public static int theScore;
    public GameObject Reset;

    private void Start()
    {
        Reset.SetActive(false);
    }


    void Update()
    {

    scoreText.GetComponent<Text>().text = "SCORE: "+ theScore;
        if(theScore == 12)
        {
            winText.SetActive(true);  
            Reset.SetActive(true);
        }
        else
        {
             winText.SetActive(false);
        }

    }

    public void Resetgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        theScore = 0;

    }


}
