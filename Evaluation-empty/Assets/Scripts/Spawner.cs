using UnityEngine;

public class Spawner : MonoBehaviour
{
    public BoxCollider2D playZone;
    //private Vector2 tempMinSpawnPos;
    //private Vector2 tempMaxSpawnPos;
    public GameObject Fruit;

    private void Start()
    {
        playZone = GetComponent<BoxCollider2D>();
        var tempMinSpawnPos = playZone.bounds.min;
        var tempMaxSpawnPos = playZone.bounds.max;
        var maxSpawnPos = Vector2Int.FloorToInt(tempMaxSpawnPos);
        var minSpawnPos = Vector2Int.CeilToInt(tempMinSpawnPos);
        var max = (Vector2)maxSpawnPos;
        var min = (Vector2)minSpawnPos;
        //minSpawnPos = new Vector2Int(-17, -9);
        //maxSpawnPos = new Vector2Int(17, 9);
        //convert to vector2?
    }

    public void SpawnFruit()
    {
        //int randomPostion = UnityEngine.Random.Range(minSpawnPos, maxSpawnPos);
        //Instantiate(Fruit, randomPostion, Quaternion.identity); AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    }

}
