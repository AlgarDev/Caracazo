using UnityEngine;

public class FixedRotation : MonoBehaviour
{

    private Quaternion iniRot;
    private void Start()
    {
        iniRot = transform.rotation;
    }

    private void LateUpdate()
    {
        transform.rotation = iniRot;
    }
}
