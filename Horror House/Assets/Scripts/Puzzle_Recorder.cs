using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Recorder : MonoBehaviour
{

    public AudioSource source;
    public AudioClip[] sounds;
    void Start() {
        sounds = Resources.LoadAll<AudioClip>("Keypad");
        
    }
    public void PlaySequence() {
        StartCoroutine(GenerateSequence());
    }

    IEnumerator GenerateSequence() {
        yield return null;
        AudioClip sound = sounds[0];
        for (int i = 0; i < Puzzle_Passcode.passcode.Length; i++) {
            switch(Puzzle_Passcode.passcode[i]) {
                case '1':
                    sound = sounds[0];
                    break;
                case '2':
                    sound = sounds[1];
                    break;
                case '3':
                    sound = sounds[2];
                    break;
                case '4':
                    sound = sounds[3];
                    break;
                case '5':
                    sound = sounds[4];
                    break;
                case '6':
                    sound = sounds[5];
                    break;
                case '7':
                    sound = sounds[6];
                    break;
                case '8':
                    sound = sounds[7];
                    break;
                case '9':
                    sound = sounds[8];
                    break;
            }
            source.clip = sound;
            source.Play();
            while(source.isPlaying) {
                yield return null;
            }
        }
    }
}
