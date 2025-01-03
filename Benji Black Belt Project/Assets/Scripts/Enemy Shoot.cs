using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject shot;
    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("shootshot", 1.2f);
        }

        
    }

    public void shootshot()
    {
        offset = transform.localScale.x * new Vector3(-1, 0, 0);
        Vector3 shotPosition = transform.position + offset;
        Instantiate(shot, shotPosition, transform.rotation);
    }
}
