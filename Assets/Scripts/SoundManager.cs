using UnityEngine;
using UnityEngine.Rendering;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        if (audioSource != null)
        {
            Debug.Log("Sound Played");
            audioSource.Play();
        }
    }
}
