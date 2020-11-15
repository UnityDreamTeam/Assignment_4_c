using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplotion : MonoBehaviour
{
    [SerializeField] float explotionTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, explotionTime);
    }
}
