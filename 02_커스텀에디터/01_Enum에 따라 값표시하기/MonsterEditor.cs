using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Monster))]
public class MonsterEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		Monster monster = (Monster)target;

		// Type이 Archer인 경우에만 투사체속도 필드를 표시
		if (monster.type == Monster.MonsterType.Archer)
		{
			EditorGUILayout.BeginHorizontal();
			monster.projectileSpeed = EditorGUILayout.FloatField("Projectile Speed", monster.projectileSpeed);
			EditorGUILayout.EndHorizontal();
		}

		// 값 리셋버튼 (버튼은 GUILayout에 있음)
		// - GUILayout과 EditorGUILayout은 거의 차이가 없음,
		//   EditorGUILayout이 에디터 설정에 더 초점이 맞춰져있음
		if (GUILayout.Button("Reset Property"))
		{
			monster.ResetData();
		}
	}
}
