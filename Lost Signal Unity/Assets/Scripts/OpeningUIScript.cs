using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningUIScript : MonoBehaviour
{
    [SerializeField] Button btn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() { 
   
        SceneManager.LoadScene("B1_OpeneningScene");

    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
