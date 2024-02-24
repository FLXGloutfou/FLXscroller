using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform target; // R�f�rence au transform du personnage � suivre
    public float smoothSpeed = 0.125f; // Vitesse de suivi de la cam�ra

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
