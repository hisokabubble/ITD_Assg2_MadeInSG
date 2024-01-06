using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BearChase : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    float speedcap = 100000f;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine("IncreaseSpeedPerSecond", 1f);
    }

    public void Update()
    {
        agent.SetDestination(player.position);
    }

    IEnumerator IncreaseSpeedPerSecond (float waitTime)
    {
        while (agent.speed < speedcap)
        {
            yield return new WaitForSeconds(waitTime);
            agent.speed = agent.speed + 0.3f;
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Lose");
        }
    }
}
