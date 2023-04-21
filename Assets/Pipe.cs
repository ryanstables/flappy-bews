using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update

    public void setColor(Color colour) {
      spriteRenderer.color = colour;
    }

    void Start()
    {        
      spriteRenderer = GetComponent<SpriteRenderer>();
    }
}