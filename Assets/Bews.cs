using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bews : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public Scores scores;
    public int flapPower = 10;

    public float spinMultiplier = 3;
    private bool isAlive = true;
    private bool isSpinning = false;

    public void setIsSpinning(bool _isSpinning) {
      isSpinning = _isSpinning;
    }

    public void setIsAlive(bool _isAlive) {
      isAlive = _isAlive;
    }

    bool flapTriggered()
    {
      // check the correct note-on is being played here...
      return Input.GetKeyDown(KeyCode.Space);
    }

    void flap() {
      rigidBody.velocity = Vector2.up * flapPower;
    }

    void setGameOver() {
      scores.gameOver();
      setIsAlive(false);
      setIsSpinning(true);
      rigidBody.AddForce(new Vector2(-5, 5));
    }

    bool isObjectOutOfBounds() {
      return transform.position.y < -29 || transform.position.y > 7;
    }
    // Update is called once per frame
    void Update()
    {
      if(flapTriggered() && isAlive)
      {
        flap();
      }
      if(isSpinning) {
        transform.Rotate(0, 0, spinMultiplier);
      }
      if(isObjectOutOfBounds()) {
        setGameOver();
      }
    }

    void OnCollisionEnter2D(Collision2D collision) {
      setGameOver();
    }

}
