using UnityEngine;
using System.Collections;

public class characterButton : MonoBehaviour {

	public GameObject falcon;
	public GUISkin customSkin;

	
	
	private Rect FpsRect ;
	private string frpString;


	

	void Start () 
	{
	
			}

    void OnGUI()
    {
        GUI.skin = customSkin;

        GUI.Box(new Rect(0, 0, 720, 80), "");

        if (GUI.Button(new Rect(30, 20, 70, 30), "IdleFly"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleFly");
        }

        if (GUI.Button(new Rect(105, 20, 70, 30), "FindFeed"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_FindFeed");
        }

        if (GUI.Button(new Rect(180, 20, 70, 30), "ViolentAssault"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_ViolentAssault");
        }
        if (GUI.Button(new Rect(255, 20, 70, 30), "Attack"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_Attack");

        }
        if (GUI.Button(new Rect(330, 20, 70, 30), "Damage"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_Damage");

        }
        if (GUI.Button(new Rect(405, 20, 70, 30), "Falling"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_Falling");
        }

        if (GUI.Button(new Rect(480, 20, 70, 30), "Dead"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Once;
            falcon.GetComponent<Animation>().CrossFade("FA_Dead");
        }
        if (GUI.Button(new Rect(555, 20, 70, 30), "IdleLand"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleLand");
        }
        if (GUI.Button(new Rect(630, 20, 70, 30), "LandFly"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_LandFly");
        }


        if (GUI.Button(new Rect(20, 580, 140, 40), "Ver 1.0"))
        {
            falcon.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            falcon.GetComponent<Animation>().CrossFade("FA_IdleFly");
        }



    }
	
	// Update is called once per frame
	void Update () 
	{
		
	
	if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

	}





	
}
