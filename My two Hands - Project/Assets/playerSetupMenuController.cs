using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerSetupMenuController : MonoBehaviour
{
    private int PlayerIndex;
    [SerializeField] TextMeshProUGUI _titleTexxt;
    [SerializeField] GameObject _readyPanel;
    [SerializeField] GameObject _menuPanel;
    [SerializeField] float ignoreInputTime = 1.5f;
    [SerializeField] bool _inputEnabled;
    [SerializeField] Button _readyButton;
    //[SerializeField] GameObject _readybtnObj;


    public void SetPlayerIndex(int pi)
    {
        PlayerIndex = pi;
        _titleTexxt.SetText("Player " + (pi + 1).ToString());
        ignoreInputTime = Time.time + ignoreInputTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > ignoreInputTime)
        {
            _inputEnabled = true;
        }

        
    }


    public void SetColour(Material color)
    {
        if (!_inputEnabled) { return; }

        PlayerConfigManager.Instance.SetPlayerColour(PlayerIndex, color);
        _menuPanel.SetActive(true);
        _readyButton.Select();
        _menuPanel.SetActive(false);

    }

    public void ReadyPlayer()
    {
        if (!_inputEnabled) { return; }

        PlayerConfigManager.Instance.ReacdyPlayer(PlayerIndex);
        _readyButton.gameObject.SetActive(false);

    }
}
