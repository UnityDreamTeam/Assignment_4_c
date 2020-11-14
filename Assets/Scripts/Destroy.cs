using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject impactEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(impactEffect,transform.position,Quaternion.identity);
        
        Destroy(gameObject);
        
    }
}
