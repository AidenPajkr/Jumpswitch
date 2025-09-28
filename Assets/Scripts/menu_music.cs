using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_music : MonoBehaviour
{
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.volume = 0f;
        StartCoroutine(Fade(true, source, 2f, 0.25f));
        StartCoroutine(Fade(false, source, 2f, 0.25f));
    }

    private void Update()
    {
        if (!source.isPlaying)
        {
            source.Play();
            StartCoroutine(Fade(true, source, 2f, 0.25f));
            StartCoroutine(Fade(false, source, 2f, 0.25f));
        }
    }

    public IEnumerator Fade(bool fadeIn, AudioSource source, float duration, float targetVolume)
    {
        if(!fadeIn)
        {
            double lenghtOfSource = (double)source.clip.samples / source.clip.frequency;
            yield return new WaitForSecondsRealtime((float)(lenghtOfSource - duration));
        }

        float time = 0f;
        float startVol = source.volume;
        while (time < duration)
        {
            time += Time.deltaTime;
            source.volume = Mathf.Lerp(startVol, targetVolume, time / duration);
            yield return null;
        }

        yield break;
    }
}
