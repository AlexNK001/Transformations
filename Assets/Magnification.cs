using UnityEngine;

public class Magnification : MonoBehaviour
{
    [SerializeField] private float _rateOfIncrease;

    void Update()
    {
        float normalizedRateOfIncrease = _rateOfIncrease * Time.deltaTime;
        Vector3 vector3 = new(normalizedRateOfIncrease, normalizedRateOfIncrease, normalizedRateOfIncrease);
        transform.localScale += vector3;
    }
}