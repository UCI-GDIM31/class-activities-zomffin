using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] Transform player;

    private bool _chase = false;

    private void Update()
    {
        if (!_chase) { return; }
        
        
        transform.position = Vector3.MoveTowards(transform.position, player.position, (speed * Time.deltaTime));
    }
    
    public Vector3 getPosition()
    {
        return this.transform.position;
    }
    public void StartChasing()
    {
        _chase = true;
    }

    public void StopChasing()
    {
        _chase = false;
    }

}
