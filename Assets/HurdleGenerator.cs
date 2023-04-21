using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum HurdleType {
  pipe = 0, 
  lewis = 1, 
  frankie = 2
};

public class HurdleGenerator : MonoBehaviour
{

    public GameObject hurdle;
    public GameObject lewis;
    public GameObject frankie;
    
    // these will be replaced by input midi song-params...
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;
    private int numHurdles = 0;

    int hurdleType = 0;


    float getHeightOffset(float lo, float hi) {
      // get the pitch from the midi input and convert it to the height here...
      return Random.Range(lo, hi);
    }

    void generateHurdle() {

      if(numHurdles >= 5) {
        hurdleType = Random.Range(0, 3);
      }

      if(hurdleType == 0) {
        float lo = transform.position.y - heightOffset;
        float hi = transform.position.y + heightOffset;
        float offset = getHeightOffset(lo, hi);
        Instantiate(hurdle, new Vector3(transform.position.x, offset, 0), transform.rotation);
      } else if(hurdleType == 1) {
        Instantiate(lewis, new Vector3(transform.position.x, 2, 0), transform.rotation);
      } else if(hurdleType == 2) {
        Instantiate(frankie, new Vector3(transform.position.x, 2, 0), transform.rotation);
      }
      numHurdles++;
    }

    // Start is called before the first frame update
    void Start()
    {
      generateHurdle();
    }

    // Update is called once per frame
    void Update()
    {
      if(timer < spawnRate) {
        timer = timer + Time.deltaTime;
      } else {
        generateHurdle();
        timer = 0;
      }
    }
}
