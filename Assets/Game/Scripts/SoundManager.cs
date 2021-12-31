using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private List<AudioClip> audioList;
    [SerializeField] private AudioClip noooAudioClip;

    public static SoundManager Instance { get; private set; }
    private static AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        int i = UnityEngine.Random.Range(0, 3);
        audioSource.volume = .8f;
        audioSource.PlayOneShot(audioList[i]);
    }
    public void PlayNooooo()
    {
        audioSource.volume = .1f;
        audioSource.PlayOneShot(noooAudioClip);
    }
}
