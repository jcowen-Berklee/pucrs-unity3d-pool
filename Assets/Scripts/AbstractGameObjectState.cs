//Originating from PUCRS Unity3D Pool
//https://github.com/fgrehm/pucrs-unity3d-pool
//For use in LMSC-281 Logic and Programming
//Audio Assignment
//Fall 2015 Jeanine Cowen

using UnityEngine;

public abstract class AbstractGameObjectState : IGameObjectState {
	protected MonoBehaviour parent;
	public AbstractGameObjectState(MonoBehaviour parent) {
		this.parent = parent;
	}

	public virtual void Update() { }
	public virtual void FixedUpdate() { }
	public virtual void LateUpdate() { }
}