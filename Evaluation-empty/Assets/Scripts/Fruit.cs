using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Spawner spawner;

    private void Start()
    {
        spawner = GetComponent<Spawner>(); 
    }
}
