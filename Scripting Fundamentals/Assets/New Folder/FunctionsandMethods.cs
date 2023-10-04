using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsandMethods : MonoBehaviour
{
    // Functions are blocks of code that perform specific task and are not associated with any specific object or class. They can be called and executed independently.

    // Methods, on the other hand, are functions that are assopciated with a specific object or class. They can be caloled and executed on instances odf that object or class.

    //declare our variables
    private AudioSource _audioSource;
    private float _speed = 10f;
    private int _playerHealth
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Creating some simple functions

    // Function to play a sound effect
    private void PlaySoundEffect(AudioClip soundEffect)
    {
        _audioSource.PlayOneShot(soundEffect);
    }

    // Function to detect Triggers
    private void OnTriggerEnter(Collider other)
    {
        
    }

    // Creating some simple methods

    // Methode to move the enemy
    private void MoveEnemy()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    // Method to return a value
    public int PlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;

        return _playerHealthAmount;
    }
}
