using UnityEngine;

public class MusicBackground : MonoBehaviour {

    [SerializeField] AudioClip[] audios;
    AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            aud.clip = audios[0];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            aud.clip = audios[1];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            aud.clip = audios[2];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            aud.clip = audios[3];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            aud.clip = audios[4];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Alpha6))
        {
            aud.clip = audios[5];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Alpha7))
        {
            aud.clip = audios[6];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            aud.Stop();
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    } // end class 