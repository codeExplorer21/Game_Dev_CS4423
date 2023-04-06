using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void coinNoise()
    {
        transform.position = new Vector3(100f, 0, 0);
        audioSource.Play();
    }
}
