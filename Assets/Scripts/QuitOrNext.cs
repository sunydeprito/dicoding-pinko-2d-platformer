using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class QuitOrNext : MonoBehaviour 
{
    public string NameScene = "";
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
                   SceneManager.LoadScene("Menu");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("player"))
        {
            SceneManager.LoadScene(NameScene);
        }
    }

      // pindah scene ke menu
        public void MenuScene() {
       SceneManager.LoadScene("Menu");
   }

  // pindah scene ke main
        public void MainScene() {
       SceneManager.LoadScene("Main");
   }
    // keluar dari game
   public void KeluarScene() {
       Application.Quit();
   }
}
