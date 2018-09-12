using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixController : MonoBehaviour {
    
    private Vector3 clickPos;
    private bool mouseDown = false;

	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            clickPos = Input.mousePosition;
            mouseDown = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
        }

        
    }

    void FixedUpdate()
    {
        if (mouseDown)
        {
            Vector3 currentMPos = Input.mousePosition;
            float move = clickPos.x - currentMPos.x;

            Quaternion currentRotation = transform.rotation;
            currentRotation.y = move * Time.deltaTime;
            transform.rotation = currentRotation;
            Debug.Log(move);
        }
    }

}
