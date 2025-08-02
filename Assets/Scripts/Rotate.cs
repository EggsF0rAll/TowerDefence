using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotationspeed = new Vector3(0, 10f, 0);

    void LateUpdate()
    {
        transform.Rotate(_rotationspeed * Time.deltaTime, Space.Self);
    }
}
