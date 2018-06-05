using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameLogic : MonoBehaviour
{
	public GameObject startUI, restartUI;
    public GameObject successSound, failSound;

    public GameObject lightCheck;
    public Material[] lightMaterials;

    public GemsBehavior[] gems;

    public bool gameIsOver = false;

	public void ToggleUI()
	{
		startUI.SetActive(!startUI.activeSelf);
		
	}


    public void Restart(){
        SceneManager.LoadScene("ScapeRoom");
    }

    public void PlaySuccessSound(){
        PlaySound(successSound);
        lightCheck.GetComponent<MeshRenderer>().material = lightMaterials[1];
        restartUI.SetActive(!restartUI.activeSelf);
    }

    public void PlayFailSound()
    {
        PlaySound(failSound);
        lightCheck.GetComponent<MeshRenderer>().material = lightMaterials[2];
    }

    private void PlaySound(GameObject soundSource){
        soundSource.GetComponent<GvrAudioSource>().Play();
    }

    public void GemChecker(){
        bool correct = true;
        if(gems[0].theChoosenOne != 0){
            correct = false;
        } else if(gems[1].theChoosenOne != 1){
            correct = false;
        } else if (gems[2].theChoosenOne != 2)
        {
            correct = false;
        } else if (gems[3].theChoosenOne != 3)
        {
            correct = false;
        }

        if(correct){
            PlaySuccessSound();
            gameIsOver = true;
        } else {
            PlayFailSound();
        }
    }
}
