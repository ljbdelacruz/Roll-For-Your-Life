using UnityEngine;
using System.Collections;

public class DetectGameObjectCollision : MonoBehaviour {
    
    public GameObject objectToRemove;
    public GameObject enemy;
    public bool isFinish;

    private bool isDead = false;
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Enemy")
        {
            this.isDead = true;
            this.objectToRemove.SetActive(false);
        }
        else if (col.gameObject.name == "Fence_0" && objectToRemove.name == "Player" || col.gameObject.name == "Fence_1" && objectToRemove.name == "Player")
        {
            if (this.objectToRemove.transform.position.z - this.enemy.transform.position.z > 150f)
            {
                this.enemy.transform.position = new Vector3(this.enemy.transform.position.x, this.enemy.transform.position.y, this.objectToRemove.transform.position.z - 150);
            }
        }
        else if (col.gameObject.name == "FinishLine" && objectToRemove.name == "Player") {
            isFinish = true;
        }
    }
    public bool checkIsDead() {
        return this.isDead;
    }
}
