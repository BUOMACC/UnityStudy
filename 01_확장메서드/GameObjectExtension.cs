using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ŭ������ �Լ��� static(����)���� ����
public static class GameObjectExtension
{
	public static void ExtensionFunction(this GameObject go)
	{
		Debug.Log("ExtensionFunction()");
	}
}
