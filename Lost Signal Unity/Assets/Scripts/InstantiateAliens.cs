using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiateAliens : MonoBehaviour
{
    [SerializeField] GameObject[] alien;
    [SerializeField] Transform[] alienInsPoint;
    GameObject alienClone;
    [SerializeField] GameObject player;
    int counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter = 0;
        if (SceneManager.GetActiveScene().name == "C2_TheAlienRoad")
        {
            InvokeRepeating(nameof(alienInstantiation), 0f, 1.3f);
        } else if (SceneManager.GetActiveScene().name == "C3_TheMaze")
        {
            InvokeRepeating(nameof(alienInstantiation), 0f, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void alienInstantiation()
    {
        if (counter < alienInsPoint.Length)
        { 
            alienClone = Instantiate(alien[Random.Range(0, alien.Length)], alienInsPoint[counter].position, alienInsPoint[counter].rotation);
            counter++;

            if (counter == alienInsPoint.Length)
                counter = 0;
        }

    }
}
