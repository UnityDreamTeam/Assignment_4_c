using UnityEngine;

public class weapon1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform firePoint;
    public GameObject shootPrefab;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Fire();
        }
    }

    private void Fire()
    {
        Instantiate(shootPrefab, firePoint.position,transform.rotation);
    }
}
