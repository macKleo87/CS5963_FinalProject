using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSound : MonoBehaviour {

    //public GameObject trigger;
    public AudioSource audioSource;
    public AudioSource audioAudience;
    private bool collided = false;
    public Image tunnelVision;
    public float growFactor;
    private bool beginTunnel;
    private float timer = 0;
    //public AudioClip audioClip;
    // Use this for initialization
    void Start () {
        //audioSource.clip = audioClip;
        //tunnelVision.transform.localScale = new Vector3(70, 70, 0);
        beginTunnel = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Reload"))
            Application.LoadLevel(0); //or whatever number your scene is

        while (collided && audioAudience.volume >= 0.4f)
        {
            audioAudience.volume -= 0.004f;
        }
        while(beginTunnel && tunnelVision.transform.localScale.y >= 17)
        {
            //timer += Time.deltaTime;
            tunnelVision.transform.localScale -= new Vector3(1f, 1f, 1f) * Time.deltaTime;
            //Debug.Log(tunnelVision.transform.localScale);
            //if(tunnelVision.transform.localScale.y <= 17)
            //{
            //    beginTunnel = false;
            //}
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collided");
        
        //tunnelVision.transform.localScale = new Vector3(14f, 16f, 0);
        if (!collided && other.gameObject.tag == "Player")
        {
            Debug.Log("collided");
            //beginTunnel = true;
            //trigger.SetActive(true); //maybe not necessary
            audioSource.Play();
            collided = true;
            StartCoroutine(waiting(7f));
            //StartCoroutine(ScaleOverTime(3));
        }
    }


    IEnumerator ScaleOverTime(float time)
    {
        Vector3 originalScale = tunnelVision.transform.localScale;
        Vector3 destinationScale = new Vector3(17.0f, 17.0f, 1.0f);

        float currentTime = 0.0f;

        do
        {
            tunnelVision.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);

        //Destroy(gameObject);
    }
    IEnumerator DeScaleOverTime(float time)
    {
        Vector3 originalScale = tunnelVision.transform.localScale;
        Vector3 destinationScale = new Vector3(70f, 70f, 0);

        float currentTime = 0.0f;

        do
        {
            tunnelVision.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);

        //Destroy(gameObject);
    }

    IEnumerator waiting(float seconds)
    {
        yield return new WaitForSeconds(7);
        StartCoroutine(ScaleOverTime(seconds));
        yield return new WaitForSeconds(18);
        StartCoroutine(DeScaleOverTime(seconds));
        yield return new WaitForSeconds(76);
        StartCoroutine(ScaleOverTime(7));
        yield return new WaitForSeconds(16);
        StartCoroutine(DeScaleOverTime(3));
    }

}
