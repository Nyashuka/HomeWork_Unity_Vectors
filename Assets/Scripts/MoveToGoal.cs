using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    [SerializeField] private Transform _goal;

    [SerializeField] private float _speed;
    [SerializeField] private float _accuracy;

    private void Update()
    {
        Vector3 direction = _goal.position - transform.position;
        transform.LookAt(_goal.position);

        Debug.DrawRay(transform.position, direction, Color.red);

        if(direction.magnitude > _accuracy)
        {
            transform.Translate(direction.normalized * _speed * Time.deltaTime, Space.World);
        }     
    }
}
