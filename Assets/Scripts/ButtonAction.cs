﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
   private void OnMouseUpAsButton() {
       switch (gameObject.name) {
            case "PlayButton":
                SceneManager.LoadScene("RabbitCatchScene");
                break;
            case "CasinoButton":
                SceneManager.LoadScene("SlotScene");
                break;
            case "DoubleButton":
                SceneManager.LoadScene("DoubleScene");
                break;                
       }
   }
}
