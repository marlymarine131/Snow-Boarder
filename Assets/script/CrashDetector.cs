using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float delayTime = 2f;
    [SerializeField] AudioClip crashSFX;
    [SerializeField] ParticleSystem crashSystem;

    bool hasCrash = false;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Ground" && !hasCrash)
        {
            FindObjectOfType<PlayerRotation>().disableControl();
            crashSystem.Play();
            hasCrash = true;
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
