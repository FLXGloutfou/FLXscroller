using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform target; // Référence au transform du personnage à suivre
    public float smoothSpeed = 0.125f; // Vitesse de suivi de la caméra

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
