using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyElliminate : MonoBehaviour {
    // Start is called before the first frame update
    private bool alive;
    private Actions actions;

    private void Start() {
        alive = true;
        actions = GetComponent<Actions>();
        actions.Aiming();

    }

    public void Elliminate() {
        if (alive) {
            actions.Death();
            Destroy(gameObject, 5f);
            alive = false;
        }
    }
}