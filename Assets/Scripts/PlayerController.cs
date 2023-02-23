using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public float zRange = 5.0f;
    
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log($"Lives: 3");
    }

    // Update is called once per frame
    void Update()
    {
      var playerPosition = transform.position;
      if (playerPosition.x < -xRange) {
        playerPosition = new Vector3(-xRange, playerPosition.y, playerPosition.z);
      } else if (playerPosition.x > xRange) {
        playerPosition = new Vector3(xRange, playerPosition.y, playerPosition.z);
      }
      horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

      if (playerPosition.z < -zRange) {
        playerPosition = new Vector3(playerPosition.x, playerPosition.y, -zRange);
      } else if (playerPosition.z > zRange) {
        playerPosition = new Vector3(playerPosition.x, playerPosition.y, zRange);
      }
      verticalInput = Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

      if(Input.GetKeyDown(KeyCode.Space)){
        //Launch projectile from player
        Instantiate(projectilePrefab, playerPosition, projectilePrefab.transform.rotation);
      }
    }
}
