using UnityEngine;
using System.Collections;

public class Application : MonoBehaviour {
    
    void Awake()
    {
        new ApplicationFacade().startup(this);
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
