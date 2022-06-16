using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
	public enum MonsterType
	{
		Knight,
		Archer
	}

	public MonsterType type;
	public int hp = 100;
	public int damage = 5;
	[HideInInspector] public float projectileSpeed = 10.0f;

	void Start()
	{
		Debug.Log($"projectileSpeed : {projectileSpeed}");
	}

	public void ResetData()
	{
		type = MonsterType.Knight;
		hp = 100;
		damage = 5;
		projectileSpeed = 10.0f;
	}
}
