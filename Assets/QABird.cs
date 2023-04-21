using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QABird : MonoBehaviour
{
    public float speedMultiplier = 5.0f;
    public float modulationSpeed = 10f;
    private float deletePos = -40;
    private float top = 2;
    private float bottom = -25;
    private bool isRising = true;

    void Start() {
      modulationSpeed += Random.Range(-5f, 6f);
    }
    Vector3 getSpeed() {
      // convert the tempo of the song to another coeff here...
      return (Vector3.left * speedMultiplier) * Time.deltaTime;
    }

    Vector3 modulateHeight() {
      if(transform.position.y >= top || transform.position.y <= bottom) {
        isRising = !isRising;
      }
      return isRising ? 
        Vector3.up * Time.deltaTime * modulationSpeed : 
        Vector3.down * Time.deltaTime * modulationSpeed ;
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += getSpeed();
      transform.position += modulateHeight();
      

      if(transform.position.x < deletePos) {
        Destroy(gameObject);
      }
    }
}
