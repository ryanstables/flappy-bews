using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{

    public GameObject cloud;

    public float timeUntilNextCloud = 1000;
    private float timer = 0;

    float getHeightOffset(float lo, float hi) {
      // get the pitch from the midi input and convert it to the height here...
      return Random.Range(lo, hi);
    }

      void generateCloud() {
      float offset = getHeightOffset(-25, 1);
      Instantiate(cloud, new Vector3(transform.position.x, offset, 0), transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
      generateCloud();
    }

    // Update is called once per frame
    void Update()
    {
      if(timer < timeUntilNextCloud) {
        timer += Time.deltaTime;
      } else {
        generateCloud();
        timer = 0;
      }
    }        
  }
