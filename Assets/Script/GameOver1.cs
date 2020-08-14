using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour
{
    public Movement movement;
    public GameObject GameOverUI;
    public static bool gameinpaused;

    // Start is called before the first frame update

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameinpaused = false;

    }
    public void MainMenu()
    {
        Application.LoadLevel("mainmenu");
        Time.timeScale = 1f;

    }
    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "underground")
        {
            movement.enabled = false;
            GameOverUI.SetActive(true);
            Time.timeScale = 0f;
            gameinpaused = true;
        }
    }
}