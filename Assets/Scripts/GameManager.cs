using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
     public TextMeshProUGUI scoreText;
     public TextMeshProUGUI LivesText;
     public TextMeshProUGUI gameOverText;
     public PlayerController player;
      public Button restartButton;
      public Button exitButton;
       public Button CreditsButton;
     public int score;
     public int Lives;
    
    // Start is called before the first frame update
    void Start()
    {
        player= FindObjectOfType<PlayerController>();
      UpdateScore(0);
      UpdateLives(-3);
    }

    // Update is called once per frame
    void Update()

    {
     if (Input.GetKeyDown ("escape")) {

   Application.Quit();
     }

         if(player.Dead==true){
//CreditsButton.gameObject.SetActive(true);
      restartButton.gameObject.SetActive(true);
       exitButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
         }

      
    }
    public void UpdateScore(int AddScore){

        score += AddScore;
        scoreText.text = "Score: " + score;
    }
    public void UpdateLives(int died){

        Lives -= died;
        LivesText.text = "Lives x" +Lives;
    
    }

public void RestartGame()
{
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

public void ExitGame()
{
     Application.Quit();
}
/*public void Credits()
{
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
}*/

}