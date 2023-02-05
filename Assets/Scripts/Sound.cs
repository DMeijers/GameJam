using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New sound", menuName = "Audio/Sound")]
public class Sound : ScriptableObject
{
    public string Id;
    public AudioClip Clip;

    [Range (0f, 1f)]
    public float Volume = 0.5f;

    [Range (0.1f, 3f)]
    public float Pitch = 1f;

    public bool Loop;

    [HideInInspector]
    public AudioSource Source;
}
