using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialEndDetection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name == "C1_TheRoad")
            {
                SceneManager.LoadScene("C2_TheAlienRoad");
            }
            else if (SceneManager.GetActiveScene().name == "C2_TheAlienRoad")
            {
                SceneManager.LoadScene("C3_TheMaze");
            }
            else if (SceneManager.GetActiveScene().name == "C3_TheMaze") {
               
                SceneManager.LoadScene("B2_EndingCutScene");
            }else if (SceneManager.GetActiveScene().name == "B2_EndingCutScene")
            {

                SceneManager.LoadScene("E_CreditsScene");
            }
        }
    }
}
