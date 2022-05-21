using UnityEngine;
using System.Collections;
public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] private Vector3 dPos;
    private bool _open;
    public AudioClip impact;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Operate()

    {
        if (_open)
        {
            Vector3 pos = transform.position - dPos;
            transform.position = pos;
            audioSource.PlayOneShot(impact, 0.7F);
        }
        else
        {
            Vector3 pos = transform.position + dPos;
            transform.position = pos;
            audioSource.PlayOneShot(impact, 0.7F);
        }
        _open = !_open;
    }
}