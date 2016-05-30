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
        // GameObject player = coll.gameObject;
        // ContactPoint2D[] contactPoints = coll.contacts;
        foreach(ContactPoint2D hit in coll.contacts)
		{
        	Debug.Log(hit.point);
        }
        // this.transform.position = player.position;
     	// transform.rotation = Quaternion.Euler(0, Cam.rotation.eulerAngles.y, 0);
        //Destroy(gameObject);		 
	}

}
