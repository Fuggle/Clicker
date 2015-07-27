using UnityEngine;
using System.Collections;
using AssemblyCSharp;

/// <summary>
/// Unit controller for all major behaviours of placeable units, attached to every unit in the game.
/// </summary>
public class SentinalScript : MonoBehaviour {
	public int cost;
	public Health hp;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update() {
		// ...
		
		// 5 - Shooting
		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");
		// Careful: For Mac users, ctrl + arrow is a bad idea
		
		if (shoot)
		{
			Debug.Log("SHOOTING POOP OOPO OPOOP");
			AttackScript weapon = GetComponent<AttackScript>();
			if (weapon != null)
			{
				// false because the player is not an enemy
				weapon.Attack(false);
			}
		}
		
		// ...
	}
}
