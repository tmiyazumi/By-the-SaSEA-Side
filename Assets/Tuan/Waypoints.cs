using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    float rotationSpd = 2f;
    public float speed;
    float wpRadius = 0.5f;
    // Start is called before the first frame update

    void rotateTowards(Vector3 to)
    {
        Vector3 pos = transform.position;
        Vector3 test = new Vector3(90, 0, 0);

        Quaternion _lookRotation =
            Quaternion.LookRotation((to - transform.position).normalized);

        _lookRotation *= Quaternion.Euler(0, 90, 0);

        //over time
        transform.rotation =
            Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * rotationSpd);

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < wpRadius)
        {

            current = Random.Range(0, waypoints.Length);

        }
        rotateTowards(waypoints[current].transform.position);
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
