using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncingAudio : MonoBehaviour
{
    [SerializeField] private AudioClip bounce_clip;

    private AudioSource _audioSource;
    private Rigidbody _rigidbody;

    private void Awake() 
    {
        _audioSource = this.GetComponent<AudioSource>();
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        _audioSource.PlayOneShot(bounce_clip, _rigidbody.velocity.magnitude);    
    }
}
