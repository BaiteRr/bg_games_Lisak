using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protect : MonoBehaviour
{
    [NonReorderable] public static bool isPressed;

    private void Update()
    {
        if (isPressed)
        {
            StartCoroutine(GoNext());
        }
    }

    public void PressShield()
    {
        if (!isPressed)
        {
            isPressed = true;            
        }
    }

    IEnumerator GoNext()
    {
        if (isPressed)
        {
            yield return new WaitForSeconds(2f);
            isPressed = false;
        }                   
    }
}
