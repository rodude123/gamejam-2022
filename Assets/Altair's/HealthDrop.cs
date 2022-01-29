using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{

    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _healthDrop;
    [SerializeField] private PlayerHealth playerHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _player)
        {
            _player.GetComponent<PlayerHealth>().HealthRecovery();
            Destroy(gameObject);
            
        }
    }
}
