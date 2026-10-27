using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("오디오 소스")]
    [SerializeField] private AudioSource bgmSource;
    [SerializeField] private AudioSource sfxSource;
    
    [Header("오디오 클립")]
    [SerializeField] private AudioClip BGM;
    [SerializeField] private AudioClip sfxCorrectSound;
    [SerializeField] private AudioClip sfxSelectSound;
    [SerializeField] private AudioClip sfxErrorSound;
    [SerializeField] private AudioClip sfxCelebrateSound;

    public static SoundManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
        PlayBGM();
    }
    
    public void PlayBGM()
    {
        bgmSource.clip = BGM;
        bgmSource.loop = true;
        bgmSource.Play();
    }

    public void StopBGM()
    {
        bgmSource.Stop();
    }

    public void PlayCorrectSound()
    {
        sfxSource.PlayOneShot(sfxCorrectSound);
    }

    public void PlayErrorSound()
    {
        sfxSource.PlayOneShot(sfxErrorSound);
    }

    public void PlaySelectSound()
    {
        sfxSource.PlayOneShot(sfxSelectSound);
    }

    public void PlayCelebrateSound()
    {
        sfxSource.PlayOneShot(sfxCelebrateSound);
    }
}
