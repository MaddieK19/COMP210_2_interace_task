using UnityEngine;
using System.Collections;

public class Falcon_Controller : MonoBehaviour
{
    public GameObject falcon;
    public GameObject controller;
    public SerialController serialController;
    public float speed;
    public bool collisionHappened = false;
    private float step;
    public SteamVR_TrackedObject trackedObject;
    public SteamVR_Controller.Device device;
    // Use this for initialization
    void Start()
    {
       //serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
       //trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {

        //device = SteamVR_Controller.Input((int)trackedObject.index);

        /*if (device.GetAxis().x != 0 || device.GetAxis().y != 0)
        {
            Debug.Log(device.GetAxis().x + " " + device.GetAxis().y);
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger pressed");
            device.TriggerHapticPulse(800);
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleLand");
        }*/

        if (collisionHappened == false)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, controller.transform.position, step);
        }

    }


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "RightController")
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleLand");
            //serialController.SendSerialMessage("p");
            collisionHappened = true;
            
        }
    }
}
