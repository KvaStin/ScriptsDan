using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI text;
    public GameObject defeatUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            text.text = player.points.ToString();
        }
        else
        {
            defeatUI.SetActive(true);
        }
    }
    public void OnClickRestart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
