using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdle : MonoBehaviour
{

    public GameObject bottomPipe;
    public GameObject topPipe;

    public float speedMultiplier = 5.0f;
    private float deletePos = -40;

    private Color[] colours = {
      new Color(194f/255f, 0f/255f, 100f/255f),
      new Color(208f/255f, 64f/255f, 88f/255f),
      new Color(222f/255f, 128f/255f, 75f/255f),
      new Color(233f/255f, 173f/255f, 2f/255f),
      new Color(223f/255f, 204f/255f, 6f/255f),
      new Color(134f/255f, 192f/255f, 59f/255f),
      new Color(18f/255f, 128f/255f, 68f/255f),
      new Color(43f/255f, 134f/255f, 162f/255f),
      new Color(68f/255f, 140f/255f,  255f/255f),
      new Color(65f/255f, 72f/255f, 220f/255f),
      new Color(94f/255f, 78f/255f, 211f/255f),
      new Color(155f/255f, 0f/255f, 224f/255f)
    };

    Vector3 getSpeed() {
      // convert the tempo of the song to another coeff here...
      return (Vector3.left * speedMultiplier) * Time.deltaTime;
    }

    void Start()
    {
      Color pipeColour = colours[Random.Range(0, colours.Length)];
      bottomPipe.GetComponent<Pipe>().setColor(pipeColour);
      topPipe.GetComponent<Pipe>().setColor(pipeColour);
    }

    void Update()
    {
      transform.position += getSpeed();
      
      if(transform.position.x < deletePos) {
        Destroy(gameObject);
      }
    }
}
