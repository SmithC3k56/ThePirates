using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private Rigidbody2D rbShip;
    [SerializeField]private Image _musicBtnImage;
    [SerializeField]private Sprite _musicOnSpr,_musicOffSpr;
    private AudioSource _bgMusic;
    public bool isStart;
    float _shipFallSpeed = 0;

    private void Start()
    {
        this._bgMusic = this.gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isStart)
        {
            // Tinh diem cho player
            // Tang gia tri de ship roi nhanh hon
            _shipFallSpeed = Mathf.MoveTowards(_shipFallSpeed, Constant.MAXSPEED, 0.5f * Time.deltaTime);
        }

        rbShip.velocity = new Vector2(0, -_shipFallSpeed);
    }
    
    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        rbShip.gravityScale = 1;
        isStart = true;
        
    }
    public void ModifyMusicBtn()
    {
        if (_bgMusic.isPlaying)
        {
            _musicBtnImage.sprite = _musicOffSpr;
            _bgMusic.Stop();
        }
        else
        {
            _musicBtnImage.sprite = _musicOnSpr;
            _bgMusic.Play();
        }
    }
    
    
    public IEnumerator  PauseGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("End Game");
        mainMenuPanel.SetActive(true);
        rbShip.gravityScale = 0;
        Time.timeScale = 0;
    }

}
