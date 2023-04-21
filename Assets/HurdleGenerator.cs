﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleGenerator : MonoBehaviour
{

    public GameObject hurdle;
    
    // these will be replaced by input midi song-params...
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;


    float getHeightOffset(float lo, float hi) {
      // get the pitch from the midi input and convert it to the height here...
      return Random.Range(lo, hi);
    }

    void generateHurdle() {
      float lo = transform.position.y - heightOffset;
      float hi = transform.position.y + heightOffset;
      float offset = getHeightOffset(lo, hi);
      Instantiate(hurdle, new Vector3(transform.position.x, offset, 0), transform.rotation);
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