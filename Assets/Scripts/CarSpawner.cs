using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    
    private void Awake()
    {
        Instantiate(prefab);
    }
}
