//Originating from PUCRS Unity3D Pool
//https://github.com/fgrehm/pucrs-unity3d-pool
//For use in LMSC-281 Logic and Programming
//Audio Assignment
//Fall 2015 Jeanine Cowen

public interface IGameObjectState {
	void Update();
	void FixedUpdate();
	void LateUpdate();
}