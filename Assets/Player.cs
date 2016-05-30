using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 0.8f;

	void Start () {
		Vector3 curPos = this.transform.position;
		print(curPos);
	}

	void Update () {

		Vector3 pos = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
		// float mousePos = Input.mousePosition.x / Screen.width * 16;
		// pos.x = Mathf.Clamp(this.transform.position.x - 0.01f, -1f, 15.5f);
		// this.transform.position = pos;
		this.GetComponent<Rigidbody2D>().velocity = new Vector2( -1f * speed, 0f);
		// print(this.transform.position);
	}
}
