using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    [SerializeField]
    private GameObject popupGameover;

    [SerializeField]
    private GameObject crocOpen, crocClose;

    [SerializeField]
    private GameObject[] toothArr;

    [SerializeField]
    private AudioSource audioCtrl;

    [SerializeField]
    private AudioClip biteSound, toothClickSound;

    private int decayToothIndex;

    void Start(){
        decayToothIndex = Random.Range(0, 10);
        crocOpen.SetActive(true);
        crocClose.SetActive(false);
        popupGameover.SetActive(false);
    }

    public void onClickTooth(int toothIndex){
        if(toothIndex == decayToothIndex){
            playSoundGameover();
            crocOpen.SetActive(false);
            crocClose.SetActive(true);
            popupGameover.SetActive(true);
        } else {
            playSoundToothClick();
            toothArr[toothIndex].SetActive(false);
        }
    }

    public void onPlayAgain(){
        for(int i=0; i<10; i++){
            toothArr[i].SetActive(true);
        }
        decayToothIndex = Random.Range(0, 10);
        crocOpen.SetActive(true);
        crocClose.SetActive(false);
        popupGameover.SetActive(false);
    }

    private void playSoundGameover(){
        audioCtrl.PlayOneShot(biteSound);
    }

    private void playSoundToothClick(){
        audioCtrl.PlayOneShot(toothClickSound);
    }
}
