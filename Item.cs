using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject prefab;
    private void Start()
    {
        Destroy(this.gameObject, 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.points++;
            GameObject effect = Instantiate(prefab, transform.position, transform.rotation);
            Destroy(effect, 5f);
            Destroy(this.gameObject);
        }
    }
}
