using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement pm;
    public Text t;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") {
            pm.enabled = false;
            t.text = "You Lost";
        }
    }

}
