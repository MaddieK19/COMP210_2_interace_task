using UnityEngine;
using System.Collections;

public class SmartPhone : MonoBehaviour {
    public Material lockScreen;
    public Material callScreen;
    public Renderer rend;
    public SteamVR_TrackedController trackedController;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (trackedController.triggerPressed)
            rend.sharedMaterial = callScreen;

        if (trackedController.gripped)
        {
            Debug.Log("Left trigger pressed");
            rend.sharedMaterial = lockScreen;
        }
    }
}
