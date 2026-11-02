using UnityEngine;

public class AlienScript : MonoBehaviour
{ 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 1.5f * Time.deltaTime);

        if (((transform.position.z <= -601  &&  (transform.eulerAngles.y <= 200 && transform.eulerAngles.y >= 160))) 
            || (transform.position.x >= -834 && (transform.eulerAngles.y <= 110 && transform.eulerAngles.y >= 70)) 
            || (transform.position.x <= -865.03 && (transform.eulerAngles.y <= 290 && transform.eulerAngles.y >= 250))) {
            Destroy(gameObject);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DamagingRock")) {
            Destroy(gameObject);
        }
    }
}
