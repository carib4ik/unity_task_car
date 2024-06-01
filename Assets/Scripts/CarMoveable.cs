using UnityEngine;
using UnityEngine.Serialization;

public class CarMoveable : MonoBehaviour
{
    [SerializeField] private float _moveSpead;
    
    private void Update()
    {
        var position = transform.position;
        var step = Time.deltaTime * _moveSpead;
        
        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }
        
        transform.position = position;

    }
}
