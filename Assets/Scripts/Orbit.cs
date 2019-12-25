using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]
    Transform pivot;

    [SerializeField]
    float orbitSpeed = 30.0f;

    void LateUpdate()
    {
        transform.RotateAround(pivot.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
