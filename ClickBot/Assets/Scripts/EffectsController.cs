using UnityEngine;

/// <summary>
/// Creating instance of particles from code with no effort
/// </summary>
public class EffectsController : MonoBehaviour
{
	/// <summary>
	/// Singleton
	/// </summary>
	public static EffectsController Instance;
	
	public ParticleSystem particleEffect;
	public ParticleSystem glowEffect;
	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of EffectsController!");
		}
		
		Instance = this;
	}
	
	/// <summary>
	/// Create an explosion at the given location
	/// </summary>
	/// <param name="position"></param>
	public void Explosion(Vector3 position)
	{
		// Smoke on the water
		instantiate(particleEffect, position);
		
		// Tu tu tu, tu tu tudu
		
		// Fire in the sky
		instantiate(glowEffect, position);
	}
	
	/// <summary>
	/// Instantiate a Particle system from prefab
	/// </summary>
	/// <param name="prefab"></param>
	/// <returns></returns>
	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate(
			prefab,
			position,
			Quaternion.identity
			) as ParticleSystem;
		
		// Make sure it will be destroyed
		Destroy(
			newParticleSystem.gameObject,
			newParticleSystem.startLifetime
			);
		
		return newParticleSystem;
	}
}