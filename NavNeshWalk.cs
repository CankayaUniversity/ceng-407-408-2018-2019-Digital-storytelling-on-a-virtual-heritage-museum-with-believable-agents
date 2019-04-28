using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class LittleGirlWalk : MonoBehaviour
{
    public Transform Destination;
    public Transform Destination2;
    public Transform Destination3;
    public Transform Destination4;

    private NavMeshAgent _agent;
    //private Animator _anim;
    // Start is called before the first frame update
    void OnEnable()
    {
        _agent = GetComponent<NavMeshAgent>();
        //_anim = GetComponent<Animator>();
        //_anim.Play("Standing Idle");
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


        if (!_agent.pathPending)
        {
            if (_agent.pathStatus == NavMeshPathStatus.PathComplete)
            {
                if (Vector3.Distance(Destination2.position, transform.position) <= 2.0f)
                {
                    _agent.destination = Destination3.position;
                }
                if (Vector3.Distance(Destination.position, transform.position) <= 2.0f)
                {
                    Debug.Log("arrived at destination 1");
                    //_anim.Play("Standing Idle");
                    _agent.destination = Destination2.position;

                }
                if (Vector3.Distance(Destination3.position, transform.position) <= 2.0f)
                {
                    _agent.destination = Destination4.position;
                }
            }
        }
    }


    public void WalkToDestination()
    {
        _agent.destination = Destination.position;
        //_anim.Play("Walking 1");
        Debug.Log("go");
    }

}
