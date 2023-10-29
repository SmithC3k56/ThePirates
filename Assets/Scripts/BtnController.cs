using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnController : MonoBehaviour
{
    [SerializeField]private Button _playBtn;
    [SerializeField]private Button _pauseBtn;

    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

   
    void Update()
    {
        
    }

  
    private void ModifyPlayBtn(){}
    private void ModifyPauseBtn(){}
}
