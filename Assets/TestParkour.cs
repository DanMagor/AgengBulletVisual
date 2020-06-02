using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestParkour : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    [SerializeField] private float speed = 1f;
    private bool isTrick = false;
    // Update is called once per frame
    void Update()
    {
        if (isTrick) return;
        transform.position += transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Obstacle"))
        {
            return;
        }
        isTrick = true;
        GetComponent<Animator>().SetTrigger("Dash");
    }
}
