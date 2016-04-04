using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuNew : MonoBehaviour {


    public bool isPaused;
    public GameObject PauseMenu;
    private InputManager input;
    private int player_num;

    void Start(){
        input = GameObject.Find("InputManager").GetComponent<InputManager>();
        player_num = GetComponent<PlayerMovement>().player_num;
    }

    // Update is called once per frame
    void Update(){
        if (isPaused){
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else{
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        if  (input.buttonDown(player_num, "Back")){
            isPaused = !isPaused;
        }
    }

    public void Resume(){
        isPaused = false;
    }


    public void RestartMatch(){
        SceneManager.LoadScene(1);
    }

    public void Quit(){
        SceneManager.LoadScene(0);
    }
}
