using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Effect");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator Effect()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f); //wait half a second
            // do things
        }
    }
}
