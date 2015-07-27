﻿using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class ShotScript : MonoBehaviour
{
	// 1 - Designer variables
	
	/// <summary>
	/// Damage inflicted
	/// </summary>
	public int damage = 1;
	
	/// <summary>
	/// Projectile damage player or enemies?
	/// </summary>
	public bool isEnemyShot = false;
	
	void Start()
	{
		// 2 - Limited time to live to avoid any leak
		Destroy(gameObject, 8); // 20sec
	}
}