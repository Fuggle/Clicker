using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy generic behavior
/// </summary>
public class EnemyScript : MonoBehaviour
{
	private AttackScript[] weapons;
	
	void Awake()
	{
		// Retrieve the weapon only once
		weapons = GetComponentsInChildren<AttackScript>();
	}
	
	void Update()
	{
		foreach (AttackScript weapon in weapons)
		{
			// Auto-fire
			if (weapon != null && weapon.CanAttack)
			{
				weapon.Attack(true);
			}
		}
	}
}