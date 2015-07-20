using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int a = 5;

        switch (a)
        {
            case 1:
                Debug.Log("A is 1");
                break;
            case 2:
                Debug.Log("A is 2");
                break;
            default:
                Debug.Log("A is not 1 nor 2");
                break;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
