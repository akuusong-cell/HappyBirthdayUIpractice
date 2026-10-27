using UnityEngine;

public class LastScene : MonoBehaviour
{
    void Awake()
    {
        SoundManager.Instance.PlayCelebrateSound();
        SoundManager.Instance.StopBGM();
    }
}
