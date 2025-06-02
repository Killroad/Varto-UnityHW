using UnityEngine;
using UnityEngine.InputSystem;

namespace HW01.Scripts.Runtime
{
    public class LocationBuilder : MonoBehaviour
    {
        void Start()
        {
            CreateCharacter(new Vector3(2f, 0f, 2f));
        }

        void CreateCharacter(Vector3 position)
        {
            GameObject character = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            character.name = "Character";
            
            character.transform.position = position;
            
            Rigidbody  rb = character.AddComponent<Rigidbody>();
            rb.useGravity = false;
            
            character.AddComponent<PlayerMovement>();
            character.AddComponent<PlayerCollision>();
        }
    }
}
