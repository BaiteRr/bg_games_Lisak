using UnityEngine;
using System.Collections;

public class DestrpyPlayer : MonoBehaviour
{
    public GameObject Player;
    public Color NewPlayer, OldPlayer;
    [NonReorderable] public static bool isDestroy;

    private void Update()
    {
        PlayerColor();        
    }

    private void PlayerColor()
    {
        if (Protect.isPressed)
        {
            GetComponent<MeshRenderer>().material.color = NewPlayer;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = OldPlayer;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("DeathZone"))
        {            
            if (!Protect.isPressed)
            {
                Destroy(Player);
                isDestroy = true;
            }
        }
    }    
}
