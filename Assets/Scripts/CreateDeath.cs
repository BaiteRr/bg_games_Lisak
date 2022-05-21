using System.Collections;
using UnityEngine;

public class CreateDeath : MonoBehaviour
{
    public GameObject plane;
    private bool isStart;

    private void Update()
    {
        if (!isStart)
        {
            StartCoroutine(CreatePlane());
            isStart = true;
        }        
    }

    IEnumerator CreatePlane()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(plane, new Vector3(Random.Range(-47f, 47f), 0.01f, Random.Range(-47f, 47f)), Quaternion.identity);
        }
    }
}
