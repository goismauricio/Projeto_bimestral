using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject;

        if(hit.CompareTag("Part1"))
        {
            HistoryController.historia = 1;
        }

        if(hit.CompareTag("Part2"))
        {
            HistoryController.historia = 2;
        }
        Destroy(hit);
        Destroy(gameObject);
    }
}
