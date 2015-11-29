using UnityEngine;
using CnControls;
using System.Collections;

public class bombermanControl : MonoBehaviour {
    public GameObject bomberman;
	public Vector2 velocity;
	public Rigidbody2D rb2D;

    // Use this for initialization
    void Start() {
		rb2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float v =  CnInputManager.GetAxis("Vertical");
        float h =  CnInputManager.GetAxis("Horizontal");

        v = v * 5;
        h = h * 5;

		velocity = new Vector2(h,v);

		rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
        //gameObject.transform.position += new Vector3(h, v, 0);

       
	}
}
