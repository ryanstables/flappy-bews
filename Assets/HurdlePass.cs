using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdlePass : MonoBehaviour
{
    public Scores scores;

    // Start is called before the first frame update
    void Start()
    {
        scores = GameObject.FindGameObjectWithTag("Scores").GetComponent<Scores>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
      if(collision.gameObject.layer == 8) {
        scores.addPoint();
      }
    }
}
