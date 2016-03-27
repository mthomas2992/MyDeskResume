using UnityEngine;
using System.Collections;

public class CamPos4 : MonoBehaviour {
    public Camera MainCam;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("entered");
        MainCam.transform.localPosition = new Vector3(8.6f, -1.86f, -10f); //need a dynacamimplementation like
        MainCam.orthographicSize = 2f;
    }
}
