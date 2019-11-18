﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameMenu : MonoBehaviour
{
    public void StartNewGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetTerritoryAssigment(int index) {
        GameManager.Instance.TerritoryAssignment = (GameManager.AssignmentType)index;
    }
}