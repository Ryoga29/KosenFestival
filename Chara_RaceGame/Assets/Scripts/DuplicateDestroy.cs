﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateDestroy : MonoBehaviour {
    private void OnCollisionEnter(Collision other){
        //かぶったら床系(速度上昇、速度減少)削除する
        if (other.gameObject.tag == "wall"){
            Destroy(gameObject);
        }
    }
}
