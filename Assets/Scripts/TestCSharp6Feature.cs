using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCSharp6Feature : MonoBehaviour {
    private Dictionary<int, string> webErrors = new Dictionary<int, string>
    {
        [404] = "Page not Found",
        [302] = "Page moved, but left a forwarding address.",
        [500] = "The web server can't come out to play today."
    };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
