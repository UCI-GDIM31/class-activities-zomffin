using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Apple;

public class DeerW5 : MonoBehaviour
{
    NavMeshAgent deerAgent;
    [SerializeField] Transform destination;


    private void Start()
    {
        deerAgent = GetComponent<NavMeshAgent>();

        deerAgent.SetDestination(destination.position);
        
    }
}


// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...