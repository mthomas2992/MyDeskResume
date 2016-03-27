using UnityEngine;
using System.Collections;

public class CamPos2 : MonoBehaviour {
    public Camera MainCam;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("entered");
        MainCam.transform.localPosition = new Vector3(-6.99f, -2.31f, -10f); //need a dynacamimplementation like
        MainCam.orthographicSize = 1f;
    }
}
