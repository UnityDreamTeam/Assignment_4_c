﻿using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        Destroy(gameObject);   
    }
}
