using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class ThrowRocks : MonoBehaviour
{
    [SerializeField] GameObject throwableRock;
    GameObject rockClone;
    int rocks;
    [SerializeField] TextMeshProUGUI txt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rocks = 5;       

    }

    // Update is called once per frame
    void Update()
    {
        if (rockClone != null)
        {
            if (rockClone.transform.position.y < 4)
            {
                rockClone.gameObject.tag = "HarmlessRock";
            }
        }
        if (Input.GetMouseButtonUp(0) && rocks > 0) {
            Invoke("throwRock", 0f);
        }
    }

    void throwRock() {
        rockClone = Instantiate(throwableRock, gameObject.transform.position + gameObject.transform.forward, gameObject.transform.rotation);
        rockClone.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 60f, ForceMode.Impulse);
        rocks--;
        txt.text = "Rocks: " + rocks;
    }
}
