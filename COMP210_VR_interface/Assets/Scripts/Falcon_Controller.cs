using UnityEngine;
using System.Collections;

public class Falcon_Controller : MonoBehaviour {
    public Transform target;
    public GameObject controller;
    public float speed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
         
        transform.position = Vector3.MoveTowards(transform.position, controller.transform.position, step);
    }
}
