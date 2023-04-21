using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speedMultiplier = 30f;
    private float deletePos = -40;
    public float yOffset = 0;

    Vector3 getSpeed() {
      // convert the tempo of the song to another coeff here...
      return (Vector3.left * speedMultiplier) * Time.deltaTime;
    }

    void start() {
      
    } 

    void Update()
    {
      transform.position += getSpeed();
      
      if(transform.position.x < deletePos) {
        Destroy(gameObject);
      }
    }
}
