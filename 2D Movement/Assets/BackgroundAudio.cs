using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    public AudioClip backgroundMusic;
    private bool musicPlayed = false;

    void Update()
    {
        
        if (!musicPlayed)
        {
            
            var audio = gameObject.GetComponent<AudioSource>();
            if (audio == null)
            {
                audio = gameObject.AddComponent<AudioSource>();
                audio.clip = backgroundMusic;
            }

            
            audio.Play();

            
            musicPlayed = true;
        }
    }
}
