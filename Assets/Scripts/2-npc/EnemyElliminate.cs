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

    // Activate Death animation.
    public void Elliminate() {
        // check if alive so the animation will be activated once.
        if (alive) {
            actions.Death();
            // Destroy the enemy object, we do not need corps.
            Destroy(gameObject, 5f);
            alive = false;
        }
    }
}