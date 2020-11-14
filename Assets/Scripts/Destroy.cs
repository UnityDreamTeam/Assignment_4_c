using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float time = 2f; //time in seconds to destroy the bullet
    void Start() {
        Destroy(gameObject, time);
    }
        
    
}
