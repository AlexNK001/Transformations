using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 direction = new(_speed * Time.deltaTime, 0, 0);
        gameObject.transform.position += direction;
    }
}