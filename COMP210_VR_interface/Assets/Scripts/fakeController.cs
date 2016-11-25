using UnityEngine;
using System.Collections;

public class fakeController : MonoBehaviour {
    public Transform target;

    // Use this for initialization
    void Start () {
        transform.position = target.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Keypad9))
            transform.Translate(Vector3.forward * Time.deltaTime * 10);

        if (Input.GetKeyDown(KeyCode.Keypad5))
            transform.Translate(Vector3.back * Time.deltaTime * 10);

        if (Input.GetKeyDown(KeyCode.Keypad4))
            transform.Translate(Vector3.left * Time.deltaTime * 10);

        if (Input.GetKeyDown(KeyCode.Keypad6))
            transform.Translate(Vector3.right * Time.deltaTime * 10);
    }
}
