using UnityEngine;

public class DestroyPlayer2 : MonoBehaviour
{
    [SerializeField] public int life = 3;
    [SerializeField] public GameObject explode;
    [SerializeField] GameObject RespawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explode, transform.position, Quaternion.identity);
        Destroy(gameObject); // destroy the player
        life--; // life going down
        if (life > 0) // if i still have life
        {
            //get the clone and enable all the commponnents
            GameObject clone = Instantiate(gameObject, RespawnPoint.transform.position, Quaternion.identity);
            clone.GetComponent<MovePlayer2>().enabled = true;
            clone.GetComponent<weapon2>().enabled = true;
            clone.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
