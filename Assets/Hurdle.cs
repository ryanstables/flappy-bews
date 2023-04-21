using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdle : MonoBehaviour
{

    public float speedMultiplier = 5.0f;
    private float deletePos = -40;

    Vector3 getSpeed() {
      // convert the tempo of the song to another coeff here...
      return (Vector3.left * speedMultiplier) * Time.deltaTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += getSpeed();
      
      if(transform.position.x < deletePos) {
        Destroy(gameObject);
      }
    }
}
