using Unity.VisualScripting;
using UnityEngine;

public class SpeechScript : MonoBehaviour
{
    [SerializeField] GameObject Canvas;
    AudioSource speech;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speech = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!speech.isPlaying) { 
        Canvas.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !speech.isPlaying) {

            speech.Play();
            Canvas.SetActive(true);

        }
    }
}
