using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float scaleMax = 1.3f;
    public float scaleMin = 0.7f;
    public GameObject prefab;
    private void Start()
    {
        randomSize();
    }
    void randomSize()
    {
        float scaleFactor = Random.Range(scaleMin, scaleMax);
        transform.localScale = (Vector2)transform.localScale * scaleFactor;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject effect = Instantiate(prefab, transform.position, transform.rotation);
            Destroy(effect, 5f);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
