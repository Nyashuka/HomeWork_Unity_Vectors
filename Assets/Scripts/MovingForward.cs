using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private Vector3 _toward;

    [SerializeField] private float _speed;
 
    private void Update()
    {
        transform.Translate(_toward.normalized * Time.deltaTime * _speed);
    }
}
