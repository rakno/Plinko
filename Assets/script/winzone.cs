using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class winzone : MonoBehaviour
{
    AudioSource audioSrc;
    // Start is called before the first frame update


    void Awake()
    {

        audioSrc = gameObject.GetComponent<AudioSource>();
        audioSrc.Stop();

    }
    private void OnTriggerEnter(Collider other)
    {

      audioSrc.Play();
    }
}
