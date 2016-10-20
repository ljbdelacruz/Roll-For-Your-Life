using UnityEngine;
using System.Collections;

public class ParticleMovement : MonoBehaviour {

    public GameObject toFollow;
    public GameObject Particle;
	// Update is called once per frame
	void Update () {
        this.MoveParticle();
	}
    void MoveParticle() {
        Particle.transform.position = new Vector3(Particle.transform.position.x, Particle.transform.position.y, this.toFollow.transform.position.z+35f);
    }


}
