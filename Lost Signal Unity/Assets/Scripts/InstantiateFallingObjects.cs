using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiateFallingObjects : MonoBehaviour
{
    [SerializeField] GameObject[] fallingObj;
    [SerializeField] Transform[] fallingObjInsPoint;
    GameObject fallingObjClone;
    [SerializeField] GameObject player;
    int counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter = 0;

        if (SceneManager.GetActiveScene().name == "C1_TheRoad")
        {
            InvokeRepeating(nameof(alienInstantiation), 0f, 0.8f);
        }
        else if (SceneManager.GetActiveScene().name == "C2_TheAlienRoad")
        {
            InvokeRepeating(nameof(alienInstantiation), 0f, 0.6f);
        }
        else if (SceneManager.GetActiveScene().name == "C3_TheMaze")
        {
            InvokeRepeating(nameof(alienInstantiation), 0f, 0.4f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fallingObjClone != null)
        {

            if (fallingObjClone.transform.position.y < 4)
            {
                fallingObjClone.gameObject.tag = "NotDamagingBall";
            }
        }
    }

    void alienInstantiation()
    {
        if (counter < fallingObjInsPoint.Length)
        {
            fallingObjClone = Instantiate(fallingObj[Random.Range(0, fallingObj.Length)], fallingObjInsPoint[counter].position, fallingObjInsPoint[counter].rotation);
            counter++;

            if (counter == fallingObjInsPoint.Length)
                counter = 0;
        }
    }
}


