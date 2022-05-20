using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class SnakeController : MonoBehaviour
{
    private bool isAlive = true;
    public float timeBeforeMove;
    Rigidbody2D emptySpace;
    Vector2 position;


    public void Awake()
    {
        StartCoroutine(Move());
    }

    public IEnumerator Move()
    {
        emptySpace = gameObject.AddComponent<Rigidbody2D>();
        while (isAlive == true)
        {
            yield return new WaitForSeconds(timeBeforeMove);
            emptySpace.MovePosition(emptySpace.position + position * timeBeforeMove);
            
        }


    }


    public void OnMove(InputAction.CallbackContext context)
    {
        var position = new Vector2();
        var currentInput = Vector2Int.RoundToInt(position);
    }
}
