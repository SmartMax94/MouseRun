using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{

    [SerializeField] GameObject _bricksEffectPrefab;



    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            playerModifier.HitBarrier();
            Destroy(gameObject);
           

            }
        }
    }