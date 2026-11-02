using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneSpeechScript : MonoBehaviour
{
    [SerializeField] GameObject emilieSpeechObj;
    [SerializeField] GameObject johnSpeechObj;
    [SerializeField] GameObject alienBossSpeechObj;

    AudioSource emilieSpeech;
    AudioSource johnSpeech;
    AudioSource alienSpeech;

    [SerializeField] GameObject emilieCanvas;
    [SerializeField] GameObject johnCanvas;
    [SerializeField] GameObject alienBossCanvas;
    [SerializeField] GameObject alienBoss;

    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emilieSpeech = emilieSpeechObj.GetComponent<AudioSource>();
        johnSpeech = johnSpeechObj.GetComponent<AudioSource>();
        alienSpeech = alienBossSpeechObj.GetComponent<AudioSource>();
        anim = alienBoss.GetComponent<Animator>();

        Invoke("PlayEmilieSpeech", 36f);
        Invoke("PlayJohnSpeech", 46f);
        Invoke("PlayNextScene", 79);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayJohnSpeech() {
        anim.SetBool("isTalking", false);
        emilieCanvas.SetActive(false);
        johnCanvas.SetActive(true);
        johnSpeech.Play();
    }

    void PlayEmilieSpeech() {
        anim.SetBool("isTalking", false);
        alienBossCanvas.SetActive(false);
        emilieCanvas.SetActive(true);
        emilieSpeech.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isTalking", true);
        alienBossCanvas.SetActive(true);
        alienSpeech.Play();
    }

    void PlayNextScene() {

        SceneManager.LoadScene("C1_TheRoad");
    }
}
