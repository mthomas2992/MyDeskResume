using UnityEngine;
using System.Collections;

public class CamPos1 : MonoBehaviour {
    public Camera MainCam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("entered");
        MainCam.transform.localPosition = new Vector3(0.56f, -1.41f, -10f); //need a dynacamimplementation like
        MainCam.orthographicSize = 3f;
    }
}
