using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayEffect : MonoBehaviour {

    public RawImage image;
    public VideoPlayer video;

	// Use this for initialization
	void Start () {
        StartCoroutine(playVideo());
	}
	
    IEnumerator playVideo()
    {
        video.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1);
        while (!video.isPrepared)
        {
            yield return wait;
            break;
        }
        image.texture = video.texture;
        video.Play();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
