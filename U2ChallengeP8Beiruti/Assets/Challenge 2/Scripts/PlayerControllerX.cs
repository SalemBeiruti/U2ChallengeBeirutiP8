﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField] float dogCooldown;
    float coolTimer = Mathf.Infinity;

    void Update()
    {
        coolTimer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && coolTimer >= dogCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolTimer = 0;
        }
    }
}
