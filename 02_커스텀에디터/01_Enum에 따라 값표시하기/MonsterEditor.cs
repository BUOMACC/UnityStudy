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

		// Type�� Archer�� ��쿡�� ����ü�ӵ� �ʵ带 ǥ��
		if (monster.type == Monster.MonsterType.Archer)
		{
			EditorGUILayout.BeginHorizontal();
			monster.projectileSpeed = EditorGUILayout.FloatField("Projectile Speed", monster.projectileSpeed);
			EditorGUILayout.EndHorizontal();
		}

		// �� ���¹�ư (��ư�� GUILayout�� ����)
		// - GUILayout�� EditorGUILayout�� ���� ���̰� ����,
		//   EditorGUILayout�� ������ ������ �� ������ ����������
		if (GUILayout.Button("Reset Property"))
		{
			monster.ResetData();
		}
	}
}
