using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    [Tooltip("Step size")]
    [SerializeField]
    float step = 0.10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Movement function using the arrow keys
    void MovePlayer()
    {
        Vector3 move = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            move.y = step;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if ((Input.GetKey(KeyCode.S)))
        {
            move.y = -step;
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if ((Input.GetKey(KeyCode.D)))
        {
            move.x = step;
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else if ((Input.GetKey(KeyCode.A)))
        {
            move.x = -step;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        transform.position += move;
    }
}