using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    private NavMeshAgent player;
    public Transform finish;
    public ParticleSystem win;
    private string[] nameScene = new string[4];

    private void Start()
    {
        player = GetComponent<NavMeshAgent>();
        path();
    }

    void path()
    {
        player.SetDestination(finish.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            win.Play();


            StartCoroutine(newScene());
        }
    }

    IEnumerator newScene()
    {
        nameScene[0] = "Game1";
        nameScene[1] = "Game2";
        nameScene[2] = "Game3";
        nameScene[3] = "Game4";

        yield return new WaitForSeconds(4f);

        SceneManager.LoadScene(nameScene[Random.Range(0, nameScene.Length)]);
    }
}
