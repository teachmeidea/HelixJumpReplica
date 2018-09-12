using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody rb;
    private float jumpForce = 5f;
    private bool inCollision = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnCollisionEnter(Collision co)
    {
        if (inCollision)
            return;
        
        if(co.gameObject.tag != "red_helix")
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        else
        {
            GameController.instance.GameOver();
            Destroy(this.gameObject, 0.2f);
        }
        inCollision = true;
    }

    void OnCollisionExit(Collision co)
    {
        inCollision = false;
    }

}
