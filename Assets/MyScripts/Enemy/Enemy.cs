using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public GameObject state;
    public GameObject enemy;
    public float speed;
	// Update is called once per frame
	void Update () {
        StateCheck sc = state.GetComponent<StateCheck>();
        if (sc.isPause == false && !sc.isGameOver)
        {
            this.MoveEnemy();
        }
	}
    void MoveEnemy() {
        float z = enemy.transform.position.z;
        z = z + speed;
        enemy.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y, z);
    }
    public void increaseEnemySpeed(float nSpeed) {
        speed += nSpeed;
    }
}
