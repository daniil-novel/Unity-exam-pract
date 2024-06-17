using UnityEngine;

public class CollisionInteraction : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Действие при столкновении с другим объектом
        Debug.Log("Collision with " + collision.gameObject.name);
    }
}
