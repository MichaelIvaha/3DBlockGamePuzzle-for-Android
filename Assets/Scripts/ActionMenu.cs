using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionMenu : MonoBehaviour
{
   public void StartGame(){ SceneManager.LoadScene("Level 1");}

    public void QuitGame(){ 
        Debug.Log("Exit Game!");
        Application.Quit();}

        public void ChooseLevel(){ SceneManager.LoadScene("ChooseLevel");}

        public void BackToMenu(){ SceneManager.LoadScene("Menu");}

        public void LevelChange(int ChooseLevel){SceneManager.LoadScene(ChooseLevel);}

        public void RestartLevel(){ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}

        public void NextLevel(){ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);}

        public void PresentLevel(){ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);}

    }
