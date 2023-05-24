using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject sushi1, sushi2, sushi3, sushi4, sushi5;

    [SerializeField] GameObject Button, Button2;
    



    private void Update()
    {
        SpawnItem();
    }

    public void SpawnItem()
    {
        if (!sushi1.gameObject.activeSelf && !sushi2.gameObject.activeSelf && !sushi3.gameObject.activeSelf && !sushi4.gameObject.activeSelf && !sushi5.gameObject.activeSelf)
        {
            Button.gameObject.SetActive(true);
        }

        if (!Button.gameObject.activeSelf)
        {

             Button2.gameObject.SetActive(true);

        }
        
    }

    
}
