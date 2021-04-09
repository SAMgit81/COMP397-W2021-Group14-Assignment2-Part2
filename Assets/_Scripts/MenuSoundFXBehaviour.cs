using Assets._Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSoundFXBehaviour : MonoBehaviour
{
    // Declarations for soundfx
    [Header ("Menu SoundFX")]
    public AudioClip onHoverSound;
    public AudioClip onClickSound;

    // Hovering mouse event
    void OnMouseOver() {
        //onHoverSound.Play();
        AudioManager.Instance.Play(onHoverSound, transform);

    }

    // Primary click event
    void OnMouseDown() {
        //onClickSound.Play();
        AudioManager.Instance.Play(onClickSound, transform);

    }
}
