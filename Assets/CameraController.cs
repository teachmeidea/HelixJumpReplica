using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform ball;
	void LateUpdate () {
		if(ball != null)
        {
            if(ball.position.y < transform.position.y - 2f)
            {
                Vector3 curentPos = transform.position;
                curentPos.y = ball.position.y + 2f;
                transform.position = curentPos;
            }
        }
	}
}
