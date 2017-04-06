using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIController : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
    }

    public void Unlock()
    {

        InventorySlot.inventory.addItem(new Decrypt(1));
    }

    public void Lock()
    {
        InventorySlot.inventory.addItem(new Encrypt(1));
    }

    public void Unlock2()
    {

        InventorySlot.inventory.addItem(new Decrypt(2));
    }

    public void Lock2()
    {
        InventorySlot.inventory.addItem(new Encrypt(2));
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Player(int player)
    {
        PlayerUI.player = player;
    }

}
