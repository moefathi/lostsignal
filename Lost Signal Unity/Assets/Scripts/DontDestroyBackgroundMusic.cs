using UnityEngine;

public class DontDestroyBackgroundMusic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    AudioSource speech;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        speech = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
