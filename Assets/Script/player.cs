using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 0.05f;
    public Vector3[] CheckPoint;
    public int target;
    public float angle = -90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTo();
    }
    void MoveTo()
    {
        Vector3 targetPosition = CheckPoint[target];
        transform.position = Vector3.MoveTowards(transform.position, targetPosition,Speed);
        
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            target++;
            transform.Rotate(Vector3.up, angle);
            if (target >= 4)
            {
                target = 0;
            }
        }
    }
}
