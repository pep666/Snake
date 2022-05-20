using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class SnakeController : MonoBehaviour
{
    private bool isAlive = true;
    public float timeBeforeMove;
    Rigidbody2D emptySpace;
    Vector2 position;
    public GameObject TailPart;


    public void Start()
    {
        new GameObject("Tail");
        var tail = GameObject.Find("Tail").transform.parent;
        Instantiate(TailPart, new Vector3(1, 0, 0), Quaternion.identity);

        StartCoroutine(Move());
    }

    public IEnumerator Move()
    {
        emptySpace = gameObject.AddComponent<Rigidbody2D>();
        while (isAlive == true)
        {

            yield return new WaitForSeconds(timeBeforeMove);
            emptySpace.MovePosition(emptySpace.position + position * timeBeforeMove);
            //yield return new WaitForFixedUpdate(); mais ou?
        }


    }


    public void OnMove(InputAction.CallbackContext context)
    {
        var position = new Vector2();
        var currentInput = Vector2Int.RoundToInt(position);
    }


}
