using UnityEngine;
using System.Collections;

public class CamPos5 : MonoBehaviour {
    public Camera MainCam;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("entered");
        MainCam.transform.localPosition = new Vector3(13.05f, 0.2f, -10f); //need a dynacamimplementation like
        MainCam.orthographicSize = 3.5f;
    }
}
