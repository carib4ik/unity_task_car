using UnityEngine;
using UnityEngine.Serialization;

public class CarMoveable : MonoBehaviour
{
    [SerializeField] private float _moveSpead;
    [SerializeField] private float _rotateSpead;
    
    private void Update()
    {
        var position = transform.position;
        var step = Time.deltaTime * _moveSpead;
        
        if (Input.GetKey(KeyCode.W))
        {
            // position.z += step;
            transform.Translate(Vector3.forward * step);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            // position.z -= step;
            transform.Translate(Vector3.back * step);

        }
        
        if (Input.GetKey(KeyCode.A))
        {
            // position.x -= step;
            transform.Rotate(0, -_rotateSpead, 0);

        }
        
        if (Input.GetKey(KeyCode.D))
        {
            // position.x += step;
            transform.Rotate(0, _rotateSpead, 0);
        }
        
        // transform.position = position;

    }
}
