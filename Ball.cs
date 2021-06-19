using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc; // tham chieu den script GameController va dat ten la m_gc

    private void Start()
    {
        m_gc = FindObjectOfType<GameController>(); // tham chiu thuong phai find object of type
    }
    private void OnCollisionEnter2D(Collision2D col) // Ham va cham 2d theo kieu va cham vat ly
    {
        if (col.gameObject.CompareTag("Player")) // neu col co kieu Collision2D tham chieu den gameobject co tag la Player
        {
            m_gc.IncrementScore(); // Game controller tham chieu den Ham IncrementScore
            Destroy(gameObject); // Ham xoa doi tuong co tag la player
            Debug.Log("Va cham"); // kiem tra da va cham hay chua
        }
       
    }

    private void OnTriggerEnter2D(Collider2D col) // Ham va cham 2d co kieu phi vat ly (xuyen qua)
    {
        if(col.CompareTag("DeathZone")) // neu col co kieu colider 2d ma cham den vung co tag la deathzone
        {
            m_gc.SetGameoverState(true);
            Destroy(gameObject);
            Debug.Log("Game over");
        }
    }

}
