using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float delayTime = 2f;
    [SerializeField] ParticleSystem crashSystem;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            crashSystem.Play();
            Invoke("ReloadScene",delayTime);            
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
