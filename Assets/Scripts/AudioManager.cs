using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private Sound[] _sounds;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        foreach(var sound in _sounds)
        {
            AudioSource source = gameObject.AddComponent<AudioSource>();
            sound.Source = source;
            source.clip = sound.Clip;
            source.volume = sound.Volume;
            source.pitch = sound.Pitch;
            source.loop = sound.Loop;
        }
    }

    public void play(string id)
    {
        Sound s = Array.Find(_sounds, sound => sound.Id == id);

        if(s == null)
        {
            Debug.LogWarning($"Sound with id {id} no found");
            return;
        }

        s.Source.Play();
    }

    public void stop(string id)
    {
        Sound s = Array.Find(_sounds, sound => sound.Id == id);

        if (s == null)
        {
            Debug.LogWarning($"Sound with id {id} no found");
            return;
        }

        s.Source.Stop();
    }

}
