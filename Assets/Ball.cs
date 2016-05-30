using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D coll){
        // GameObject obj = coll.gameObject;
        //get the distances between the collider and the ball to apply as padding 
		// so the ball is not ON the obj, but where it ws hit first

        // float distX = this.position.x - coll.transform.position.x;
        // float distY = this.position.y - coll.transform.position.y;

        // this.transform.position = new Vector3(obj.position.x + distX, obj.position.y + distY, obj.position.z);
        // print("Applied!");
        // ContactPoint2D[] contactPoints = coll.contacts;
  		// foreach(ContactPoint2D hit in coll.contacts){
		// 	Debug.Log(hit.point);
		// }
     	// transform.rotation = Quaternion.Euler(0, Cam.rotation.eulerAngles.y, 0);
        //Destroy(gameObject);		 
	}

}
