using UnityEngine;
using System.Collections;

public class SmartPhone : MonoBehaviour {
    public Material lockScreen;
    public Material callScreen;
    public Renderer rend;
    public SteamVR_TrackedObject trackedObject;
    public SteamVR_Controller.Device device;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input(1);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            rend.sharedMaterial = callScreen;

        if (device.GetAxis().x != 0 || device.GetAxis().y != 0)
        {
            Debug.Log(device.GetAxis().x + " " + device.GetAxis().y);
            Debug.Log("Left trigger pressed");
            rend.sharedMaterial = lockScreen;
        }
    }
}
