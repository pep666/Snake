using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class SnakeController : MonoBehaviour
{
    private bool isAlive = true;
    private bool fruitEaten = true;
    public float timeBeforeMove;
    Rigidbody2D emptySpace;
    Vector2 position;
    public GameObject TailPart;
    private int eatenFruits;
    public GameObject GameOver;


    public void Start()
    {
        new GameObject("Tail");
        var tail = GameObject.Find("Tail").transform.parent;
        //Instantiate(TailPart, new Vector3(1, 0, 0), Quaternion.identity);

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
            //AddTailPart();

        }


    }


    public void OnMove(InputAction.CallbackContext context)
    {
        var position = new Vector2();
        var currentInput = Vector2Int.RoundToInt(position);
    }

    public void AddTailPart(Vector2 newPartPosition)
    {
        if(fruitEaten == false)
        {
            return;
        }
        else
        {
            Instantiate(TailPart, newPartPosition, Quaternion.identity);
            fruitEaten = false;
        }
    }

    public void EatFruit()
    {

    }

    public void Die()
    {
        
        if(isAlive == false)
        {
            Instantiate(GameOver);
            Destroy(TailPart);
            return;
        }

    }


}
