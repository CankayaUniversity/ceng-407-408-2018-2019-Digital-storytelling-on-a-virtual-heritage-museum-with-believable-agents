using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavNeshWalk : MonoBehaviour
{
    public Transform Destination;

    private NavMeshAgent _agent;
    private Animator _anim;
    // Start is called before the first frame update
    void OnEnable()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
        _anim.Play("Standing Idle");
        StartCoroutine(WalkInSeconds(0.4f));
    }

    private IEnumerator WalkInSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        WalkToDestination();
        yield break;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WalkToDestination();
        }

        if (!_agent.pathPending)
        {
            if (_agent.pathStatus == NavMeshPathStatus.PathComplete)
            {
                if (Vector3.Distance(Destination.position, transform.position) <= 0.6f)
                {
                    Debug.Log("arrived");
                    _anim.Play("Standing Idle");
                }
            }
        }
    }

    public void WalkToDestination()
    {
        _agent.destination = Destination.position;
        _anim.Play("Walking 1");
        Debug.Log("go");
    }
}
