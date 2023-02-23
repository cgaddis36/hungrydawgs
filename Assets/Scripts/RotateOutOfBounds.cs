using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOutOfBounds : MonoBehaviour
{
    private float upperBound = 32.0f;
    private float lowerBound = -14.0f;
     private float rightBound = 23.0f;
    private float leftBound = -23.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      var position = transform.position;
      var crossesUpperBoundary = position.z > upperBound;
      var crossesLowerBoundary = position.z < lowerBound;
      var crossesRightBoundary = position.x > rightBound;
      var crossesLeftBoundary = position.x < leftBound;

      if (crossesUpperBoundary) {
        RotateAnimal(direction: "down");
      } else if (crossesLowerBoundary) {
        RotateAnimal(direction: "up");
      } else if (crossesRightBoundary) {
        RotateAnimal(direction: "left");
      } else if (crossesLeftBoundary) {
        RotateAnimal(direction: "right");
      }
    }
    private void RotateAnimal(string direction) {
      var rotation = transform.rotation;
      if(direction == "up") {
        transform.rotation = Quaternion.Euler(rotation.x, 0, rotation.z);
      } else if (direction == "down") {
        transform.rotation = Quaternion.Euler(rotation.x, 180, rotation.z);
      } else if (direction == "right") {
        transform.rotation = Quaternion.Euler(rotation.x, 90, rotation.z);
      } else if (direction == "left") {
        transform.rotation = Quaternion.Euler(rotation.x, 270, rotation.z);
      }
    }
}
