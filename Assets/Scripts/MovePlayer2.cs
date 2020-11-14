using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    [Tooltip("Step size")]
    [SerializeField] float step = 0.10f;
    int lookUp = 0;
    int lookDown = 180;
    int lookRight = 270;
    int lookLeft = 90;
    int lookUpRight = 310;
    int lookUpLeft = 45;
    int lookDownRight = 225;
    int lookDownLeft = 135;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Movement function using the arrow keys and turn the player to curect position
    void MovePlayer()
    {
        Vector3 move = new Vector3();
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            move.y = step;
            move.x = step;
            transform.rotation = Quaternion.Euler(0, 0, lookUpRight);
        }

        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            move.y = step;
            move.x = -step;
            transform.rotation = Quaternion.Euler(0, 0, lookUpLeft);
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            move.y = -step;
            move.x = -step;
            transform.rotation = Quaternion.Euler(0, 0, lookDownLeft);
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            move.y = -step;
            move.x = step;
            transform.rotation = Quaternion.Euler(0, 0, lookDownRight);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            move.y = step;

            transform.rotation = Quaternion.Euler(0, 0, lookUp);
        }
        else if ((Input.GetKey(KeyCode.S)))
        {
            move.y = -step;
            transform.rotation = Quaternion.Euler(0, 0, lookDown);
        }
        else if ((Input.GetKey(KeyCode.D)))
        {
            move.x = step;
            transform.rotation = Quaternion.Euler(0, 0, lookRight);
        }
        else if ((Input.GetKey(KeyCode.A)))
        {
            move.x = -step;
            transform.rotation = Quaternion.Euler(0, 0, lookLeft);
        }

        transform.position += move;
    }
}