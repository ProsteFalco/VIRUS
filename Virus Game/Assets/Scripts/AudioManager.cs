using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;

	public List<Sound> soundtrackList;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			s.source.outputAudioMixerGroup = mixerGroup;

			if (s.name.Contains("soundtrack"))
			{
				soundtrackList.Add(s);
			}
		}
	}

	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		s.source.Play();
	}


	void Start()
	{
		Play(soundtrackList[UnityEngine.Random.Range(0, soundtrackList.Count)].name);
	}


	public void PitchDown()
	{
		foreach (AudioSource y in GetComponents<AudioSource>())
		{
			if (y.isPlaying)
			{
				y.pitch = -1f;
			}
		}
	}
	public void PitchUp()
	{
		foreach (AudioSource y in GetComponents<AudioSource>())
		{
			if (y.isPlaying)
			{
				y.pitch = 1f;
			}
		}
	}

}

