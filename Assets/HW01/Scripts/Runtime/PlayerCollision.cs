using UnityEngine;

namespace HW01.Scripts.Runtime
{
    [RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
    public class PlayerCollision : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
                Debug.Log($"Player collided with {collision.gameObject.name}");
        }
    }
}
