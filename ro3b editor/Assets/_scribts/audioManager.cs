using UnityEngine;

public class audioManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audios;
    AudioSource aud;
    private bool gameClose = false;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            aud.clip = audios[0];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            aud.clip = audios[1];
            aud.Play();
        }
        else if (Input.GetKey(KeyCode.E))
        {
            aud.clip = audios[3];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.R))
        {
            aud.clip = audios[4];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.T))
        {
            aud.clip = audios[5];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.Y))
        {
            aud.clip = audios[6];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.U))
        {
            aud.clip = audios[7];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.I))
        {
            aud.clip = audios[8];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.O))
        {
            aud.clip = audios[9];
            aud.Play();
        }else if (Input.GetKey(KeyCode.A))
        {
            aud.clip = audios[10];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.S))
        {
            aud.clip = audios[11];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.D))
        {
            aud.clip = audios[12];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.F))
        {
            aud.clip = audios[13];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.G))
        {
            aud.clip = audios[14];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.H))
        {
            aud.clip = audios[15];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.J))
        {
            aud.clip = audios[16];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.K))
        {
            aud.clip = audios[17];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.L))
        {
            aud.clip = audios[18];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.Z))
        {
            aud.clip = audios[19];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.Z))
        {
            aud.clip = audios[20];
            aud.Play();
        }
		else if (Input.GetKey(KeyCode.W))
        {
            aud.clip = audios[21];
            aud.Play();
        }
		
		else if (Input.GetKey(KeyCode.Space))
        {
            //aud.clip = audios[33];
            aud.Stop(); 
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            //aud.clip = audios[33];
            //aud.Stop();
            if (!gameClose)
            {
                gameClose = true;
                Application.Quit();
            }
        }
    }
    

} // end class







