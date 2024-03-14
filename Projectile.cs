using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public GameObject prefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            GameObject effect = Instantiate(prefab, transform.position, transform.rotation);
            Destroy(effect, 5f);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        Destroy(gameObject, 1f);
    }
    private void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
}
