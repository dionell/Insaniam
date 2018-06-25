using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinMessage : MonoBehaviour {

	public void ResetScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
