﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Bomb"){
            Destroy(coll.gameObject);
       }
    }
}
