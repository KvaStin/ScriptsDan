using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������ ������ ���� ������� NPC �� �����
        transform.position = Vector3.MoveTowards(transform.position,target.position, speed * Time.deltaTime);

        //������������� ������ ���� NPC ����� � ����
        transform.LookAt(target.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Player player = other.GetComponent<Player>();
            player.TakeDamage(playerDamage);
        }
        
    }
}
