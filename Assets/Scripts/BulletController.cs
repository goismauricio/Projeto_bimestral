using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject;

        if (hit.CompareTag("Part1"))
        {
            Debug.Log("Part1");
            HistoryController.historia = 1;
            Destroy(hit);
        }
        else if (hit.CompareTag("Part2"))
        {
            Debug.Log("Part2");
            HistoryController.historia = 2;
            Destroy(hit);
        }
        else if (hit.CompareTag("Part3"))
        {
            Debug.Log("Part3");
            HistoryController.historia = 3;
            Destroy(hit);
        }
        else if (hit.CompareTag("Part4"))
        {
            Debug.Log("Part4");
            HistoryController.historia = 4;
            Destroy(hit);
        }
        
        //Destroy(gameObject);
    }
}
