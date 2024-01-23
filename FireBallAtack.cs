using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallAtack : MonoBehaviour
{
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
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
