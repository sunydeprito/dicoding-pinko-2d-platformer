using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class GameOver : MonoBehaviour
{
    public Text txScore;
    public Text txHighScore;
    Text txSelamat;
    int highscore;
    
    // Use this for initialization
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HS", 0);
        if (Data.score > highscore )
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("HS", highscore);
        }
      
        txHighScore.text = "Highscores: " + highscore;
        txScore.text = "Scores: " + Data.score;
    }
    
    public void Replay()
    {
        Data.score = 0;
        SceneManager.LoadScene("Main");
    }
}
