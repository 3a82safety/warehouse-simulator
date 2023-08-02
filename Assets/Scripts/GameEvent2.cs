using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event 2", menuName = "Game Event 2")]
public class GameEvent2 : ScriptableObject
{
	private List<GameEventListener2> listeners = new List<GameEventListener2>();

	public void Raise()
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
		{
			listeners[i].OnEventRaised();
		}
		ActivateUI.instance.ActiveUI();
	}

	public void RegisterListener(GameEventListener2 listener)
	{
		listeners.Add(listener);
	}

	public void UnregisterListener(GameEventListener2 listener)
	{
		listeners.Remove(listener);
	}
}

