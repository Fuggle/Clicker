using UnityEngine;
using System.Collections;
using AssemblyCSharp;

/// <summary>
/// Unit controller for all major behaviours of placeable units, attached to every unit in the game.
/// </summary>
public class BaseUnit : MonoBehaviour {
	public int cost;
	public int health;
	public string name;
	public string desc;
	ArrayList skills = new ArrayList();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
