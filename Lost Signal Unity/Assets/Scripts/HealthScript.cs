using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Image health;
    [SerializeField] float healthBar;

    [SerializeField] GameObject canvas;
    [SerializeField] GameObject audioHolderOne;
    [SerializeField] GameObject audioHolderTwo;

    AudioSource audioOne;
    AudioSource audioTwo;


    void Start()
    {
        healthBar = 100f;
        audioOne = audioHolderOne.GetComponent<AudioSource>();
        audioTwo = audioHolderTwo.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBar <= 0) {
            
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            canvas.SetActive(true);
            audioOne.Stop();
            audioTwo.Stop();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            healthBar -= 20;
            health.fillAmount = healthBar / 100f;
        }
        else if (collision.gameObject.CompareTag("SmallBall"))
        {
            healthBar -= 10;
            health.fillAmount = healthBar / 100f;

        }
        else if (collision.gameObject.CompareTag("BigBall")) { 
            healthBar -= 20;
            health.fillAmount = healthBar / 100f;
        }
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        healthBar = 100f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
