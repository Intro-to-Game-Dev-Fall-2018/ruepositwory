using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	void Start()
	{
		coroutine = Move(Vector2.Up);
		StartCoroutine(coroutine);
	}

	private IEnumerator Move(Vector2 direction)
	{
		transform.position += direction;
		//Wait time is the duration between snakes' moves
		yield return new WaitForSeconds(0.5f);
	}
}