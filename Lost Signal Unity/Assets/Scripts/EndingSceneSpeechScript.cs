using UnityEngine;

public class EndingSceneSpeechScript : MonoBehaviour
{
    [SerializeField] GameObject emilieSpeechObjOne;
    [SerializeField] GameObject emilieSpeechObjTwo;
    [SerializeField] GameObject johnSpeechObjOne;
    [SerializeField] GameObject johnSpeechObjTwo;

    AudioSource emilieSpeechTwo;
    AudioSource johnSpeechOne;
    AudioSource johnSpeechTwo;

    [SerializeField] GameObject emilieOneCanvas;
    [SerializeField] GameObject emilieTwoCanvas;
    [SerializeField] GameObject johnOneCanvas;
    [SerializeField] GameObject johnTwoCanvas;

    [SerializeField] GameObject emilie;
    [SerializeField] GameObject john;

    Animator emilieAnim;
    Animator johnAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emilieSpeechTwo = emilieSpeechObjTwo.GetComponent<AudioSource>();
        johnSpeechOne = johnSpeechObjOne.GetComponent<AudioSource>();
        johnSpeechTwo = johnSpeechObjTwo.GetComponent <AudioSource>();
        
        emilieAnim = emilie.GetComponent<Animator>();
        johnAnim = john.GetComponent<Animator>();

        emilieOneCanvas.SetActive(true);
        

        Invoke("PlayJohnSpeechOne", 7f);
        Invoke("PlayEmilieSpeechTwo", 14f);
        Invoke("PlayJohnSpeechTwo", 33f);
        Invoke("End", 36f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayJohnSpeechOne() {
        emilieAnim.SetFloat("Etalking", 0);
        johnAnim.SetFloat("Jtalking", 1);
        emilieOneCanvas.SetActive(false);
        johnOneCanvas.SetActive(true);
        johnSpeechOne.Play();
    }

    void PlayEmilieSpeechTwo()
    {
        johnAnim.SetFloat("Jtalking", 0);
        emilieAnim.SetFloat("Etalking", 1);
        johnOneCanvas.SetActive(false);
        emilieTwoCanvas.SetActive(true);
        emilieSpeechTwo.Play();
   
    }

    void PlayJohnSpeechTwo()
    {
        emilieAnim.SetFloat("Etalking", 0);
        johnAnim.SetFloat("Jtalking", 1);
        emilieTwoCanvas.SetActive(false);
        johnTwoCanvas.SetActive(true);
        johnSpeechTwo.Play();
    }

    void End()
    {
        emilie.transform.eulerAngles = new Vector3(0, 90, 0);
        john.transform.eulerAngles = new Vector3(0, 90, 0);
        johnAnim.SetFloat("Jtalking", 2);
        emilieAnim.SetFloat("Etalking", 2);

        john.transform.Translate(Vector3.forward * Time.deltaTime);
        emilie.transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
