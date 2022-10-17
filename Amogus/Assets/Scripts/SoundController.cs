using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField]
    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        foreach(Sound s in sounds) {
            s.source.Play();
        }
    }

    void Start() {
        Play("Background1");
    }

    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
