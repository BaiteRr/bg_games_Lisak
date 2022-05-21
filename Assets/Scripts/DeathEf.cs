using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEf : MonoBehaviour
{
    public ParticleSystem destrEf;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!Protect.isPressed)
            {
                destrEf.Play();
            }
        }
    }
}
