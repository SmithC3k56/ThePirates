using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private Rigidbody2D rbShip;
    [SerializeField]private Button _musicBtn;

    public bool isStart;
    float shipFallSpeed = 0;
    public void PlayGame()
    {
        mainMenuPanel.SetActive(false);
        rbShip.gravityScale = 1;
        isStart = true;
        
    }
    private void ModifyMusicBtn()
    {
       
    }
    public IEnumerator  PauseGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("End Game");
        mainMenuPanel.SetActive(true);
        rbShip.gravityScale = 0;
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (isStart)
        {
            // Tinh diem cho player
            // Tang gia tri de ship roi nhanh hon
            shipFallSpeed = Mathf.MoveTowards(shipFallSpeed, Constant.MAXSPEED, 0.5f * Time.deltaTime);
        }
        rbShip.velocity = new Vector2(0, -shipFallSpeed);
    }
}
