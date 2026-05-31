using UnityEngine;

public class NaviController : MonoBehaviour
{
    [SerializeField] 
    private Transform[] patrolPoints;
    [SerializeField] 
    private float speed;

    [SerializeField]
    private int currentIndex;
    private bool moving = false;

    void Update()
    {
        if (moving == false) 
        {
            return;
        }

        Transform target = patrolPoints[currentIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.05f)
        {
            moving = false; 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == false) 
        {
            return;
        }
        if (moving == true) 
        {
            return;         
        }
        if (currentIndex >= patrolPoints.Length - 1) 
        {
            return; 
        }
        currentIndex++;  
        moving = true;
    }
}
