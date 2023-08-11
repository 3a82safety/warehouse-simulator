using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event 3", menuName = "Game Event 3")]
public class GameEvent3 : ScriptableObject
{
	private List<GameEventListener3> listeners = new List<GameEventListener3>();

	public void Raise()
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
		{
			listeners[i].OnEventRaised();
		}
		ActivateWrongUI.instance.ActiveUI();
	}

	public void RegisterListener(GameEventListener3 listener)
	{
		listeners.Add(listener);
	}

	public void UnregisterListener(GameEventListener3 listener)
	{
		listeners.Remove(listener);
	}
}

