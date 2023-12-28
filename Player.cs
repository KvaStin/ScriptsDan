using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;

    public GameObject fireballPrefab;

    public Transform attackPoint;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье Игрока" + health);
    }
}
