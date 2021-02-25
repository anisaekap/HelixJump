using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public AudioSource buttonSound;
	
	public void Menu(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		buttonSound.PlayOneShot(buttonSound.clip);
	}
	public void QuitGame(){
		Application.Quit();
	}
	
	public void Back()
    {
        Application.LoadLevel("Menu");
    }
	
	public void MenuGO()
    {
        Application.LoadLevel("Menu");
    }
	
	public void Restart()
    {
        Application.LoadLevel("Main");
    }
	
	public void Help()
    {
        Application.LoadLevel("Help");
    }
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
