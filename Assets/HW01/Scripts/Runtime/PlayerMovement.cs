using UnityEngine;

namespace HW01.Scripts.Runtime
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField] private float moveSpeed = 5f;
        private Rigidbody _rb;
        private Vector3 _input;

        void Awake()
        { 
            _rb = GetComponent<Rigidbody>();
        }
    
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            _input = new Vector3(horizontal,  0f, vertical);
        }
        void FixedUpdate()
        {
            Move();
        }

        void Move()
        {
            Vector3 move = _input.normalized * (moveSpeed * Time.deltaTime);
            _rb.MovePosition(_rb.position + move);
        }
    }
}