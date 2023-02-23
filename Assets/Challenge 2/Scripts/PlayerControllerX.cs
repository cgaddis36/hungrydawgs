using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float horizontalInput;
    private float xRange = 20.0f;
    public float spaceTimer = 0.0f;
    public float fireRate = 0.5f;
    public GameObject dogPrefab;
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    { 
      if(transform.position.x < -xRange) {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      } else if (transform.position.x > xRange){
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spaceTimer < Time.time)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spaceTimer = (Time.time + fireRate);
        }
    }
   
}
