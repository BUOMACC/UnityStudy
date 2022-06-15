using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스와 함수는 static(정적)으로 선언
public static class GameObjectExtension
{
	public static void ExtensionFunction(this GameObject go)
	{
		Debug.Log("ExtensionFunction()");
	}
}
