using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject CountDown3;
    public GameObject CountDown2;
    public GameObject CountDown1;
    public GameObject CountDownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;
    void Start()
    {
        StartCoroutine(CountSequence());
    }
    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        CountDown3.SetActive(true);
        readyFX.Play();
         yield return new WaitForSeconds(1);
        CountDown3.SetActive(false);
        CountDown2.SetActive(true);
        readyFX.Play();
         yield return new WaitForSeconds(1);
         CountDown2.SetActive(false);
        CountDown1.SetActive(true);
        readyFX.Play();
         yield return new WaitForSeconds(1);
         CountDown1.SetActive(false);
        CountDownGo.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(1);
         CountDownGo.SetActive(false);
        PlayerMove.canMove = true;
    }
}
