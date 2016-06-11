using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Ball ball;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y, this.transform.position.z);
	}
}
