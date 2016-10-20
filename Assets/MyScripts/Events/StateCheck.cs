using UnityEngine;
using System.Collections;

public class StateCheck : MonoBehaviour {
    public GameObject gameOver;
    public GameObject menuButton;
    public GameObject player;
    public GameObject enemy;
    public GameObject particle;

    public bool isPause=false;
    public bool isGameOver = false;
    public int timeDifficultyIncrease;
    public GameObject FinishingMessage;
    private int time;
	// Update is called once per frame
	void Update () {
        DetectGameObjectCollision accel = player.GetComponent<DetectGameObjectCollision>();
        if (!accel.isFinish)
        {
            if (accel.checkIsDead())
            {
                this.isGameOver = true;
                this.ShowGameOver();
            }
            if (time == timeDifficultyIncrease)
            {
                this.increaseEnemySpeed();
                time = 0;
            }
            time++;
        }
        else {
            this.worldEnd();
        }
    }
    void ShowGameOver() {
        this.particle.SetActive(false);
        gameOver.SetActive(true);
        menuButton.SetActive(false);
    }
    public void PauseGame() {
        this.isPause = true;
    }
    public void UnpauseGame() {
        this.isPause = false;
    }
    void increaseEnemySpeed() {
        Enemy obj = enemy.GetComponent<Enemy>();
        obj.increaseEnemySpeed(0.01f);
    }
    void worldEnd() {
        this.PauseGame();
        menuButton.SetActive(false);
        FinishingMessage.SetActive(true);
    }


}
