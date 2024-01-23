using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    public int coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CoinCollect()
    {
        coin++;
    }
}
