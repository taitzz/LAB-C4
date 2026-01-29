using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Di chuyển bằng phím mũi tên hoặc WASD
        float horizontal = Input.GetAxis("Horizontal"); // Phím A/D hoặc Trái/Phải
        float vertical = Input.GetAxis("Vertical");     // Phím W/S hoặc Lên/Xuống

        Vector3 move = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(move);
    }
}