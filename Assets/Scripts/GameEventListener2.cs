using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener2 : MonoBehaviour
{
	[SerializeField]
	private GameEvent2 gameEvent2;
	[SerializeField]
	private UnityEvent response;

	private void OnEnable()
	{
		gameEvent2.RegisterListener(this);
	}

	private void OnDisable()
	{
		gameEvent2.UnregisterListener(this);
	}

	public void OnEventRaised()
	{
		response.Invoke();
	}
}
