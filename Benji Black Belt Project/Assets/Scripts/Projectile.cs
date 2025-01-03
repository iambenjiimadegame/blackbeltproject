using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public EnemyShoot direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
}
