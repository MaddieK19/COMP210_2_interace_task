using UnityEngine;
using System.Collections;

public class Right_Input_Manager : MonoBehaviour {
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
    public GameObject falcon;

    // Use this for initialization
    void Start()
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Trigger pressed");
            device.TriggerHapticPulse(400);
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {

        }


    }
}
