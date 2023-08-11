using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener3 : MonoBehaviour
{
	[SerializeField]
	private GameEvent3 gameEvent3;
	[SerializeField]
	private UnityEvent response;

	private void OnEnable()
	{
		gameEvent3.RegisterListener(this);
	}

	private void OnDisable()
	{
		gameEvent3.UnregisterListener(this);
	}

	public void OnEventRaised()
	{
		response.Invoke();
	}
}
