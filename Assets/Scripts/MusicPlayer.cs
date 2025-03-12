using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
  public AudioClip[] musicClips; // Array to store your music clips
  private AudioSource audioSource;
  private int currentTrack = 0;

  private void Start()
  {
    audioSource = GetComponent<AudioSource>();
    PlayNextTrack();
  }

  private void PlayNextTrack()
  {
    if (musicClips.Length == 0) return;
    audioSource.clip = musicClips[currentTrack];
    audioSource.Play();
    Invoke("PlayNextTrack", audioSource.clip.length);
    currentTrack = (currentTrack + 1) % musicClips.Length; // Loop back to the first track
  }
}