using UnityEngine;

public class bulletMover : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float speed = 700f; // bullet speed
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //bullet riginbody2d commponnent
        rb.AddForce(transform.up * speed); // the bullet force keep going
    }


    private void Update()
    {

    }

}
