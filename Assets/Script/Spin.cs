using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 rotation;
    void Update()
    {
        this.transform.Rotate(rotation * 1 * Time.deltaTime);
    }
}
