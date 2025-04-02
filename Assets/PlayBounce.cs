using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBounce : MonoBehaviour
{
    AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent <AudioSource>();

    }
    public void PlayBounceSound()
    {
        if (m_AudioSource != null)
        {
            m_AudioSource.Play();
        }
    }
}
