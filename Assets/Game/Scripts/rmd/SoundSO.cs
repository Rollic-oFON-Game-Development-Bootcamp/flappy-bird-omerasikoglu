using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Sound/SoundSO")]
public class SoundSO : MonoBehaviour
{
    [SerializeField] private AudioClip soundAudioClip;
    [SerializeField] private float soundVolume;
    [SerializeField] private float soundTimer;

    public AudioClip SoundAudioClip { get { return soundAudioClip; } }
    public float SoundVolume { get { return soundVolume; } }
    public float SoundTimer { get { return soundTimer; } }
}
