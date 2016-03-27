using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    public GameObject player;
    public Rigidbody2D playerbody;
    private Vector2 jump = new Vector2(0f, 7f);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("running");
        if (Input.GetKey(KeyCode.D)) {
            //Debug.Log("key detected");
            playerbody.velocity = new Vector2(2f, playerbody.velocity.y);
        }
        if (Input.GetKey(KeyCode.A)) {
            //Debug.Log("key detected");
            playerbody.velocity = new Vector2(-2f, playerbody.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            playerbody.AddForce(jump, ForceMode2D.Impulse);
        }

        //Dynacam type inserstion

    }
}
