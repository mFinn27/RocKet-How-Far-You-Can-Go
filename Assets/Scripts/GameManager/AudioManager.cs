using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicAudioSource;
    public AudioSource sfxAudioSource;

    public AudioClip musicClip;
    public AudioClip pointClip;
    public AudioClip gameOverClip;

    private void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

    public void playSFX(AudioClip sfxClip)
    {
        sfxAudioSource.clip = sfxClip;
        sfxAudioSource.PlayOneShot(sfxClip);
    }

    public void StopMusic()
    {
        musicAudioSource.Stop();
    }
}
