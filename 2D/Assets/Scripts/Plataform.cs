using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public Transform[] Targets;
    public int tragetIndex = 0;
    // Start is called before the first frame update
    private float speed = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }
    void MoveToTarget()
    {
        float distance = Vector3.Distance(transform.position, Targets[tragetIndex].position);

        if (distance <= 0)
        {
            GetNextTarget();
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, Targets[tragetIndex].position, (Time.deltaTime * speed) / distance);
        }

    }
    void GetNextTarget()
    {
        tragetIndex++;
        tragetIndex = tragetIndex % Targets.Length;
    }
}
