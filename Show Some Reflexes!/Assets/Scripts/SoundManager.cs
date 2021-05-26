using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip letsGo;
    public AudioClip getReady;
    public AudioClip yeah;
    public AudioClip youLose;

    public bool you;

    
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LetsGo()
    {
            audioSource.PlayOneShot(letsGo);
    }
    public void GetReady()
    {
            audioSource.PlayOneShot(getReady);
    }
    public void Yeah()
    {
            audioSource.PlayOneShot(yeah);
    }
    public void YouLose()
    {
        if (you)
        {
            audioSource.PlayOneShot(youLose);
            you = false;
        }
    }
}
