using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private GameObject player; 
	private bool inPossession = false;
	private Vector2 hitPoint; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (inPossession) {
			this.transform.position = new Vector3(
				hitPoint.x + player.transform.position.x, 
				hitPoint.y + player.transform.position.y, 
				0f
			);
		}
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		this.player = coll.gameObject;
        // Get the distances between the collider and the ball to apply as padding 
		// so the ball is not ON the obj, but where it ws hit first

        // float distX = this.position.x - coll.transform.position.x;
        // float distY = this.position.y - coll.transform.position.y;
		this.inPossession = true;
        //this.transform.position = new Vector3(obj.position.x + distX, obj.position.y + distY, obj.position.z);
        //print("Applied!");
		this.hitPoint = coll.contacts[0].point;
     	//transform.rotation = Quaternion.Euler(0, Cam.rotation.eulerAngles.y, 0);
        //Destroy(gameObject);		 
	}

}
